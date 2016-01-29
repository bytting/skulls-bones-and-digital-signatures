namespace nrpa_keys
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ilKeys = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblView = new System.Windows.Forms.ToolStripLabel();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabs = new TabControlWizard.TabControlWizard();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.flowMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuKeys = new System.Windows.Forms.Button();
            this.btnMenuSign = new System.Windows.Forms.Button();
            this.btnMenuVerify = new System.Windows.Forms.Button();
            this.btnMenuSettings = new System.Windows.Forms.Button();
            this.tabKeys = new System.Windows.Forms.TabPage();
            this.lwKeys = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportPubKey = new System.Windows.Forms.Button();
            this.btnNewKey = new System.Windows.Forms.Button();
            this.tabSign = new System.Windows.Forms.TabPage();
            this.lwSign = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignFile = new System.Windows.Forms.Button();
            this.tabVerify = new System.Windows.Forms.TabPage();
            this.lwVerify = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVerify = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tblSettings = new System.Windows.Forms.TableLayoutPanel();
            this.cbSettingsUseDbForPriv = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSettingsPrivateKeyFolder = new System.Windows.Forms.TextBox();
            this.btnSettingsChangePrivFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSettingsPublicKeyDbString = new System.Windows.Forms.TextBox();
            this.tbSettingsPublicKeyFolder = new System.Windows.Forms.TextBox();
            this.btnSettingsChangePubFolder = new System.Windows.Forms.Button();
            this.cbSettingsUseDbForPub = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSettingsPrivateKeyDbString = new System.Windows.Forms.TextBox();
            this.panelLog = new System.Windows.Forms.Panel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.flowMenu.SuspendLayout();
            this.tabKeys.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSign.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabVerify.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tblSettings.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(618, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(618, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemClose});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MenuItemFile.Text = "&File";
            // 
            // MenuItemClose
            // 
            this.MenuItemClose.Name = "MenuItemClose";
            this.MenuItemClose.Size = new System.Drawing.Size(152, 22);
            this.MenuItemClose.Text = "E&xit";
            this.MenuItemClose.Click += new System.EventHandler(this.MenuItemClose_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuItemHelp.Text = "&Help";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(152, 22);
            this.MenuItemAbout.Text = "&About...";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // ilKeys
            // 
            this.ilKeys.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilKeys.ImageStream")));
            this.ilKeys.TransparentColor = System.Drawing.Color.Transparent;
            this.ilKeys.Images.SetKeyName(0, "key-128x128.png");
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.toolStripSeparator1,
            this.lblView});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(618, 25);
            this.toolStrip.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 22);
            this.btnBack.Text = "Meny";
            this.btnBack.ToolTipText = "Tilbake til hovedmeny";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblView
            // 
            this.lblView.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(51, 22);
            this.lblView.Text = "<View>";
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.ShowNewFolderButton = false;
            // 
            // FileDialog
            // 
            this.FileDialog.Multiselect = true;
            this.FileDialog.Title = "Velg fil";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabMenu);
            this.tabs.Controls.Add(this.tabKeys);
            this.tabs.Controls.Add(this.tabSign);
            this.tabs.Controls.Add(this.tabVerify);
            this.tabs.Controls.Add(this.tabSettings);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 49);
            this.tabs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(618, 284);
            this.tabs.TabIndex = 4;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabMenu.Controls.Add(this.flowMenu);
            this.tabMenu.Location = new System.Drawing.Point(4, 23);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMenu.Size = new System.Drawing.Size(610, 257);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Menu";
            // 
            // flowMenu
            // 
            this.flowMenu.Controls.Add(this.btnMenuKeys);
            this.flowMenu.Controls.Add(this.btnMenuSign);
            this.flowMenu.Controls.Add(this.btnMenuVerify);
            this.flowMenu.Controls.Add(this.btnMenuSettings);
            this.flowMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMenu.Location = new System.Drawing.Point(2, 2);
            this.flowMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowMenu.Name = "flowMenu";
            this.flowMenu.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.flowMenu.Size = new System.Drawing.Size(606, 253);
            this.flowMenu.TabIndex = 0;
            // 
            // btnMenuKeys
            // 
            this.btnMenuKeys.FlatAppearance.BorderSize = 0;
            this.btnMenuKeys.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuKeys.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuKeys.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuKeys.Image")));
            this.btnMenuKeys.Location = new System.Drawing.Point(17, 18);
            this.btnMenuKeys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuKeys.Name = "btnMenuKeys";
            this.btnMenuKeys.Size = new System.Drawing.Size(120, 130);
            this.btnMenuKeys.TabIndex = 0;
            this.btnMenuKeys.Text = "My keys";
            this.btnMenuKeys.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuKeys.UseVisualStyleBackColor = true;
            this.btnMenuKeys.Click += new System.EventHandler(this.btnMenuKeys_Click);
            // 
            // btnMenuSign
            // 
            this.btnMenuSign.FlatAppearance.BorderSize = 0;
            this.btnMenuSign.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuSign.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSign.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuSign.Image")));
            this.btnMenuSign.Location = new System.Drawing.Point(141, 18);
            this.btnMenuSign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuSign.Name = "btnMenuSign";
            this.btnMenuSign.Size = new System.Drawing.Size(120, 130);
            this.btnMenuSign.TabIndex = 1;
            this.btnMenuSign.Text = "Sign";
            this.btnMenuSign.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuSign.UseVisualStyleBackColor = true;
            this.btnMenuSign.Click += new System.EventHandler(this.btnMenuSign_Click);
            // 
            // btnMenuVerify
            // 
            this.btnMenuVerify.FlatAppearance.BorderSize = 0;
            this.btnMenuVerify.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuVerify.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVerify.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuVerify.Image")));
            this.btnMenuVerify.Location = new System.Drawing.Point(265, 18);
            this.btnMenuVerify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuVerify.Name = "btnMenuVerify";
            this.btnMenuVerify.Size = new System.Drawing.Size(120, 130);
            this.btnMenuVerify.TabIndex = 2;
            this.btnMenuVerify.Text = "Verify";
            this.btnMenuVerify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuVerify.UseVisualStyleBackColor = true;
            this.btnMenuVerify.Click += new System.EventHandler(this.btnMenuVerify_Click);
            // 
            // btnMenuSettings
            // 
            this.btnMenuSettings.FlatAppearance.BorderSize = 0;
            this.btnMenuSettings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuSettings.Image")));
            this.btnMenuSettings.Location = new System.Drawing.Point(389, 18);
            this.btnMenuSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuSettings.Name = "btnMenuSettings";
            this.btnMenuSettings.Size = new System.Drawing.Size(120, 130);
            this.btnMenuSettings.TabIndex = 3;
            this.btnMenuSettings.Text = "Settings";
            this.btnMenuSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuSettings.UseVisualStyleBackColor = true;
            this.btnMenuSettings.Click += new System.EventHandler(this.btnMenuSettings_Click);
            // 
            // tabKeys
            // 
            this.tabKeys.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabKeys.Controls.Add(this.lwKeys);
            this.tabKeys.Controls.Add(this.panel1);
            this.tabKeys.Location = new System.Drawing.Point(4, 23);
            this.tabKeys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabKeys.Name = "tabKeys";
            this.tabKeys.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabKeys.Size = new System.Drawing.Size(610, 257);
            this.tabKeys.TabIndex = 1;
            this.tabKeys.Text = "My keys";
            // 
            // lwKeys
            // 
            this.lwKeys.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lwKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lwKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwKeys.LargeImageList = this.ilKeys;
            this.lwKeys.Location = new System.Drawing.Point(2, 2);
            this.lwKeys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lwKeys.MultiSelect = false;
            this.lwKeys.Name = "lwKeys";
            this.lwKeys.Size = new System.Drawing.Size(516, 253);
            this.lwKeys.SmallImageList = this.ilKeys;
            this.lwKeys.TabIndex = 4;
            this.lwKeys.UseCompatibleStateImageBehavior = false;
            this.lwKeys.SelectedIndexChanged += new System.EventHandler(this.lwKeys_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportPubKey);
            this.panel1.Controls.Add(this.btnNewKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(518, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 253);
            this.panel1.TabIndex = 5;
            // 
            // btnExportPubKey
            // 
            this.btnExportPubKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportPubKey.Enabled = false;
            this.btnExportPubKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPubKey.Location = new System.Drawing.Point(0, 81);
            this.btnExportPubKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportPubKey.Name = "btnExportPubKey";
            this.btnExportPubKey.Size = new System.Drawing.Size(90, 81);
            this.btnExportPubKey.TabIndex = 1;
            this.btnExportPubKey.Text = "Export public key";
            this.btnExportPubKey.UseVisualStyleBackColor = true;
            this.btnExportPubKey.Click += new System.EventHandler(this.btnExportPubKey_Click);
            // 
            // btnNewKey
            // 
            this.btnNewKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewKey.Image = ((System.Drawing.Image)(resources.GetObject("btnNewKey.Image")));
            this.btnNewKey.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewKey.Location = new System.Drawing.Point(0, 0);
            this.btnNewKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewKey.Name = "btnNewKey";
            this.btnNewKey.Size = new System.Drawing.Size(90, 81);
            this.btnNewKey.TabIndex = 0;
            this.btnNewKey.Text = "New key";
            this.btnNewKey.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewKey.UseVisualStyleBackColor = true;
            this.btnNewKey.Click += new System.EventHandler(this.MenuItemNewKey_Click);
            // 
            // tabSign
            // 
            this.tabSign.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabSign.Controls.Add(this.lwSign);
            this.tabSign.Controls.Add(this.panel2);
            this.tabSign.Location = new System.Drawing.Point(4, 23);
            this.tabSign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSign.Name = "tabSign";
            this.tabSign.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSign.Size = new System.Drawing.Size(610, 257);
            this.tabSign.TabIndex = 2;
            this.tabSign.Text = "Signatures";
            // 
            // lwSign
            // 
            this.lwSign.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lwSign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lwSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwSign.LargeImageList = this.ilKeys;
            this.lwSign.Location = new System.Drawing.Point(2, 2);
            this.lwSign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lwSign.MultiSelect = false;
            this.lwSign.Name = "lwSign";
            this.lwSign.Size = new System.Drawing.Size(516, 253);
            this.lwSign.SmallImageList = this.ilKeys;
            this.lwSign.TabIndex = 1;
            this.lwSign.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSignFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(518, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 253);
            this.panel2.TabIndex = 2;
            // 
            // btnSignFile
            // 
            this.btnSignFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSignFile.Image")));
            this.btnSignFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSignFile.Location = new System.Drawing.Point(0, 0);
            this.btnSignFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSignFile.Name = "btnSignFile";
            this.btnSignFile.Size = new System.Drawing.Size(90, 81);
            this.btnSignFile.TabIndex = 0;
            this.btnSignFile.Text = "Sign files";
            this.btnSignFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSignFile.UseVisualStyleBackColor = true;
            this.btnSignFile.Click += new System.EventHandler(this.MenuItemSignFile_Click);
            // 
            // tabVerify
            // 
            this.tabVerify.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabVerify.Controls.Add(this.lwVerify);
            this.tabVerify.Controls.Add(this.panel3);
            this.tabVerify.Location = new System.Drawing.Point(4, 23);
            this.tabVerify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabVerify.Name = "tabVerify";
            this.tabVerify.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabVerify.Size = new System.Drawing.Size(610, 257);
            this.tabVerify.TabIndex = 3;
            this.tabVerify.Text = "Verify";
            // 
            // lwVerify
            // 
            this.lwVerify.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lwVerify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lwVerify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwVerify.LargeImageList = this.ilKeys;
            this.lwVerify.Location = new System.Drawing.Point(2, 2);
            this.lwVerify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lwVerify.MultiSelect = false;
            this.lwVerify.Name = "lwVerify";
            this.lwVerify.Size = new System.Drawing.Size(516, 253);
            this.lwVerify.SmallImageList = this.ilKeys;
            this.lwVerify.TabIndex = 0;
            this.lwVerify.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnVerify);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(518, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 253);
            this.panel3.TabIndex = 1;
            // 
            // btnVerify
            // 
            this.btnVerify.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Image = ((System.Drawing.Image)(resources.GetObject("btnVerify.Image")));
            this.btnVerify.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerify.Location = new System.Drawing.Point(0, 0);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(90, 81);
            this.btnVerify.TabIndex = 0;
            this.btnVerify.Text = "Verify file";
            this.btnVerify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.MenuItemVerifyFile_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabSettings.Controls.Add(this.tblSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 23);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSettings.Size = new System.Drawing.Size(610, 257);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            // 
            // tblSettings
            // 
            this.tblSettings.ColumnCount = 4;
            this.tblSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSettings.Controls.Add(this.cbSettingsUseDbForPriv, 0, 1);
            this.tblSettings.Controls.Add(this.label1, 0, 2);
            this.tblSettings.Controls.Add(this.tbSettingsPrivateKeyFolder, 1, 2);
            this.tblSettings.Controls.Add(this.btnSettingsChangePrivFolder, 3, 2);
            this.tblSettings.Controls.Add(this.label2, 0, 6);
            this.tblSettings.Controls.Add(this.tbSettingsPublicKeyDbString, 1, 7);
            this.tblSettings.Controls.Add(this.tbSettingsPublicKeyFolder, 1, 6);
            this.tblSettings.Controls.Add(this.btnSettingsChangePubFolder, 3, 6);
            this.tblSettings.Controls.Add(this.cbSettingsUseDbForPub, 0, 5);
            this.tblSettings.Controls.Add(this.label3, 0, 3);
            this.tblSettings.Controls.Add(this.label4, 0, 7);
            this.tblSettings.Controls.Add(this.tbSettingsPrivateKeyDbString, 1, 3);
            this.tblSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSettings.Location = new System.Drawing.Point(2, 2);
            this.tblSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tblSettings.Name = "tblSettings";
            this.tblSettings.RowCount = 9;
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSettings.Size = new System.Drawing.Size(606, 253);
            this.tblSettings.TabIndex = 0;
            // 
            // cbSettingsUseDbForPriv
            // 
            this.cbSettingsUseDbForPriv.AutoSize = true;
            this.tblSettings.SetColumnSpan(this.cbSettingsUseDbForPriv, 2);
            this.cbSettingsUseDbForPriv.Location = new System.Drawing.Point(2, 26);
            this.cbSettingsUseDbForPriv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSettingsUseDbForPriv.Name = "cbSettingsUseDbForPriv";
            this.cbSettingsUseDbForPriv.Size = new System.Drawing.Size(167, 17);
            this.cbSettingsUseDbForPriv.TabIndex = 6;
            this.cbSettingsUseDbForPriv.Text = "Use database for private keys";
            this.cbSettingsUseDbForPriv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory to store private keys";
            // 
            // tbSettingsPrivateKeyFolder
            // 
            this.tblSettings.SetColumnSpan(this.tbSettingsPrivateKeyFolder, 2);
            this.tbSettingsPrivateKeyFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSettingsPrivateKeyFolder.Enabled = false;
            this.tbSettingsPrivateKeyFolder.Location = new System.Drawing.Point(153, 50);
            this.tbSettingsPrivateKeyFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSettingsPrivateKeyFolder.Name = "tbSettingsPrivateKeyFolder";
            this.tbSettingsPrivateKeyFolder.Size = new System.Drawing.Size(298, 20);
            this.tbSettingsPrivateKeyFolder.TabIndex = 2;
            // 
            // btnSettingsChangePrivFolder
            // 
            this.btnSettingsChangePrivFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettingsChangePrivFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsChangePrivFolder.Location = new System.Drawing.Point(455, 50);
            this.btnSettingsChangePrivFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSettingsChangePrivFolder.Name = "btnSettingsChangePrivFolder";
            this.btnSettingsChangePrivFolder.Size = new System.Drawing.Size(149, 20);
            this.btnSettingsChangePrivFolder.TabIndex = 4;
            this.btnSettingsChangePrivFolder.Text = "...";
            this.btnSettingsChangePrivFolder.UseVisualStyleBackColor = true;
            this.btnSettingsChangePrivFolder.Click += new System.EventHandler(this.btnSettingsChangePrivFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Directory to store public keys";
            // 
            // tbSettingsPublicKeyDbString
            // 
            this.tblSettings.SetColumnSpan(this.tbSettingsPublicKeyDbString, 3);
            this.tbSettingsPublicKeyDbString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSettingsPublicKeyDbString.Location = new System.Drawing.Point(153, 170);
            this.tbSettingsPublicKeyDbString.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSettingsPublicKeyDbString.Name = "tbSettingsPublicKeyDbString";
            this.tbSettingsPublicKeyDbString.Size = new System.Drawing.Size(451, 20);
            this.tbSettingsPublicKeyDbString.TabIndex = 7;
            // 
            // tbSettingsPublicKeyFolder
            // 
            this.tblSettings.SetColumnSpan(this.tbSettingsPublicKeyFolder, 2);
            this.tbSettingsPublicKeyFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSettingsPublicKeyFolder.Enabled = false;
            this.tbSettingsPublicKeyFolder.Location = new System.Drawing.Point(153, 146);
            this.tbSettingsPublicKeyFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSettingsPublicKeyFolder.Name = "tbSettingsPublicKeyFolder";
            this.tbSettingsPublicKeyFolder.Size = new System.Drawing.Size(298, 20);
            this.tbSettingsPublicKeyFolder.TabIndex = 3;
            // 
            // btnSettingsChangePubFolder
            // 
            this.btnSettingsChangePubFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettingsChangePubFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsChangePubFolder.Location = new System.Drawing.Point(455, 146);
            this.btnSettingsChangePubFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSettingsChangePubFolder.Name = "btnSettingsChangePubFolder";
            this.btnSettingsChangePubFolder.Size = new System.Drawing.Size(149, 20);
            this.btnSettingsChangePubFolder.TabIndex = 5;
            this.btnSettingsChangePubFolder.Text = "...";
            this.btnSettingsChangePubFolder.UseVisualStyleBackColor = true;
            this.btnSettingsChangePubFolder.Click += new System.EventHandler(this.btnSettingsChangePubFolder_Click);
            // 
            // cbSettingsUseDbForPub
            // 
            this.cbSettingsUseDbForPub.AutoSize = true;
            this.tblSettings.SetColumnSpan(this.cbSettingsUseDbForPub, 2);
            this.cbSettingsUseDbForPub.Location = new System.Drawing.Point(2, 122);
            this.cbSettingsUseDbForPub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSettingsUseDbForPub.Name = "cbSettingsUseDbForPub";
            this.cbSettingsUseDbForPub.Size = new System.Drawing.Size(163, 17);
            this.cbSettingsUseDbForPub.TabIndex = 8;
            this.cbSettingsUseDbForPub.Text = "Use database for public keys";
            this.cbSettingsUseDbForPub.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Database connection string";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Database connection string";
            // 
            // tbSettingsPrivateKeyDbString
            // 
            this.tblSettings.SetColumnSpan(this.tbSettingsPrivateKeyDbString, 3);
            this.tbSettingsPrivateKeyDbString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSettingsPrivateKeyDbString.Location = new System.Drawing.Point(153, 74);
            this.tbSettingsPrivateKeyDbString.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSettingsPrivateKeyDbString.Name = "tbSettingsPrivateKeyDbString";
            this.tbSettingsPrivateKeyDbString.Size = new System.Drawing.Size(451, 20);
            this.tbSettingsPrivateKeyDbString.TabIndex = 11;
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.tbLog);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLog.Location = new System.Drawing.Point(0, 333);
            this.panelLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(618, 102);
            this.panelLog.TabIndex = 5;
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.SystemColors.Info;
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLog.Location = new System.Drawing.Point(0, 0);
            this.tbLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(618, 102);
            this.tbLog.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 457);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(559, 332);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skulls, Bones and Digital Signatures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.flowMenu.ResumeLayout(false);
            this.tabKeys.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabSign.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabVerify.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tblSettings.ResumeLayout(false);
            this.tblSettings.PerformLayout();
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClose;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel lblView;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.ImageList ilKeys;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private TabControlWizard.TabControlWizard tabs;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabKeys;
        private System.Windows.Forms.TabPage tabSign;
        private System.Windows.Forms.TabPage tabVerify;
        private System.Windows.Forms.FlowLayoutPanel flowMenu;
        private System.Windows.Forms.Button btnMenuKeys;
        private System.Windows.Forms.Button btnMenuSign;
        private System.Windows.Forms.Button btnMenuVerify;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListView lwKeys;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.ListView lwSign;
        private System.Windows.Forms.ListView lwVerify;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TableLayoutPanel tblSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSettingsPrivateKeyFolder;
        private System.Windows.Forms.TextBox tbSettingsPublicKeyFolder;
        private System.Windows.Forms.Button btnSettingsChangePrivFolder;
        private System.Windows.Forms.Button btnSettingsChangePubFolder;
        private System.Windows.Forms.Button btnMenuSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewKey;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSignFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.Button btnExportPubKey;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.CheckBox cbSettingsUseDbForPriv;
        private System.Windows.Forms.TextBox tbSettingsPublicKeyDbString;
        private System.Windows.Forms.CheckBox cbSettingsUseDbForPub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSettingsPrivateKeyDbString;
    }
}

