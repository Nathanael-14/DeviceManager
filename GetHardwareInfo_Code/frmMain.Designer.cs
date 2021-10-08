namespace GetHardwareInfo
{
    partial class frmMain
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
            this.tabHardware = new System.Windows.Forms.TabPage();
            this.chkHardware = new System.Windows.Forms.CheckBox();
            this.cmbxOption = new System.Windows.Forms.ComboBox();
            this.lstDisplayHardware = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabDataStorage = new System.Windows.Forms.TabPage();
            this.chkDataStorage = new System.Windows.Forms.CheckBox();
            this.cmbxStorage = new System.Windows.Forms.ComboBox();
            this.lstStorage = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMemory = new System.Windows.Forms.TabPage();
            this.chkMemory = new System.Windows.Forms.CheckBox();
            this.cmbxMemory = new System.Windows.Forms.ComboBox();
            this.lstMemory = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSystemInfo = new System.Windows.Forms.TabPage();
            this.chkSystemInfo = new System.Windows.Forms.CheckBox();
            this.cmbxSystemInfo = new System.Windows.Forms.ComboBox();
            this.lstSystemInfo = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabNetwork = new System.Windows.Forms.TabPage();
            this.chkNetwork = new System.Windows.Forms.CheckBox();
            this.cmbxNetwork = new System.Windows.Forms.ComboBox();
            this.lstNetwork = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainTabControl.SuspendLayout();
            this.tabHardware.SuspendLayout();
            this.tabDataStorage.SuspendLayout();
            this.tabMemory.SuspendLayout();
            this.tabSystemInfo.SuspendLayout();
            this.tabNetwork.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabHardware);
            this.MainTabControl.Controls.Add(this.tabDataStorage);
            this.MainTabControl.Controls.Add(this.tabMemory);
            this.MainTabControl.Controls.Add(this.tabSystemInfo);
            this.MainTabControl.Controls.Add(this.tabNetwork);
            this.MainTabControl.Controls.Add(this.tabAbout);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(648, 457);
            this.MainTabControl.TabIndex = 0;
            // 
            // tabHardware
            // 
            this.tabHardware.Controls.Add(this.chkHardware);
            this.tabHardware.Controls.Add(this.cmbxOption);
            this.tabHardware.Controls.Add(this.lstDisplayHardware);
            this.tabHardware.Location = new System.Drawing.Point(4, 22);
            this.tabHardware.Name = "tabHardware";
            this.tabHardware.Padding = new System.Windows.Forms.Padding(3);
            this.tabHardware.Size = new System.Drawing.Size(640, 431);
            this.tabHardware.TabIndex = 0;
            this.tabHardware.Text = "Hardware Info";
            this.tabHardware.UseVisualStyleBackColor = true;
            // 
            // chkHardware
            // 
            this.chkHardware.AutoSize = true;
            this.chkHardware.Checked = true;
            this.chkHardware.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHardware.Location = new System.Drawing.Point(16, 18);
            this.chkHardware.Name = "chkHardware";
            this.chkHardware.Size = new System.Drawing.Size(162, 17);
            this.chkHardware.TabIndex = 2;
            this.chkHardware.Text = "Dont Display null Value items";
            this.chkHardware.UseVisualStyleBackColor = true;
            this.chkHardware.CheckedChanged += new System.EventHandler(this.chkHardware_CheckedChanged);
            // 
            // cmbxOption
            // 
            this.cmbxOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxOption.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxOption.FormattingEnabled = true;
            this.cmbxOption.Items.AddRange(new object[] {
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
            "Win32_DMAChannel",
            "Win32_DriverVXD",
            "Win32_FloppyController",
            "Win32_FloppyDrive",
            "Win32_HeatPipe",
            "Win32_IDEController",
            "Win32_IDEControllerDevice",
            "Win32_InfraredDevice",
            "Win32_IRQResource",
            "Win32_Keyboard",
            "Win32_MotherboardDevice",
            "Win32_OnBoardDevice",
            "Win32_PCMCIAController",
            "Win32_PNPAllocatedResource",
            "Win32_PnPDevice",
            "Win32_PnPEntity",
            "Win32_PointingDevice",
            "Win32_PortableBattery",
            "Win32_PortConnector",
            "Win32_PortResource",
            "Win32_POTSModem",
            "Win32_POTSModemToSerialPort",
            "Win32_PowerManagementEvent",
            "Win32_Printer",
            "Win32_PrinterConfiguration",
            "Win32_PrinterController",
            "Win32_PrinterDriverDll",
            "Win32_PrinterSetting",
            "Win32_PrinterShare",
            "Win32_PrintJob",
            "Win32_Processor",
            "Win32_SCSIController",
            "Win32_SCSIControllerDevice",
            "Win32_SerialPort",
            "Win32_SerialPortConfiguration",
            "Win32_SerialPortSetting",
            "Win32_SMBIOSMemory",
            "Win32_SoundDevice",
            "Win32_TemperatureProbe",
            "Win32_USBController",
            "Win32_USBControllerDevice",
            "Win32_VideoConfiguration",
            "Win32_VideoController",
            "Win32_VideoSettings",
            "Win32_VoltageProbe"});
            this.cmbxOption.Location = new System.Drawing.Point(434, 16);
            this.cmbxOption.Name = "cmbxOption";
            this.cmbxOption.Size = new System.Drawing.Size(194, 21);
            this.cmbxOption.Sorted = true;
            this.cmbxOption.TabIndex = 1;
            this.cmbxOption.SelectedIndexChanged += new System.EventHandler(this.cmbxOption_SelectedIndexChanged);
            // 
            // lstDisplayHardware
            // 
            this.lstDisplayHardware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDisplayHardware.HideSelection = false;
            this.lstDisplayHardware.Location = new System.Drawing.Point(16, 41);
            this.lstDisplayHardware.Name = "lstDisplayHardware";
            this.lstDisplayHardware.Size = new System.Drawing.Size(612, 380);
            this.lstDisplayHardware.TabIndex = 0;
            this.lstDisplayHardware.UseCompatibleStateImageBehavior = false;
            this.lstDisplayHardware.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 503;
            // 
            // tabDataStorage
            // 
            this.tabDataStorage.Controls.Add(this.chkDataStorage);
            this.tabDataStorage.Controls.Add(this.cmbxStorage);
            this.tabDataStorage.Controls.Add(this.lstStorage);
            this.tabDataStorage.Location = new System.Drawing.Point(4, 22);
            this.tabDataStorage.Name = "tabDataStorage";
            this.tabDataStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataStorage.Size = new System.Drawing.Size(640, 431);
            this.tabDataStorage.TabIndex = 4;
            this.tabDataStorage.Text = "Data Storage";
            this.tabDataStorage.UseVisualStyleBackColor = true;
            // 
            // chkDataStorage
            // 
            this.chkDataStorage.AutoSize = true;
            this.chkDataStorage.Checked = true;
            this.chkDataStorage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataStorage.Location = new System.Drawing.Point(16, 18);
            this.chkDataStorage.Name = "chkDataStorage";
            this.chkDataStorage.Size = new System.Drawing.Size(162, 17);
            this.chkDataStorage.TabIndex = 5;
            this.chkDataStorage.Text = "Dont Display null Value items";
            this.chkDataStorage.UseVisualStyleBackColor = true;
            this.chkDataStorage.CheckedChanged += new System.EventHandler(this.chkDataStorage_CheckedChanged);
            // 
            // cmbxStorage
            // 
            this.cmbxStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxStorage.FormattingEnabled = true;
            this.cmbxStorage.Items.AddRange(new object[] {
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
            this.cmbxStorage.Location = new System.Drawing.Point(434, 16);
            this.cmbxStorage.Name = "cmbxStorage";
            this.cmbxStorage.Size = new System.Drawing.Size(194, 21);
            this.cmbxStorage.TabIndex = 4;
            this.cmbxStorage.SelectedIndexChanged += new System.EventHandler(this.cmbxStorage_SelectedIndexChanged);
            // 
            // lstStorage
            // 
            this.lstStorage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.lstStorage.HideSelection = false;
            this.lstStorage.Location = new System.Drawing.Point(16, 41);
            this.lstStorage.Name = "lstStorage";
            this.lstStorage.Size = new System.Drawing.Size(612, 380);
            this.lstStorage.TabIndex = 3;
            this.lstStorage.UseCompatibleStateImageBehavior = false;
            this.lstStorage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Name";
            this.columnHeader11.Width = 72;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Value";
            this.columnHeader12.Width = 503;
            // 
            // tabMemory
            // 
            this.tabMemory.Controls.Add(this.chkMemory);
            this.tabMemory.Controls.Add(this.cmbxMemory);
            this.tabMemory.Controls.Add(this.lstMemory);
            this.tabMemory.Location = new System.Drawing.Point(4, 22);
            this.tabMemory.Name = "tabMemory";
            this.tabMemory.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemory.Size = new System.Drawing.Size(640, 431);
            this.tabMemory.TabIndex = 7;
            this.tabMemory.Text = "Memory";
            this.tabMemory.UseVisualStyleBackColor = true;
            // 
            // chkMemory
            // 
            this.chkMemory.AutoSize = true;
            this.chkMemory.Checked = true;
            this.chkMemory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMemory.Location = new System.Drawing.Point(16, 18);
            this.chkMemory.Name = "chkMemory";
            this.chkMemory.Size = new System.Drawing.Size(162, 17);
            this.chkMemory.TabIndex = 9;
            this.chkMemory.Text = "Dont Display null Value items";
            this.chkMemory.UseVisualStyleBackColor = true;
            this.chkMemory.CheckedChanged += new System.EventHandler(this.chkMemory_CheckedChanged);
            // 
            // cmbxMemory
            // 
            this.cmbxMemory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMemory.FormattingEnabled = true;
            this.cmbxMemory.Items.AddRange(new object[] {
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
            this.cmbxMemory.Location = new System.Drawing.Point(434, 16);
            this.cmbxMemory.Name = "cmbxMemory";
            this.cmbxMemory.Size = new System.Drawing.Size(194, 21);
            this.cmbxMemory.TabIndex = 8;
            this.cmbxMemory.SelectedIndexChanged += new System.EventHandler(this.cmbxMemory_SelectedIndexChanged);
            // 
            // lstMemory
            // 
            this.lstMemory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18});
            this.lstMemory.HideSelection = false;
            this.lstMemory.Location = new System.Drawing.Point(16, 41);
            this.lstMemory.Name = "lstMemory";
            this.lstMemory.Size = new System.Drawing.Size(612, 380);
            this.lstMemory.TabIndex = 7;
            this.lstMemory.UseCompatibleStateImageBehavior = false;
            this.lstMemory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Name";
            this.columnHeader17.Width = 72;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Value";
            this.columnHeader18.Width = 503;
            // 
            // tabSystemInfo
            // 
            this.tabSystemInfo.Controls.Add(this.chkSystemInfo);
            this.tabSystemInfo.Controls.Add(this.cmbxSystemInfo);
            this.tabSystemInfo.Controls.Add(this.lstSystemInfo);
            this.tabSystemInfo.Location = new System.Drawing.Point(4, 22);
            this.tabSystemInfo.Name = "tabSystemInfo";
            this.tabSystemInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystemInfo.Size = new System.Drawing.Size(640, 431);
            this.tabSystemInfo.TabIndex = 2;
            this.tabSystemInfo.Text = "System Info";
            this.tabSystemInfo.UseVisualStyleBackColor = true;
            // 
            // chkSystemInfo
            // 
            this.chkSystemInfo.AutoSize = true;
            this.chkSystemInfo.Checked = true;
            this.chkSystemInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSystemInfo.Location = new System.Drawing.Point(16, 18);
            this.chkSystemInfo.Name = "chkSystemInfo";
            this.chkSystemInfo.Size = new System.Drawing.Size(162, 17);
            this.chkSystemInfo.TabIndex = 5;
            this.chkSystemInfo.Text = "Dont Display null Value items";
            this.chkSystemInfo.UseVisualStyleBackColor = true;
            this.chkSystemInfo.CheckedChanged += new System.EventHandler(this.chkSystemInfo_CheckedChanged);
            // 
            // cmbxSystemInfo
            // 
            this.cmbxSystemInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSystemInfo.FormattingEnabled = true;
            this.cmbxSystemInfo.Items.AddRange(new object[] {
            "Win32_ACE",
            "Win32_ActionCheck",
            "Win32_AllocatedResource",
            "Win32_ApplicationCommandLine",
            "Win32_ApplicationService",
            "Win32_ApplicationCommandLine",
            "Win32_ApplicationService",
            "Win32_Account",
            "Win32_AccountSID",
            "Win32_ACE",
            "Win32_ActionCheck",
            "Win32_AllocatedResource",
            "Win32_AssociatedBattery",
            "Win32_AssociatedProcessorMemory",
            "Win32_Process",
            "Win32_ProcessStartup",
            "Win32_Product",
            "Win32_ProductCheck",
            "Win32_ProductResource",
            "Win32_ProductSoftwareFeatures",
            "Win32_ProgIDSpecification",
            "Win32_ProgramGroup",
            "Win32_ProgramGroupContents",
            "Win32_ProgramGroupOrItem",
            "Win32_Property",
            "Win32_ProtocolBinding",
            "Win32_PublishComponentAction",
            "Win32_QuickFixEngineering",
            "Win32_Refrigeration",
            "Win32_Registry",
            "Win32_RegistryAction",
            "Win32_SystemAccount",
            "Win32_SystemBIOS",
            "Win32_SystemBootConfiguration",
            "Win32_SystemDesktop",
            "Win32_SystemDevices",
            "Win32_SystemDriver",
            "Win32_SystemDriverPNPEntity",
            "Win32_SystemEnclosure",
            "Win32_SystemLoadOrderGroups",
            "Win32_SystemLogicalMemoryConfiguration",
            "Win32_SystemMemoryResource",
            "Win32_SystemOperatingSystem",
            "Win32_SystemPartitions",
            "Win32_SystemProcesses",
            "Win32_SystemProgramGroups",
            "Win32_SystemResources",
            "Win32_SystemServices",
            "Win32_SystemSetting",
            "Win32_SystemSlot",
            "Win32_SystemSystemDriver",
            "Win32_SystemTimeZone",
            "Win32_ComputerSystem",
            "Win32_ComputerSystemProcessor",
            "Win32_ComputerSystemProduct",
            "Win32_Service",
            "Win32_ServiceControl",
            "Win32_ServiceSpecification",
            "Win32_ServiceSpecificationService"});
            this.cmbxSystemInfo.Location = new System.Drawing.Point(434, 16);
            this.cmbxSystemInfo.Name = "cmbxSystemInfo";
            this.cmbxSystemInfo.Size = new System.Drawing.Size(194, 21);
            this.cmbxSystemInfo.TabIndex = 4;
            this.cmbxSystemInfo.SelectedIndexChanged += new System.EventHandler(this.cmbxSystemInfo_SelectedIndexChanged);
            // 
            // lstSystemInfo
            // 
            this.lstSystemInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lstSystemInfo.HideSelection = false;
            this.lstSystemInfo.Location = new System.Drawing.Point(16, 41);
            this.lstSystemInfo.Name = "lstSystemInfo";
            this.lstSystemInfo.Size = new System.Drawing.Size(612, 380);
            this.lstSystemInfo.TabIndex = 3;
            this.lstSystemInfo.UseCompatibleStateImageBehavior = false;
            this.lstSystemInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 72;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Value";
            this.columnHeader8.Width = 503;
            // 
            // tabNetwork
            // 
            this.tabNetwork.Controls.Add(this.chkNetwork);
            this.tabNetwork.Controls.Add(this.cmbxNetwork);
            this.tabNetwork.Controls.Add(this.lstNetwork);
            this.tabNetwork.Location = new System.Drawing.Point(4, 22);
            this.tabNetwork.Name = "tabNetwork";
            this.tabNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetwork.Size = new System.Drawing.Size(640, 431);
            this.tabNetwork.TabIndex = 1;
            this.tabNetwork.Text = "Network";
            this.tabNetwork.UseVisualStyleBackColor = true;
            // 
            // chkNetwork
            // 
            this.chkNetwork.AutoSize = true;
            this.chkNetwork.Checked = true;
            this.chkNetwork.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNetwork.Location = new System.Drawing.Point(16, 18);
            this.chkNetwork.Name = "chkNetwork";
            this.chkNetwork.Size = new System.Drawing.Size(162, 17);
            this.chkNetwork.TabIndex = 3;
            this.chkNetwork.Text = "Dont Display null Value items";
            this.chkNetwork.UseVisualStyleBackColor = true;
            this.chkNetwork.CheckedChanged += new System.EventHandler(this.chkNetwork_CheckedChanged);
            // 
            // cmbxNetwork
            // 
            this.cmbxNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxNetwork.FormattingEnabled = true;
            this.cmbxNetwork.Items.AddRange(new object[] {
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
            this.cmbxNetwork.Location = new System.Drawing.Point(434, 16);
            this.cmbxNetwork.Name = "cmbxNetwork";
            this.cmbxNetwork.Size = new System.Drawing.Size(194, 21);
            this.cmbxNetwork.TabIndex = 2;
            this.cmbxNetwork.SelectedIndexChanged += new System.EventHandler(this.cmbxNetwork_SelectedIndexChanged);
            // 
            // lstNetwork
            // 
            this.lstNetwork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstNetwork.HideSelection = false;
            this.lstNetwork.Location = new System.Drawing.Point(16, 41);
            this.lstNetwork.Name = "lstNetwork";
            this.lstNetwork.Size = new System.Drawing.Size(612, 380);
            this.lstNetwork.TabIndex = 1;
            this.lstNetwork.UseCompatibleStateImageBehavior = false;
            this.lstNetwork.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 503;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.label2);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(640, 431);
            this.tabAbout.TabIndex = 8;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(261, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produced by:";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 72;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.Width = 503;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 457);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Get Hardware Information";
            this.MainTabControl.ResumeLayout(false);
            this.tabHardware.ResumeLayout(false);
            this.tabHardware.PerformLayout();
            this.tabDataStorage.ResumeLayout(false);
            this.tabDataStorage.PerformLayout();
            this.tabMemory.ResumeLayout(false);
            this.tabMemory.PerformLayout();
            this.tabSystemInfo.ResumeLayout(false);
            this.tabSystemInfo.PerformLayout();
            this.tabNetwork.ResumeLayout(false);
            this.tabNetwork.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabHardware;
        private System.Windows.Forms.TabPage tabNetwork;
        private System.Windows.Forms.ListView lstDisplayHardware;
        private System.Windows.Forms.TabPage tabSystemInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cmbxOption;
        private System.Windows.Forms.ListView lstNetwork;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cmbxNetwork;
        private System.Windows.Forms.ComboBox cmbxSystemInfo;
        private System.Windows.Forms.ListView lstSystemInfo;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage tabDataStorage;
        private System.Windows.Forms.ComboBox cmbxStorage;
        private System.Windows.Forms.ListView lstStorage;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tabMemory;
        private System.Windows.Forms.ComboBox cmbxMemory;
        private System.Windows.Forms.ListView lstMemory;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.CheckBox chkHardware;
        private System.Windows.Forms.CheckBox chkNetwork;
        private System.Windows.Forms.CheckBox chkSystemInfo;
        private System.Windows.Forms.CheckBox chkDataStorage;
        private System.Windows.Forms.CheckBox chkMemory;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label label2;
    }
}