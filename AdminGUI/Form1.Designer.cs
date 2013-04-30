/*************************************************************************
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
namespace Com.Eucalyptus.Windows
{
    partial class EucaConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EucaConfigForm));
            this.eucalTabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.groupBoxSysprep = new System.Windows.Forms.GroupBox();
            this.buttonAnswerFile = new System.Windows.Forms.Button();
            this.buttonSysprep = new System.Windows.Forms.Button();
            this.labelSysprepExplain = new System.Windows.Forms.Label();
            this.groupBoxFormatDrives = new System.Windows.Forms.GroupBox();
            this.checkBoxFormatDrives = new System.Windows.Forms.CheckBox();
            this.tabPageAD = new System.Windows.Forms.TabPage();
            this.textBoxPwdConfirm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelADStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxADOU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxADPassword = new System.Windows.Forms.TextBox();
            this.textBoxADUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxADAddress = new System.Windows.Forms.TextBox();
            this.tabPageRemoteDesktop = new System.Windows.Forms.TabPage();
            this.buttonADPermissionRemove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddRDP = new System.Windows.Forms.Button();
            this.listBoxRDPermission = new System.Windows.Forms.ListBox();
            this.buttonRDPermissionClose = new System.Windows.Forms.Button();
            this.textBoxRDPUsername = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonRDPermissionApply = new System.Windows.Forms.Button();
            this.tabPageWin2012 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddWin2012RegKeys = new System.Windows.Forms.Button();
            this.eucalTabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.groupBoxSysprep.SuspendLayout();
            this.groupBoxFormatDrives.SuspendLayout();
            this.tabPageAD.SuspendLayout();
            this.tabPageRemoteDesktop.SuspendLayout();
            this.tabPageWin2012.SuspendLayout();
            this.SuspendLayout();
            // 
            // eucalTabControl
            // 
            this.eucalTabControl.Controls.Add(this.tabPageGeneral);
            this.eucalTabControl.Controls.Add(this.tabPageAD);
            this.eucalTabControl.Controls.Add(this.tabPageRemoteDesktop);
            this.eucalTabControl.Controls.Add(this.tabPageWin2012);
            this.eucalTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eucalTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eucalTabControl.Location = new System.Drawing.Point(0, 0);
            this.eucalTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.eucalTabControl.Name = "eucalTabControl";
            this.eucalTabControl.Padding = new System.Drawing.Point(0, 0);
            this.eucalTabControl.SelectedIndex = 0;
            this.eucalTabControl.Size = new System.Drawing.Size(446, 343);
            this.eucalTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.eucalTabControl.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.groupBoxSysprep);
            this.tabPageGeneral.Controls.Add(this.groupBoxFormatDrives);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabPageGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageGeneral.Size = new System.Drawing.Size(438, 315);
            this.tabPageGeneral.TabIndex = 2;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBoxSysprep
            // 
            this.groupBoxSysprep.Controls.Add(this.buttonAnswerFile);
            this.groupBoxSysprep.Controls.Add(this.buttonSysprep);
            this.groupBoxSysprep.Controls.Add(this.labelSysprepExplain);
            this.groupBoxSysprep.Location = new System.Drawing.Point(4, 110);
            this.groupBoxSysprep.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSysprep.Name = "groupBoxSysprep";
            this.groupBoxSysprep.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSysprep.Size = new System.Drawing.Size(429, 193);
            this.groupBoxSysprep.TabIndex = 1;
            this.groupBoxSysprep.TabStop = false;
            this.groupBoxSysprep.Text = "Windows Sysprep";
            // 
            // buttonAnswerFile
            // 
            this.buttonAnswerFile.Location = new System.Drawing.Point(234, 136);
            this.buttonAnswerFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnswerFile.Name = "buttonAnswerFile";
            this.buttonAnswerFile.Size = new System.Drawing.Size(184, 41);
            this.buttonAnswerFile.TabIndex = 2;
            this.buttonAnswerFile.Text = "Open and edit \r\nsysprep answer file";
            this.buttonAnswerFile.UseVisualStyleBackColor = true;
            this.buttonAnswerFile.Click += new System.EventHandler(this.buttonAnswerFile_Click);
            // 
            // buttonSysprep
            // 
            this.buttonSysprep.Location = new System.Drawing.Point(9, 136);
            this.buttonSysprep.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSysprep.Name = "buttonSysprep";
            this.buttonSysprep.Size = new System.Drawing.Size(201, 41);
            this.buttonSysprep.TabIndex = 1;
            this.buttonSysprep.Text = "Run Sysprep \r\n(need to shutdown instance)";
            this.buttonSysprep.UseVisualStyleBackColor = true;
            this.buttonSysprep.Click += new System.EventHandler(this.buttonSysprep_Click);
            // 
            // labelSysprepExplain
            // 
            this.labelSysprepExplain.AutoSize = true;
            this.labelSysprepExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSysprepExplain.Location = new System.Drawing.Point(31, 28);
            this.labelSysprepExplain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSysprepExplain.Name = "labelSysprepExplain";
            this.labelSysprepExplain.Size = new System.Drawing.Size(363, 80);
            this.labelSysprepExplain.TabIndex = 0;
            this.labelSysprepExplain.Text = resources.GetString("labelSysprepExplain.Text");
            // 
            // groupBoxFormatDrives
            // 
            this.groupBoxFormatDrives.Controls.Add(this.checkBoxFormatDrives);
            this.groupBoxFormatDrives.Location = new System.Drawing.Point(4, 5);
            this.groupBoxFormatDrives.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFormatDrives.Name = "groupBoxFormatDrives";
            this.groupBoxFormatDrives.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFormatDrives.Size = new System.Drawing.Size(429, 83);
            this.groupBoxFormatDrives.TabIndex = 0;
            this.groupBoxFormatDrives.TabStop = false;
            this.groupBoxFormatDrives.Text = "Format drives";
            // 
            // checkBoxFormatDrives
            // 
            this.checkBoxFormatDrives.AutoSize = true;
            this.checkBoxFormatDrives.Location = new System.Drawing.Point(10, 24);
            this.checkBoxFormatDrives.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxFormatDrives.Name = "checkBoxFormatDrives";
            this.checkBoxFormatDrives.Size = new System.Drawing.Size(398, 36);
            this.checkBoxFormatDrives.TabIndex = 0;
            this.checkBoxFormatDrives.Text = "  Format uninitialized drives (e.g., ephemeral disks) and assign \r\n  drive letter" +
    "s (e.g., D:\\, E:\\) to the formatted drives.";
            this.checkBoxFormatDrives.UseVisualStyleBackColor = true;
            this.checkBoxFormatDrives.CheckedChanged += new System.EventHandler(this.checkBoxFormatDrives_CheckedChanged);
            // 
            // tabPageAD
            // 
            this.tabPageAD.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAD.Controls.Add(this.textBoxPwdConfirm);
            this.tabPageAD.Controls.Add(this.label8);
            this.tabPageAD.Controls.Add(this.buttonClear);
            this.tabPageAD.Controls.Add(this.label7);
            this.tabPageAD.Controls.Add(this.labelADStatus);
            this.tabPageAD.Controls.Add(this.label5);
            this.tabPageAD.Controls.Add(this.buttonCancel);
            this.tabPageAD.Controls.Add(this.textBoxADOU);
            this.tabPageAD.Controls.Add(this.label4);
            this.tabPageAD.Controls.Add(this.textBoxADPassword);
            this.tabPageAD.Controls.Add(this.textBoxADUsername);
            this.tabPageAD.Controls.Add(this.label3);
            this.tabPageAD.Controls.Add(this.label2);
            this.tabPageAD.Controls.Add(this.label1);
            this.tabPageAD.Controls.Add(this.buttonApply);
            this.tabPageAD.Controls.Add(this.textBoxADAddress);
            this.tabPageAD.Location = new System.Drawing.Point(4, 24);
            this.tabPageAD.Margin = new System.Windows.Forms.Padding(1);
            this.tabPageAD.Name = "tabPageAD";
            this.tabPageAD.Padding = new System.Windows.Forms.Padding(1);
            this.tabPageAD.Size = new System.Drawing.Size(438, 315);
            this.tabPageAD.TabIndex = 0;
            this.tabPageAD.Text = "ActiveDirectory";
            // 
            // textBoxPwdConfirm
            // 
            this.textBoxPwdConfirm.AcceptsReturn = true;
            this.textBoxPwdConfirm.AcceptsTab = true;
            this.textBoxPwdConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPwdConfirm.Location = new System.Drawing.Point(322, 126);
            this.textBoxPwdConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPwdConfirm.Name = "textBoxPwdConfirm";
            this.textBoxPwdConfirm.PasswordChar = '*';
            this.textBoxPwdConfirm.Size = new System.Drawing.Size(103, 21);
            this.textBoxPwdConfirm.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 106;
            this.label8.Text = "Confirm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(305, 275);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 28);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 103;
            this.label7.Text = "Status:";
            // 
            // labelADStatus
            // 
            this.labelADStatus.AutoSize = true;
            this.labelADStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelADStatus.ForeColor = System.Drawing.Color.Red;
            this.labelADStatus.Location = new System.Drawing.Point(63, 233);
            this.labelADStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelADStatus.MaximumSize = new System.Drawing.Size(285, 0);
            this.labelADStatus.Name = "labelADStatus";
            this.labelADStatus.Size = new System.Drawing.Size(63, 16);
            this.labelADStatus.TabIndex = 101;
            this.labelADStatus.Text = "Unknown";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 100;
            this.label5.Text = "(optional)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(159, 275);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(119, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxADOU
            // 
            this.textBoxADOU.AcceptsReturn = true;
            this.textBoxADOU.AcceptsTab = true;
            this.textBoxADOU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxADOU.Location = new System.Drawing.Point(140, 177);
            this.textBoxADOU.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxADOU.Name = "textBoxADOU";
            this.textBoxADOU.Size = new System.Drawing.Size(286, 21);
            this.textBoxADOU.TabIndex = 5;
            this.textBoxADOU.TextChanged += new System.EventHandler(this.textBoxADOU_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 100;
            this.label4.Text = "Organizational Unit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxADPassword
            // 
            this.textBoxADPassword.AcceptsReturn = true;
            this.textBoxADPassword.AcceptsTab = true;
            this.textBoxADPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxADPassword.Location = new System.Drawing.Point(140, 128);
            this.textBoxADPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxADPassword.Name = "textBoxADPassword";
            this.textBoxADPassword.PasswordChar = '*';
            this.textBoxADPassword.Size = new System.Drawing.Size(103, 21);
            this.textBoxADPassword.TabIndex = 3;
            this.textBoxADPassword.TextChanged += new System.EventHandler(this.textBoxADPassword_TextChanged);
            // 
            // textBoxADUsername
            // 
            this.textBoxADUsername.AcceptsReturn = true;
            this.textBoxADUsername.AcceptsTab = true;
            this.textBoxADUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxADUsername.Location = new System.Drawing.Point(140, 76);
            this.textBoxADUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxADUsername.Name = "textBoxADUsername";
            this.textBoxADUsername.Size = new System.Drawing.Size(286, 21);
            this.textBoxADUsername.TabIndex = 2;
            this.textBoxADUsername.TextChanged += new System.EventHandler(this.textBoxADUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "Admin Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 100;
            this.label2.Text = "Admin Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "AD Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(14, 275);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(119, 28);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxADAddress
            // 
            this.textBoxADAddress.AcceptsReturn = true;
            this.textBoxADAddress.AcceptsTab = true;
            this.textBoxADAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxADAddress.Location = new System.Drawing.Point(140, 24);
            this.textBoxADAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxADAddress.Name = "textBoxADAddress";
            this.textBoxADAddress.Size = new System.Drawing.Size(286, 21);
            this.textBoxADAddress.TabIndex = 1;
            this.textBoxADAddress.TextChanged += new System.EventHandler(this.textBoxADAddress_TextChanged);
            // 
            // tabPageRemoteDesktop
            // 
            this.tabPageRemoteDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageRemoteDesktop.Controls.Add(this.buttonADPermissionRemove);
            this.tabPageRemoteDesktop.Controls.Add(this.label6);
            this.tabPageRemoteDesktop.Controls.Add(this.buttonAddRDP);
            this.tabPageRemoteDesktop.Controls.Add(this.listBoxRDPermission);
            this.tabPageRemoteDesktop.Controls.Add(this.buttonRDPermissionClose);
            this.tabPageRemoteDesktop.Controls.Add(this.textBoxRDPUsername);
            this.tabPageRemoteDesktop.Controls.Add(this.label15);
            this.tabPageRemoteDesktop.Controls.Add(this.buttonRDPermissionApply);
            this.tabPageRemoteDesktop.Location = new System.Drawing.Point(4, 24);
            this.tabPageRemoteDesktop.Margin = new System.Windows.Forms.Padding(1);
            this.tabPageRemoteDesktop.Name = "tabPageRemoteDesktop";
            this.tabPageRemoteDesktop.Padding = new System.Windows.Forms.Padding(1);
            this.tabPageRemoteDesktop.Size = new System.Drawing.Size(438, 315);
            this.tabPageRemoteDesktop.TabIndex = 1;
            this.tabPageRemoteDesktop.Text = "RemoteDesktop";
            // 
            // buttonADPermissionRemove
            // 
            this.buttonADPermissionRemove.Enabled = false;
            this.buttonADPermissionRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADPermissionRemove.Location = new System.Drawing.Point(328, 74);
            this.buttonADPermissionRemove.Margin = new System.Windows.Forms.Padding(2);
            this.buttonADPermissionRemove.Name = "buttonADPermissionRemove";
            this.buttonADPermissionRemove.Size = new System.Drawing.Size(96, 22);
            this.buttonADPermissionRemove.TabIndex = 107;
            this.buttonADPermissionRemove.Text = "Remove";
            this.buttonADPermissionRemove.UseVisualStyleBackColor = true;
            this.buttonADPermissionRemove.Click += new System.EventHandler(this.buttonADPermissionRemove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(10, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(369, 16);
            this.label6.TabIndex = 106;
            this.label6.Text = "(example: mydomain\\Domain Users, localhost\\Administrator)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAddRDP
            // 
            this.buttonAddRDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRDP.Location = new System.Drawing.Point(328, 206);
            this.buttonAddRDP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddRDP.Name = "buttonAddRDP";
            this.buttonAddRDP.Size = new System.Drawing.Size(96, 22);
            this.buttonAddRDP.TabIndex = 3;
            this.buttonAddRDP.Text = "Add";
            this.buttonAddRDP.UseVisualStyleBackColor = true;
            this.buttonAddRDP.Click += new System.EventHandler(this.buttonAddRDP_Click);
            // 
            // listBoxRDPermission
            // 
            this.listBoxRDPermission.AllowDrop = true;
            this.listBoxRDPermission.FormattingEnabled = true;
            this.listBoxRDPermission.ItemHeight = 15;
            this.listBoxRDPermission.Location = new System.Drawing.Point(14, 74);
            this.listBoxRDPermission.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxRDPermission.Name = "listBoxRDPermission";
            this.listBoxRDPermission.Size = new System.Drawing.Size(300, 109);
            this.listBoxRDPermission.TabIndex = 104;
            this.listBoxRDPermission.SelectedIndexChanged += new System.EventHandler(this.listBoxRDPUsername_SelectedIndexChanged);
            // 
            // buttonRDPermissionClose
            // 
            this.buttonRDPermissionClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRDPermissionClose.Location = new System.Drawing.Point(159, 275);
            this.buttonRDPermissionClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRDPermissionClose.Name = "buttonRDPermissionClose";
            this.buttonRDPermissionClose.Size = new System.Drawing.Size(119, 28);
            this.buttonRDPermissionClose.TabIndex = 5;
            this.buttonRDPermissionClose.Text = "Close";
            this.buttonRDPermissionClose.UseVisualStyleBackColor = true;
            this.buttonRDPermissionClose.Click += new System.EventHandler(this.buttonRDPermissionClose_Click);
            // 
            // textBoxRDPUsername
            // 
            this.textBoxRDPUsername.AcceptsReturn = true;
            this.textBoxRDPUsername.AcceptsTab = true;
            this.textBoxRDPUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRDPUsername.Location = new System.Drawing.Point(14, 207);
            this.textBoxRDPUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRDPUsername.Name = "textBoxRDPUsername";
            this.textBoxRDPUsername.Size = new System.Drawing.Size(299, 21);
            this.textBoxRDPUsername.TabIndex = 2;
            this.textBoxRDPUsername.GotFocus += new System.EventHandler(this.textBoxRDPUsername_GotFocus);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 16);
            this.label15.TabIndex = 100;
            this.label15.Text = "Authorized Users/Groups";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonRDPermissionApply
            // 
            this.buttonRDPermissionApply.Enabled = false;
            this.buttonRDPermissionApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRDPermissionApply.Location = new System.Drawing.Point(14, 275);
            this.buttonRDPermissionApply.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRDPermissionApply.Name = "buttonRDPermissionApply";
            this.buttonRDPermissionApply.Size = new System.Drawing.Size(119, 28);
            this.buttonRDPermissionApply.TabIndex = 4;
            this.buttonRDPermissionApply.Text = "Apply";
            this.buttonRDPermissionApply.UseVisualStyleBackColor = true;
            this.buttonRDPermissionApply.Click += new System.EventHandler(this.buttonRDPermissionApply_Click);
            // 
            // tabPageWin2012
            // 
            this.tabPageWin2012.Controls.Add(this.label9);
            this.tabPageWin2012.Controls.Add(this.btnAddWin2012RegKeys);
            this.tabPageWin2012.Location = new System.Drawing.Point(4, 24);
            this.tabPageWin2012.Name = "tabPageWin2012";
            this.tabPageWin2012.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWin2012.Size = new System.Drawing.Size(438, 315);
            this.tabPageWin2012.TabIndex = 3;
            this.tabPageWin2012.Text = "Win2012";
            this.tabPageWin2012.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(56, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(331, 172);
            this.label9.TabIndex = 1;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // btnAddWin2012RegKeys
            // 
            this.btnAddWin2012RegKeys.Location = new System.Drawing.Point(95, 32);
            this.btnAddWin2012RegKeys.Name = "btnAddWin2012RegKeys";
            this.btnAddWin2012RegKeys.Size = new System.Drawing.Size(257, 41);
            this.btnAddWin2012RegKeys.TabIndex = 0;
            this.btnAddWin2012RegKeys.Text = "Add Win2012 OOBE Registry Keys";
            this.btnAddWin2012RegKeys.UseVisualStyleBackColor = true;
            this.btnAddWin2012RegKeys.Click += new System.EventHandler(this.btnAddWin2012RegKeys_Click);
            // 
            // EucaConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(446, 343);
            this.Controls.Add(this.eucalTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(452, 371);
            this.MinimumSize = new System.Drawing.Size(452, 371);
            this.Name = "EucaConfigForm";
            this.Text = "Eucalyptus Windows Integration";
            this.Load += new System.EventHandler(this.EucaConfigForm_Load);
            this.eucalTabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.groupBoxSysprep.ResumeLayout(false);
            this.groupBoxSysprep.PerformLayout();
            this.groupBoxFormatDrives.ResumeLayout(false);
            this.groupBoxFormatDrives.PerformLayout();
            this.tabPageAD.ResumeLayout(false);
            this.tabPageAD.PerformLayout();
            this.tabPageRemoteDesktop.ResumeLayout(false);
            this.tabPageRemoteDesktop.PerformLayout();
            this.tabPageWin2012.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl eucalTabControl;
        private System.Windows.Forms.TabPage tabPageAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxADAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxADOU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxADPassword;
        private System.Windows.Forms.TextBox textBoxADUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelADStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxPwdConfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageRemoteDesktop;
        private System.Windows.Forms.ListBox listBoxRDPermission;
        private System.Windows.Forms.Button buttonRDPermissionClose;
        private System.Windows.Forms.TextBox textBoxRDPUsername;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonRDPermissionApply;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddRDP;
        private System.Windows.Forms.Button buttonADPermissionRemove;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.GroupBox groupBoxSysprep;
        private System.Windows.Forms.GroupBox groupBoxFormatDrives;
        private System.Windows.Forms.CheckBox checkBoxFormatDrives;
        private System.Windows.Forms.Button buttonAnswerFile;
        private System.Windows.Forms.Button buttonSysprep;
        private System.Windows.Forms.Label labelSysprepExplain;
        private System.Windows.Forms.TabPage tabPageWin2012;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddWin2012RegKeys;

    }
}

