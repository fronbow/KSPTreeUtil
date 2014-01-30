namespace KSPTreeUtil
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewTree = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpenTree = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveTree = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRecentMRU = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.findKSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importGameDataMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNodeTree = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tParents = new System.Windows.Forms.ListBox();
            this.tPartsList = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tHideIfEmpty = new System.Windows.Forms.ComboBox();
            this.tAnyParent = new System.Windows.Forms.ComboBox();
            this.tDesc = new System.Windows.Forms.TextBox();
            this.tTitle = new System.Windows.Forms.TextBox();
            this.tCost = new System.Windows.Forms.TextBox();
            this.tIcon = new System.Windows.Forms.ComboBox();
            this.tPos = new System.Windows.Forms.TextBox();
            this.tTechID = new System.Windows.Forms.TextBox();
            this.tNodeName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPartsAvailable = new System.Windows.Forms.ListBox();
            this.openFileMain = new System.Windows.Forms.OpenFileDialog();
            this.saveFileMain = new System.Windows.Forms.SaveFileDialog();
            this.lbConnParts = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbPartList = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.mnuSynchronise = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemOptions,
            this.importGameDataMnu,
            this.helpToolStripMenuItem,
            this.mnuSynchronise});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(757, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNewTree,
            this.MenuItemOpenTree,
            this.MenuItemSaveTree,
            this.toolStripMenuItem2,
            this.mnuRecentMRU,
            this.toolStripSeparator1,
            this.MenuItemExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MenuItemFile.Text = "File";
            // 
            // MenuItemNewTree
            // 
            this.MenuItemNewTree.Name = "MenuItemNewTree";
            this.MenuItemNewTree.Size = new System.Drawing.Size(158, 22);
            this.MenuItemNewTree.Text = "New Tech Tree";
            // 
            // MenuItemOpenTree
            // 
            this.MenuItemOpenTree.Name = "MenuItemOpenTree";
            this.MenuItemOpenTree.Size = new System.Drawing.Size(158, 22);
            this.MenuItemOpenTree.Text = "Open Tech Tree";
            this.MenuItemOpenTree.Click += new System.EventHandler(this.MenuItemOpenTree_Click);
            // 
            // MenuItemSaveTree
            // 
            this.MenuItemSaveTree.Name = "MenuItemSaveTree";
            this.MenuItemSaveTree.Size = new System.Drawing.Size(158, 22);
            this.MenuItemSaveTree.Text = "Save Tech Tree";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 6);
            // 
            // mnuRecentMRU
            // 
            this.mnuRecentMRU.Enabled = false;
            this.mnuRecentMRU.Name = "mnuRecentMRU";
            this.mnuRecentMRU.Size = new System.Drawing.Size(158, 22);
            this.mnuRecentMRU.Text = "Recent Files";
            this.mnuRecentMRU.ToolTipText = "Placeholder!";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(158, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItemOptions
            // 
            this.MenuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findKSPToolStripMenuItem});
            this.MenuItemOptions.Name = "MenuItemOptions";
            this.MenuItemOptions.Size = new System.Drawing.Size(61, 20);
            this.MenuItemOptions.Text = "Options";
            // 
            // findKSPToolStripMenuItem
            // 
            this.findKSPToolStripMenuItem.Name = "findKSPToolStripMenuItem";
            this.findKSPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.findKSPToolStripMenuItem.Text = "KSP folders";
            this.findKSPToolStripMenuItem.Click += new System.EventHandler(this.findKSPToolStripMenuItem_Click);
            // 
            // importGameDataMnu
            // 
            this.importGameDataMnu.Name = "importGameDataMnu";
            this.importGameDataMnu.Size = new System.Drawing.Size(113, 20);
            this.importGameDataMnu.Text = "Import GameData";
            this.importGameDataMnu.Click += new System.EventHandler(this.importGameDataMnu_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator6,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbNodeTree
            // 
            this.lbNodeTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNodeTree.FormattingEnabled = true;
            this.lbNodeTree.Location = new System.Drawing.Point(5, 33);
            this.lbNodeTree.Name = "lbNodeTree";
            this.lbNodeTree.Size = new System.Drawing.Size(193, 485);
            this.lbNodeTree.TabIndex = 1;
            this.lbNodeTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbNodeTree_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tParents);
            this.groupBox1.Controls.Add(this.tPartsList);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tHideIfEmpty);
            this.groupBox1.Controls.Add(this.tAnyParent);
            this.groupBox1.Controls.Add(this.tDesc);
            this.groupBox1.Controls.Add(this.tTitle);
            this.groupBox1.Controls.Add(this.tCost);
            this.groupBox1.Controls.Add(this.tIcon);
            this.groupBox1.Controls.Add(this.tPos);
            this.groupBox1.Controls.Add(this.tTechID);
            this.groupBox1.Controls.Add(this.tNodeName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(204, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 488);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Node";
            // 
            // tParents
            // 
            this.tParents.FormattingEnabled = true;
            this.tParents.Location = new System.Drawing.Point(89, 317);
            this.tParents.Name = "tParents";
            this.tParents.Size = new System.Drawing.Size(195, 43);
            this.tParents.TabIndex = 25;
            // 
            // tPartsList
            // 
            this.tPartsList.FormattingEnabled = true;
            this.tPartsList.Location = new System.Drawing.Point(89, 367);
            this.tPartsList.Name = "tPartsList";
            this.tPartsList.Size = new System.Drawing.Size(195, 82);
            this.tPartsList.TabIndex = 24;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 456);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(278, 27);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update Node";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // tHideIfEmpty
            // 
            this.tHideIfEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tHideIfEmpty.FormattingEnabled = true;
            this.tHideIfEmpty.Items.AddRange(new object[] {
            "True",
            "False"});
            this.tHideIfEmpty.Location = new System.Drawing.Point(89, 289);
            this.tHideIfEmpty.Name = "tHideIfEmpty";
            this.tHideIfEmpty.Size = new System.Drawing.Size(195, 21);
            this.tHideIfEmpty.TabIndex = 19;
            // 
            // tAnyParent
            // 
            this.tAnyParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tAnyParent.FormattingEnabled = true;
            this.tAnyParent.Items.AddRange(new object[] {
            "True",
            "False"});
            this.tAnyParent.Location = new System.Drawing.Point(89, 261);
            this.tAnyParent.Name = "tAnyParent";
            this.tAnyParent.Size = new System.Drawing.Size(195, 21);
            this.tAnyParent.TabIndex = 18;
            // 
            // tDesc
            // 
            this.tDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tDesc.Location = new System.Drawing.Point(89, 189);
            this.tDesc.Multiline = true;
            this.tDesc.Name = "tDesc";
            this.tDesc.Size = new System.Drawing.Size(195, 65);
            this.tDesc.TabIndex = 17;
            // 
            // tTitle
            // 
            this.tTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tTitle.Location = new System.Drawing.Point(89, 162);
            this.tTitle.Name = "tTitle";
            this.tTitle.Size = new System.Drawing.Size(195, 20);
            this.tTitle.TabIndex = 16;
            // 
            // tCost
            // 
            this.tCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tCost.Location = new System.Drawing.Point(89, 135);
            this.tCost.Name = "tCost";
            this.tCost.Size = new System.Drawing.Size(195, 20);
            this.tCost.TabIndex = 15;
            // 
            // tIcon
            // 
            this.tIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tIcon.FormattingEnabled = true;
            this.tIcon.Location = new System.Drawing.Point(89, 107);
            this.tIcon.Name = "tIcon";
            this.tIcon.Size = new System.Drawing.Size(195, 21);
            this.tIcon.TabIndex = 14;
            // 
            // tPos
            // 
            this.tPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tPos.Location = new System.Drawing.Point(89, 80);
            this.tPos.Name = "tPos";
            this.tPos.Size = new System.Drawing.Size(195, 20);
            this.tPos.TabIndex = 13;
            // 
            // tTechID
            // 
            this.tTechID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tTechID.Location = new System.Drawing.Point(89, 53);
            this.tTechID.Name = "tTechID";
            this.tTechID.Size = new System.Drawing.Size(195, 20);
            this.tTechID.TabIndex = 12;
            // 
            // tNodeName
            // 
            this.tNodeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tNodeName.Location = new System.Drawing.Point(89, 26);
            this.tNodeName.Name = "tNodeName";
            this.tNodeName.Size = new System.Drawing.Size(195, 20);
            this.tNodeName.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Parts list";
            this.label11.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Parent/s";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hide if empty?";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Any Parent?";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Title";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cost";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Icon";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tech ID";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Node Name";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // lbPartsAvailable
            // 
            this.lbPartsAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPartsAvailable.FormattingEnabled = true;
            this.lbPartsAvailable.Location = new System.Drawing.Point(6, 6);
            this.lbPartsAvailable.Name = "lbPartsAvailable";
            this.lbPartsAvailable.Size = new System.Drawing.Size(243, 446);
            this.lbPartsAvailable.TabIndex = 30;
            // 
            // openFileMain
            // 
            this.openFileMain.FileName = "openFileMain";
            this.openFileMain.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileMain_FileOk);
            // 
            // lbConnParts
            // 
            this.lbConnParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConnParts.FormattingEnabled = true;
            this.lbConnParts.Location = new System.Drawing.Point(6, 6);
            this.lbConnParts.Name = "lbConnParts";
            this.lbConnParts.Size = new System.Drawing.Size(240, 446);
            this.lbConnParts.TabIndex = 31;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(500, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(257, 480);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbPartList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(249, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "All Parts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbPartList
            // 
            this.lbPartList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPartList.FormattingEnabled = true;
            this.lbPartList.Location = new System.Drawing.Point(3, 4);
            this.lbPartList.Name = "lbPartList";
            this.lbPartList.Size = new System.Drawing.Size(243, 446);
            this.lbPartList.Sorted = true;
            this.lbPartList.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbPartsAvailable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(249, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Available Parts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbConnParts);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(249, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connected Parts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(5, 519);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(748, 17);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 33;
            this.progressBar.Tag = "Hello";
            // 
            // mnuSynchronise
            // 
            this.mnuSynchronise.Name = "mnuSynchronise";
            this.mnuSynchronise.Size = new System.Drawing.Size(83, 20);
            this.mnuSynchronise.Text = "Synchronise";
            this.mnuSynchronise.Click += new System.EventHandler(this.mnuSynchronise_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 540);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNodeTree);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.MinimumSize = new System.Drawing.Size(765, 571);
            this.Name = "frmMain";
            this.Text = "KSP Tech Tree Utility";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStripMenuItem mnuRecentMRU;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewTree;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpenTree;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveTree;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem findKSPToolStripMenuItem;
        private System.Windows.Forms.ListBox lbNodeTree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbPartsAvailable;
        private System.Windows.Forms.ComboBox tHideIfEmpty;
        private System.Windows.Forms.ComboBox tAnyParent;
        private System.Windows.Forms.TextBox tDesc;
        private System.Windows.Forms.TextBox tTitle;
        private System.Windows.Forms.TextBox tCost;
        private System.Windows.Forms.ComboBox tIcon;
        private System.Windows.Forms.TextBox tPos;
        private System.Windows.Forms.TextBox tTechID;
        private System.Windows.Forms.TextBox tNodeName;
        private System.Windows.Forms.OpenFileDialog openFileMain;
        private System.Windows.Forms.SaveFileDialog saveFileMain;
        private System.Windows.Forms.ListBox lbConnParts;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem importGameDataMnu;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox tPartsList;
        private System.Windows.Forms.ListBox tParents;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbPartList;
        private System.Windows.Forms.ToolStripMenuItem mnuSynchronise;
    }
}

