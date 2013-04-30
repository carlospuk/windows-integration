windows-integration - driverless edition 2012
==============================================

This is a modified version of the main Eucalyptus windows integration service that will:

- Install and run on Windows Server 2012
- Contains no PV drivers, so you can 'roll your own'



The main changes to the solution are:

- All PV drivers have been removed, and will not install
- Solution is re-built against .NET 4  (.NET 3.5 not installed on WinServer 2012 by default)
- Added Windows Server 2012 OS detection  (although not really used in code for anything yet)
- Added notes to install GUI to warn users about lack of drivers.


It's designed to be packaged into an .ISO with the latest Fedora drivers for KVM - for this reason, the installation GUI prints a note to users that they can point device manager at the .ISO to update the drivers.




The notes below are left unchanged from the original:


Eucalyptus windows integration is an implementation of Windows Service that runs in the Windows VM instances to prepare the VMs to work with Eucalyptus backend. The installation and usage manuals can be found at http://www.eucalyptus.com/docs.

The tool is primarily written in C# and has been tested with Visual Studio 2010 SP1.

BUILDING

1. git clone windows-integration. 

2. If neccessry, update reference to ICSharpCode.SharpZipLib.dll.

  2a. Start ->Programs -> Visual Studio 2010.

  2b. Nagivate to <Github_path>/windows-integration

      Ensure the  windows-integration/EucaWindowsService->References has
      "ICSharpCode.SharpZipLib" and it is not highlighted with  YELLOW BANG "!".

      If may be necessary to delete ICSharpCode.SharpZipLib  property 
      and add it again:

     DELETE:

     - Open "windows-integration/EucaWindowsService->References"
     - Right Click on ICSharpCode.SharpZipLib, and "Delete" 

     ADD:

     - Open "windows-integration/EucaWindowsService->References"
     - Right Click -> "Add references" 
     - Browse to the directory that includes "ICSharpCode.SharpZipLib" and select.

3. Select Eucalyptus Package project and build.

4. After the build is complete, the executables can be found at windows-integration/EucalyptusPackage/Debug 
      Windows 2008 and later: EucalyptusWindowsIntegration.msi  
      Windows 2003:           setup.exe (includes .NET 2.0 redistributable)

INSTALLATION

1. Before bundling and registering the Windows VMs to Eucalyptus, the executables should be copied to Windows VMs and be installed.
2. During the installation, either Virtio (KVM) or XEN PV drivers (Xen) will be installed. Make sure the Windows device manager detects the driver correctly.
3. For more details, refer to Eucalyptus Administration Guide (Managing images > Create an image > Create Windows image) 
