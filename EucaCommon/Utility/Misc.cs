﻿/*************************************************************************
 * Copyright 2010-2012 Eucalyptus Systems, Inc.
 *
 * Redistribution and use of this software in source and binary forms,
 * with or without modification, are permitted provided that the following
 * conditions are met:
 *
 *   Redistributions of source code must retain the above copyright notice,
 *   this list of conditions and the following disclaimer.
 *
 *   Redistributions in binary form must reproduce the above copyright
 *   notice, this list of conditions and the following disclaimer in the
 *   documentation and/or other materials provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
 * "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
 * LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
 * A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
 * OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
 * LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
 * DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
 * THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 ************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace Com.Eucalyptus
{
    public class OSEnvironment
    {
        public enum Enum_OsName { XP, Vista, Win7, S2003, S2003R2, S2008, S2012, S2008R2, NOTYETDETERMINED, UNKNOWN }

        private static Enum_OsName _osName = Enum_OsName.NOTYETDETERMINED;
        public static Enum_OsName OS_Name
        {
            get
            {
                if (_osName == Enum_OsName.NOTYETDETERMINED)
                {
                    try
                    {
                        string osName = "";
                        using (ManagementObject manObj =
                           WMIUtil.QueryLocalWMI(@"\\.\root\CIMV2", "Select * from win32_operatingsystem"))
                        {
                            osName = (string)manObj["Name"];
                        }
                        if (osName.Contains("XP"))
                        {
                            _osName = Enum_OsName.XP;
                        }
                        else if (osName.Contains("2003 R2"))
                        {
                            _osName = Enum_OsName.S2003R2;
                        }
                        else if (osName.Contains("2003"))
                        {
                            _osName = Enum_OsName.S2003;
                        }
                        else if (osName.Contains("Windows 7") | osName.Contains("Windowsr 7"))
                        {
                            _osName = Enum_OsName.Win7;
                        }
                        else if (osName.Contains("2008 R2"))
                        {
                            _osName = Enum_OsName.S2008R2;
                        }
                        else if (osName.Contains("2012"))
                        {
                            _osName = Enum_OsName.S2012;
                        }
                        else if (osName.Contains("2008"))
                        {
                            _osName = Enum_OsName.S2008;
                        }
                        else if (osName.Contains("Vista"))
                        {
                            _osName = Enum_OsName.Vista;
                        }
                        else
                            _osName = Enum_OsName.UNKNOWN;
                    }
                    catch (Exception e)
                    {
                        _osName = OSEnvironment.Enum_OsName.UNKNOWN;
                        EucaLogger.Exception("Can't figure out the OS name and version", e);
                    }
                }
                return _osName;
            }

        }

        /// <summary>
        ///  the installed service pack
        /// </summary>
        private static string _osServicePack = null;
        private static bool _osServicePackQueried = false;
        public static string OS_ServicePack
        {
            get
            {
                if (!_osServicePackQueried)
                {
                    using (ManagementObject objOs = WMIUtil.QueryLocalWMI(@"\\.\root\CIMV2", "Select * from win32_operatingsystem"))
                    {
                        try
                        {
                            _osServicePack = (string)objOs["CSDVersion"];
                        }
                        catch (Exception)
                        {
                            EucaLogger.Warning("Service pack couldn't be detected");
                            _osServicePack = null;
                        }
                        finally
                        {
                            _osServicePackQueried = true;
                        }
                    }
                }
                return _osServicePack;
            }
        }

        public static bool ServicePackEqualHigherThan(int spNum)
        {
            try
            {
                string strSP = OS_ServicePack;
                int nSP = int.Parse(strSP.Replace("Service Pack", "").Trim());
                return spNum <= nSP;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static bool _bitSizeQueried = false;
        private static bool _is64bit = false;
        public static bool Is64bit
        {
            get
            {
                if (!_bitSizeQueried)
                {
                    try
                    {
                        using (ManagementObject objOs = WMIUtil.QueryLocalWMI(@"\\.\root\CIMV2", "Select * from win32_computersystem"))
                        {
                            string systype = (string)objOs["SystemType"];
                            if (systype.Contains("64"))
                                _is64bit = true;
                            else
                                _is64bit = false;
                        }
                    }
                    catch (Exception)
                    {
                        EucaLogger.Warning("System type couldn't be detected");
                        _is64bit = false;
                    }
                    finally
                    {
                        _bitSizeQueried = true;
                    }
                }
                return _is64bit;
            }
        }
    }

    public class WMIUtil
    {
        public static ManagementObject QueryLocalWMI(string query)
        {
            return QueryLocalWMI(null, query);
        }

        public static ManagementObject QueryLocalWMI(string scope, string query)
        {
            ManagementObjectCollection col = QueryLocalWMICollection(scope, query);
            ManagementObject retObj = null;
            foreach (ManagementObject obj in col)
                retObj = obj;

            col.Dispose();
            return retObj;
        }

        public static ManagementObjectCollection QueryLocalWMICollection(string query)
        {
            return QueryLocalWMICollection(null, query);
        }

        private const int RETRY = 60;
        private const int PAUSE_SEC_BETWEEN_RETRY = 1;
        public static ManagementObjectCollection QueryLocalWMICollection(string scope, string query)
        {
            ManagementScope ms = null;
            int numTrial = 0;
            bool connected = false;
            do
            {
                try
                {
                    if (scope == null)
                        ms = new ManagementScope(@"\\.\root\cimv2", new ConnectionOptions());
                    else
                        ms = new ManagementScope(scope, new ConnectionOptions());

                    ms.Connect();
                    connected = true;
                }
                catch (Exception) // in the booting period, the WMI service may not be ready; 
                {
                    EucaLogger.Warning("WMI service is not responding; will retry");
                    System.Threading.Thread.Sleep(PAUSE_SEC_BETWEEN_RETRY * 1000);
                    continue;
                }
            } while (numTrial++ < RETRY);

            if (!connected || ms == null || !ms.IsConnected)
                throw new EucaException("Cannot establish connection to the management provider");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(ms, new ObjectQuery(query));
            ManagementObjectCollection result = searcher.Get();
            searcher.Dispose();
            return result;
        }
    }
}
