namespace LocalSystemDiagnostics
{
    partial class Form1
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.systemTab = new System.Windows.Forms.TabPage();
            this.systemListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.systemBox = new System.Windows.Forms.ComboBox();
            this.hardwareTab = new System.Windows.Forms.TabPage();
            this.hardwareListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hardwareBox = new System.Windows.Forms.ComboBox();
            this.storageTab = new System.Windows.Forms.TabPage();
            this.storageListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.storageBox = new System.Windows.Forms.ComboBox();
            this.networkTab = new System.Windows.Forms.TabPage();
            this.networkListView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.networkBox = new System.Windows.Forms.ComboBox();
            this.accountsTab = new System.Windows.Forms.TabPage();
            this.accountsListView = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountsBox = new System.Windows.Forms.ComboBox();
            this.hardwareChk = new System.Windows.Forms.CheckBox();
            this.systemChk = new System.Windows.Forms.CheckBox();
            this.storageChk = new System.Windows.Forms.CheckBox();
            this.networkChk = new System.Windows.Forms.CheckBox();
            this.accountsChk = new System.Windows.Forms.CheckBox();
            this.saveTab = new System.Windows.Forms.TabPage();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.systemSave = new System.Windows.Forms.CheckBox();
            this.accountSave = new System.Windows.Forms.CheckBox();
            this.networkSave = new System.Windows.Forms.CheckBox();
            this.storageSave = new System.Windows.Forms.CheckBox();
            this.hardwareSave = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.lableSave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MainTabControl.SuspendLayout();
            this.systemTab.SuspendLayout();
            this.hardwareTab.SuspendLayout();
            this.storageTab.SuspendLayout();
            this.networkTab.SuspendLayout();
            this.accountsTab.SuspendLayout();
            this.saveTab.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.systemTab);
            this.MainTabControl.Controls.Add(this.hardwareTab);
            this.MainTabControl.Controls.Add(this.storageTab);
            this.MainTabControl.Controls.Add(this.networkTab);
            this.MainTabControl.Controls.Add(this.accountsTab);
            this.MainTabControl.Controls.Add(this.saveTab);
            this.MainTabControl.Controls.Add(this.aboutTab);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(634, 414);
            this.MainTabControl.TabIndex = 0;
            // 
            // systemTab
            // 
            this.systemTab.Controls.Add(this.systemChk);
            this.systemTab.Controls.Add(this.systemListView);
            this.systemTab.Controls.Add(this.systemBox);
            this.systemTab.Location = new System.Drawing.Point(4, 22);
            this.systemTab.Name = "systemTab";
            this.systemTab.Size = new System.Drawing.Size(626, 388);
            this.systemTab.TabIndex = 2;
            this.systemTab.Text = "System";
            this.systemTab.UseVisualStyleBackColor = true;
            // 
            // systemListView
            // 
            this.systemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.systemListView.Location = new System.Drawing.Point(3, 46);
            this.systemListView.Name = "systemListView";
            this.systemListView.Size = new System.Drawing.Size(620, 339);
            this.systemListView.TabIndex = 1;
            this.systemListView.UseCompatibleStateImageBehavior = false;
            this.systemListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 464;
            // 
            // systemBox
            // 
            this.systemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemBox.FormattingEnabled = true;
            this.systemBox.Items.AddRange(new object[] {
            "Win32_1394Controller",
            "Win32_1394ControllerDevice",
            "Win32_BaseBoard",
            "Win32_Battery",
            "Win32_BIOS",
            "Win32_Bus",
            "Win32_CDROMDrive",
            "Win32_CIMLogicalDeviceCIMDataFile",
            "Win32_DeviceBus",
            "Win32_DeviceMemoryAddress",
            "Win32_DeviceSettings",
            "Win32_DisplayConfiguration",
            "Win32_DisplayControllerConfiguration",
            "Win32_DMAChannel"});
            this.systemBox.Location = new System.Drawing.Point(412, 19);
            this.systemBox.Name = "systemBox";
            this.systemBox.Size = new System.Drawing.Size(211, 21);
            this.systemBox.TabIndex = 0;
            this.systemBox.SelectedIndexChanged += new System.EventHandler(this.storageBox_SelectedIndexChanged);
            // 
            // hardwareTab
            // 
            this.hardwareTab.Controls.Add(this.hardwareChk);
            this.hardwareTab.Controls.Add(this.hardwareListView);
            this.hardwareTab.Controls.Add(this.hardwareBox);
            this.hardwareTab.Location = new System.Drawing.Point(4, 22);
            this.hardwareTab.Name = "hardwareTab";
            this.hardwareTab.Size = new System.Drawing.Size(626, 388);
            this.hardwareTab.TabIndex = 5;
            this.hardwareTab.Text = "Hardware";
            this.hardwareTab.UseVisualStyleBackColor = true;
            // 
            // hardwareListView
            // 
            this.hardwareListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.hardwareListView.Location = new System.Drawing.Point(3, 46);
            this.hardwareListView.Name = "hardwareListView";
            this.hardwareListView.Size = new System.Drawing.Size(620, 339);
            this.hardwareListView.TabIndex = 1;
            this.hardwareListView.UseCompatibleStateImageBehavior = false;
            this.hardwareListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 464;
            // 
            // hardwareBox
            // 
            this.hardwareBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hardwareBox.FormattingEnabled = true;
            this.hardwareBox.Items.AddRange(new object[] {
            "Win32_CacheMemory",
            "Win32_MemoryArray",
            "Win32_MemoryArrayLocation",
            "Win32_MemoryDevice",
            "Win32_MemoryDeviceArray",
            "Win32_MemoryDeviceLocation",
            "Win32_AssociatedProcessorMemory",
            "Win32_DeviceMemoryAddress",
            "Win32_LogicalMemoryConfiguration",
            "Win32_PerfRawData_PerfOS_Memory",
            "Win32_PhysicalMemory",
            "Win32_PhysicalMemoryArray",
            "Win32_PhysicalMemoryLocation",
            "Win32_SMBIOSMemory",
            "Win32_SystemLogicalMemoryConfiguration",
            "Win32_SystemMemoryResource"});
            this.hardwareBox.Location = new System.Drawing.Point(412, 19);
            this.hardwareBox.Name = "hardwareBox";
            this.hardwareBox.Size = new System.Drawing.Size(211, 21);
            this.hardwareBox.TabIndex = 0;
            this.hardwareBox.SelectedIndexChanged += new System.EventHandler(this.hardwareBox_SelectedIndexChanged);
            // 
            // storageTab
            // 
            this.storageTab.Controls.Add(this.storageChk);
            this.storageTab.Controls.Add(this.storageListView);
            this.storageTab.Controls.Add(this.storageBox);
            this.storageTab.Location = new System.Drawing.Point(4, 22);
            this.storageTab.Name = "storageTab";
            this.storageTab.Size = new System.Drawing.Size(626, 388);
            this.storageTab.TabIndex = 6;
            this.storageTab.Text = "Storage";
            this.storageTab.UseVisualStyleBackColor = true;
            // 
            // storageListView
            // 
            this.storageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.storageListView.Location = new System.Drawing.Point(3, 46);
            this.storageListView.Name = "storageListView";
            this.storageListView.Size = new System.Drawing.Size(620, 339);
            this.storageListView.TabIndex = 1;
            this.storageListView.UseCompatibleStateImageBehavior = false;
            this.storageListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.Width = 464;
            // 
            // storageBox
            // 
            this.storageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storageBox.FormattingEnabled = true;
            this.storageBox.Items.AddRange(new object[] {
            "Win32_DiskDrive",
            "Win32_DiskDriveToDiskPartition",
            "Win32_DiskPartition",
            "Win32_LogicalDisk",
            "Win32_LogicalDiskRootDirectory",
            "Win32_LogicalDiskToPartition",
            "Win32_LogicalFileAccess",
            "Win32_LogicalFileAuditing",
            "Win32_LogicalFileGroup",
            "Win32_LogicalFileOwner",
            "Win32_LogicalFileSecuritySetting",
            "Win32_TapeDrive"});
            this.storageBox.Location = new System.Drawing.Point(412, 19);
            this.storageBox.Name = "storageBox";
            this.storageBox.Size = new System.Drawing.Size(211, 21);
            this.storageBox.TabIndex = 0;
            this.storageBox.SelectedIndexChanged += new System.EventHandler(this.storageBox_SelectedIndexChanged_1);
            // 
            // networkTab
            // 
            this.networkTab.Controls.Add(this.networkChk);
            this.networkTab.Controls.Add(this.networkListView);
            this.networkTab.Controls.Add(this.networkBox);
            this.networkTab.Location = new System.Drawing.Point(4, 22);
            this.networkTab.Name = "networkTab";
            this.networkTab.Size = new System.Drawing.Size(626, 388);
            this.networkTab.TabIndex = 7;
            this.networkTab.Text = "Network";
            this.networkTab.UseVisualStyleBackColor = true;
            // 
            // networkListView
            // 
            this.networkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.networkListView.Location = new System.Drawing.Point(3, 46);
            this.networkListView.Name = "networkListView";
            this.networkListView.Size = new System.Drawing.Size(620, 339);
            this.networkListView.TabIndex = 1;
            this.networkListView.UseCompatibleStateImageBehavior = false;
            this.networkListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Value";
            this.columnHeader8.Width = 464;
            // 
            // networkBox
            // 
            this.networkBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.networkBox.FormattingEnabled = true;
            this.networkBox.Items.AddRange(new object[] {
            "Win32_NetworkAdapter",
            "Win32_NetworkAdapterConfiguration",
            "Win32_NetworkAdapterSetting",
            "Win32_NetworkClient",
            "Win32_NetworkConnection",
            "Win32_NetworkLoginProfile",
            "Win32_NetworkProtocol",
            "Win32_PerfRawData_Tcpip_ICMP",
            "Win32_PerfRawData_Tcpip_IP",
            "Win32_PerfRawData_Tcpip_NBTConnection",
            "Win32_PerfRawData_Tcpip_NetworkInterface",
            "Win32_PerfRawData_Tcpip_TCP",
            "Win32_PerfRawData_Tcpip_UDP",
            "Win32_PerfRawData_W3SVC_WebService",
            "Win32_SystemNetworkConnections"});
            this.networkBox.Location = new System.Drawing.Point(412, 19);
            this.networkBox.Name = "networkBox";
            this.networkBox.Size = new System.Drawing.Size(211, 21);
            this.networkBox.TabIndex = 0;
            this.networkBox.SelectedIndexChanged += new System.EventHandler(this.networkBox_SelectedIndexChanged);
            // 
            // accountsTab
            // 
            this.accountsTab.Controls.Add(this.accountsChk);
            this.accountsTab.Controls.Add(this.accountsListView);
            this.accountsTab.Controls.Add(this.accountsBox);
            this.accountsTab.Location = new System.Drawing.Point(4, 22);
            this.accountsTab.Name = "accountsTab";
            this.accountsTab.Size = new System.Drawing.Size(626, 388);
            this.accountsTab.TabIndex = 8;
            this.accountsTab.Text = "Accounts";
            this.accountsTab.UseVisualStyleBackColor = true;
            // 
            // accountsListView
            // 
            this.accountsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.accountsListView.Location = new System.Drawing.Point(3, 46);
            this.accountsListView.Name = "accountsListView";
            this.accountsListView.Size = new System.Drawing.Size(620, 339);
            this.accountsListView.TabIndex = 1;
            this.accountsListView.UseCompatibleStateImageBehavior = false;
            this.accountsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            this.columnHeader9.Width = 140;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Value";
            this.columnHeader10.Width = 464;
            // 
            // accountsBox
            // 
            this.accountsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountsBox.FormattingEnabled = true;
            this.accountsBox.Items.AddRange(new object[] {
            "Win32_SystemUsers",
            "Win32_Account",
            "Win32_AccountSID",
            "Win32_SecurityDescriptor",
            "Win32_SecuritySetting",
            "Win32_SecuritySettingAccess",
            "Win32_SecuritySettingAuditing",
            "Win32_SecuritySettingGroup",
            "Win32_SecuritySettingOfLogicalFile",
            "Win32_SecuritySettingOfLogicalShare",
            "Win32_SecuritySettingOfObject",
            "Win32_SecuritySettingOwner",
            "Win32_NTEventlogFile",
            "Win32_NTLogEvent",
            "Win32_NTLogEventComputer",
            "Win32_NTLogEventLog",
            "Win32_NTLogEventUser"});
            this.accountsBox.Location = new System.Drawing.Point(412, 19);
            this.accountsBox.Name = "accountsBox";
            this.accountsBox.Size = new System.Drawing.Size(211, 21);
            this.accountsBox.TabIndex = 0;
            this.accountsBox.SelectedIndexChanged += new System.EventHandler(this.accountsBox_SelectedIndexChanged);
            // 
            // hardwareChk
            // 
            this.hardwareChk.AutoSize = true;
            this.hardwareChk.Location = new System.Drawing.Point(9, 19);
            this.hardwareChk.Name = "hardwareChk";
            this.hardwareChk.Size = new System.Drawing.Size(93, 17);
            this.hardwareChk.TabIndex = 2;
            this.hardwareChk.Text = "Export to XML";
            this.hardwareChk.UseVisualStyleBackColor = true;
            this.hardwareChk.CheckedChanged += new System.EventHandler(this.hardwareChk_CheckedChanged);
            // 
            // systemChk
            // 
            this.systemChk.AutoSize = true;
            this.systemChk.Location = new System.Drawing.Point(9, 19);
            this.systemChk.Name = "systemChk";
            this.systemChk.Size = new System.Drawing.Size(93, 17);
            this.systemChk.TabIndex = 2;
            this.systemChk.Text = "Export to XML";
            this.systemChk.UseVisualStyleBackColor = true;
            this.systemChk.CheckedChanged += new System.EventHandler(this.systemChk_CheckedChanged);
            // 
            // storageChk
            // 
            this.storageChk.AutoSize = true;
            this.storageChk.Location = new System.Drawing.Point(9, 19);
            this.storageChk.Name = "storageChk";
            this.storageChk.Size = new System.Drawing.Size(93, 17);
            this.storageChk.TabIndex = 2;
            this.storageChk.Text = "Export to XML";
            this.storageChk.UseVisualStyleBackColor = true;
            // 
            // networkChk
            // 
            this.networkChk.AutoSize = true;
            this.networkChk.Location = new System.Drawing.Point(9, 19);
            this.networkChk.Name = "networkChk";
            this.networkChk.Size = new System.Drawing.Size(93, 17);
            this.networkChk.TabIndex = 2;
            this.networkChk.Text = "Export to XML";
            this.networkChk.UseVisualStyleBackColor = true;
            // 
            // accountsChk
            // 
            this.accountsChk.AutoSize = true;
            this.accountsChk.Location = new System.Drawing.Point(9, 19);
            this.accountsChk.Name = "accountsChk";
            this.accountsChk.Size = new System.Drawing.Size(93, 17);
            this.accountsChk.TabIndex = 2;
            this.accountsChk.Text = "Export to XML";
            this.accountsChk.UseVisualStyleBackColor = true;
            // 
            // saveTab
            // 
            this.saveTab.Controls.Add(this.label1);
            this.saveTab.Controls.Add(this.lableSave);
            this.saveTab.Controls.Add(this.saveBtn);
            this.saveTab.Controls.Add(this.hardwareSave);
            this.saveTab.Controls.Add(this.storageSave);
            this.saveTab.Controls.Add(this.networkSave);
            this.saveTab.Controls.Add(this.accountSave);
            this.saveTab.Controls.Add(this.systemSave);
            this.saveTab.Location = new System.Drawing.Point(4, 22);
            this.saveTab.Name = "saveTab";
            this.saveTab.Size = new System.Drawing.Size(626, 388);
            this.saveTab.TabIndex = 9;
            this.saveTab.Text = "Save";
            this.saveTab.UseVisualStyleBackColor = true;
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.richTextBox1);
            this.aboutTab.Location = new System.Drawing.Point(4, 22);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(626, 388);
            this.aboutTab.TabIndex = 10;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // systemSave
            // 
            this.systemSave.AutoSize = true;
            this.systemSave.Location = new System.Drawing.Point(179, 101);
            this.systemSave.Name = "systemSave";
            this.systemSave.Size = new System.Drawing.Size(60, 17);
            this.systemSave.TabIndex = 0;
            this.systemSave.Text = "System";
            this.systemSave.UseVisualStyleBackColor = true;
            this.systemSave.CheckedChanged += new System.EventHandler(this.systemSave_CheckedChanged);
            // 
            // accountSave
            // 
            this.accountSave.AutoSize = true;
            this.accountSave.Location = new System.Drawing.Point(179, 230);
            this.accountSave.Name = "accountSave";
            this.accountSave.Size = new System.Drawing.Size(71, 17);
            this.accountSave.TabIndex = 1;
            this.accountSave.Text = "Accounts";
            this.accountSave.UseVisualStyleBackColor = true;
            this.accountSave.CheckedChanged += new System.EventHandler(this.accountSave_CheckedChanged);
            // 
            // networkSave
            // 
            this.networkSave.AutoSize = true;
            this.networkSave.Location = new System.Drawing.Point(179, 197);
            this.networkSave.Name = "networkSave";
            this.networkSave.Size = new System.Drawing.Size(66, 17);
            this.networkSave.TabIndex = 2;
            this.networkSave.Text = "Network";
            this.networkSave.UseVisualStyleBackColor = true;
            this.networkSave.CheckedChanged += new System.EventHandler(this.networkSave_CheckedChanged);
            // 
            // storageSave
            // 
            this.storageSave.AutoSize = true;
            this.storageSave.Location = new System.Drawing.Point(179, 165);
            this.storageSave.Name = "storageSave";
            this.storageSave.Size = new System.Drawing.Size(63, 17);
            this.storageSave.TabIndex = 3;
            this.storageSave.Text = "Storage";
            this.storageSave.UseVisualStyleBackColor = true;
            this.storageSave.CheckedChanged += new System.EventHandler(this.storageSave_CheckedChanged);
            // 
            // hardwareSave
            // 
            this.hardwareSave.AutoSize = true;
            this.hardwareSave.Location = new System.Drawing.Point(179, 133);
            this.hardwareSave.Name = "hardwareSave";
            this.hardwareSave.Size = new System.Drawing.Size(72, 17);
            this.hardwareSave.TabIndex = 4;
            this.hardwareSave.Text = "Hardware";
            this.hardwareSave.UseVisualStyleBackColor = true;
            this.hardwareSave.CheckedChanged += new System.EventHandler(this.hardwareSave_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(361, 224);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // lableSave
            // 
            this.lableSave.AutoSize = true;
            this.lableSave.Location = new System.Drawing.Point(98, 41);
            this.lableSave.Name = "lableSave";
            this.lableSave.Size = new System.Drawing.Size(0, 13);
            this.lableSave.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please choose a category that you would like to export";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(121, 163);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(383, 26);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "                             An Ethan, Jackson, Jordan Collaboration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 439);
            this.Controls.Add(this.MainTabControl);
            this.Name = "Form1";
            this.Text = "Local System Diagnostics";
            this.MainTabControl.ResumeLayout(false);
            this.systemTab.ResumeLayout(false);
            this.systemTab.PerformLayout();
            this.hardwareTab.ResumeLayout(false);
            this.hardwareTab.PerformLayout();
            this.storageTab.ResumeLayout(false);
            this.storageTab.PerformLayout();
            this.networkTab.ResumeLayout(false);
            this.networkTab.PerformLayout();
            this.accountsTab.ResumeLayout(false);
            this.accountsTab.PerformLayout();
            this.saveTab.ResumeLayout(false);
            this.saveTab.PerformLayout();
            this.aboutTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage systemTab;
        private System.Windows.Forms.ListView systemListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox systemBox;
        private System.Windows.Forms.TabPage hardwareTab;
        private System.Windows.Forms.ListView hardwareListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox hardwareBox;
        private System.Windows.Forms.TabPage storageTab;
        private System.Windows.Forms.ListView storageListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox storageBox;
        private System.Windows.Forms.TabPage networkTab;
        private System.Windows.Forms.ListView networkListView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox networkBox;
        private System.Windows.Forms.TabPage accountsTab;
        private System.Windows.Forms.ListView accountsListView;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ComboBox accountsBox;
        private System.Windows.Forms.CheckBox hardwareChk;
        private System.Windows.Forms.CheckBox systemChk;
        private System.Windows.Forms.CheckBox storageChk;
        private System.Windows.Forms.CheckBox networkChk;
        private System.Windows.Forms.CheckBox accountsChk;
        private System.Windows.Forms.TabPage saveTab;
        private System.Windows.Forms.Label lableSave;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox hardwareSave;
        private System.Windows.Forms.CheckBox storageSave;
        private System.Windows.Forms.CheckBox networkSave;
        private System.Windows.Forms.CheckBox accountSave;
        private System.Windows.Forms.CheckBox systemSave;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

