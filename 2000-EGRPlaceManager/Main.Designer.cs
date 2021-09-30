namespace MRK {
    partial class Main {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.workingDirectoryTextbox = new System.Windows.Forms.TextBox();
            this.chooseWorkingAreaButton = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.placesLiveTabPage = new System.Windows.Forms.TabPage();
            this.placesLiveSearchComboBox = new System.Windows.Forms.ComboBox();
            this.placesLiveSearchTextbox = new System.Windows.Forms.TextBox();
            this.placesLiveListView = new System.Windows.Forms.ListView();
            this.cidHeader = new System.Windows.Forms.ColumnHeader();
            this.nameHeader = new System.Windows.Forms.ColumnHeader();
            this.typeHeader = new System.Windows.Forms.ColumnHeader();
            this.chainHeader = new System.Windows.Forms.ColumnHeader();
            this.placesLiveSearchButton = new System.Windows.Forms.Button();
            this.placesWTETabPage = new System.Windows.Forms.TabPage();
            this.placesWTESearchComboBox = new System.Windows.Forms.ComboBox();
            this.placesWTESearchTextbox = new System.Windows.Forms.TextBox();
            this.placesWTEListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.placesWTESearchButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bottomToolstrip = new System.Windows.Forms.ToolStrip();
            this.refreshToolstrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.liveSearchToolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consoleTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.consoleCallerPathToggle = new System.Windows.Forms.CheckBox();
            this.mainTabControl.SuspendLayout();
            this.placesLiveTabPage.SuspendLayout();
            this.placesWTETabPage.SuspendLayout();
            this.bottomToolstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working Directory";
            // 
            // workingDirectoryTextbox
            // 
            this.workingDirectoryTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workingDirectoryTextbox.Location = new System.Drawing.Point(117, 27);
            this.workingDirectoryTextbox.Name = "workingDirectoryTextbox";
            this.workingDirectoryTextbox.Size = new System.Drawing.Size(801, 23);
            this.workingDirectoryTextbox.TabIndex = 1;
            // 
            // chooseWorkingAreaButton
            // 
            this.chooseWorkingAreaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseWorkingAreaButton.Location = new System.Drawing.Point(924, 26);
            this.chooseWorkingAreaButton.Name = "chooseWorkingAreaButton";
            this.chooseWorkingAreaButton.Size = new System.Drawing.Size(75, 23);
            this.chooseWorkingAreaButton.TabIndex = 2;
            this.chooseWorkingAreaButton.Text = "...";
            this.chooseWorkingAreaButton.UseVisualStyleBackColor = true;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.placesLiveTabPage);
            this.mainTabControl.Controls.Add(this.placesWTETabPage);
            this.mainTabControl.Controls.Add(this.tabPage3);
            this.mainTabControl.Location = new System.Drawing.Point(12, 56);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(991, 523);
            this.mainTabControl.TabIndex = 3;
            // 
            // placesLiveTabPage
            // 
            this.placesLiveTabPage.Controls.Add(this.placesLiveSearchComboBox);
            this.placesLiveTabPage.Controls.Add(this.placesLiveSearchTextbox);
            this.placesLiveTabPage.Controls.Add(this.placesLiveListView);
            this.placesLiveTabPage.Controls.Add(this.placesLiveSearchButton);
            this.placesLiveTabPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placesLiveTabPage.Location = new System.Drawing.Point(4, 24);
            this.placesLiveTabPage.Name = "placesLiveTabPage";
            this.placesLiveTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.placesLiveTabPage.Size = new System.Drawing.Size(983, 495);
            this.placesLiveTabPage.TabIndex = 0;
            this.placesLiveTabPage.Text = "PLACES Live";
            this.placesLiveTabPage.UseVisualStyleBackColor = true;
            // 
            // placesLiveSearchComboBox
            // 
            this.placesLiveSearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.placesLiveSearchComboBox.FormattingEnabled = true;
            this.placesLiveSearchComboBox.Items.AddRange(new object[] {
            "NAME",
            "CID"});
            this.placesLiveSearchComboBox.Location = new System.Drawing.Point(6, 6);
            this.placesLiveSearchComboBox.Name = "placesLiveSearchComboBox";
            this.placesLiveSearchComboBox.Size = new System.Drawing.Size(93, 23);
            this.placesLiveSearchComboBox.TabIndex = 2;
            // 
            // placesLiveSearchTextbox
            // 
            this.placesLiveSearchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placesLiveSearchTextbox.Location = new System.Drawing.Point(101, 6);
            this.placesLiveSearchTextbox.Name = "placesLiveSearchTextbox";
            this.placesLiveSearchTextbox.Size = new System.Drawing.Size(801, 23);
            this.placesLiveSearchTextbox.TabIndex = 1;
            // 
            // placesLiveListView
            // 
            this.placesLiveListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.placesLiveListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placesLiveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cidHeader,
            this.nameHeader,
            this.typeHeader,
            this.chainHeader});
            this.placesLiveListView.GridLines = true;
            this.placesLiveListView.Location = new System.Drawing.Point(6, 34);
            this.placesLiveListView.Name = "placesLiveListView";
            this.placesLiveListView.Size = new System.Drawing.Size(971, 455);
            this.placesLiveListView.TabIndex = 0;
            this.placesLiveListView.UseCompatibleStateImageBehavior = false;
            this.placesLiveListView.View = System.Windows.Forms.View.Details;
            // 
            // cidHeader
            // 
            this.cidHeader.Text = "CID";
            this.cidHeader.Width = 150;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "NAME";
            this.nameHeader.Width = 250;
            // 
            // typeHeader
            // 
            this.typeHeader.Text = "TYPE";
            this.typeHeader.Width = 250;
            // 
            // chainHeader
            // 
            this.chainHeader.Text = "CHAIN";
            this.chainHeader.Width = 150;
            // 
            // placesLiveSearchButton
            // 
            this.placesLiveSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.placesLiveSearchButton.Location = new System.Drawing.Point(908, 6);
            this.placesLiveSearchButton.Name = "placesLiveSearchButton";
            this.placesLiveSearchButton.Size = new System.Drawing.Size(69, 23);
            this.placesLiveSearchButton.TabIndex = 2;
            this.placesLiveSearchButton.Text = ">";
            this.placesLiveSearchButton.UseVisualStyleBackColor = true;
            // 
            // placesWTETabPage
            // 
            this.placesWTETabPage.Controls.Add(this.placesWTESearchComboBox);
            this.placesWTETabPage.Controls.Add(this.placesWTESearchTextbox);
            this.placesWTETabPage.Controls.Add(this.placesWTEListView);
            this.placesWTETabPage.Controls.Add(this.placesWTESearchButton);
            this.placesWTETabPage.Location = new System.Drawing.Point(4, 24);
            this.placesWTETabPage.Name = "placesWTETabPage";
            this.placesWTETabPage.Padding = new System.Windows.Forms.Padding(3);
            this.placesWTETabPage.Size = new System.Drawing.Size(983, 495);
            this.placesWTETabPage.TabIndex = 1;
            this.placesWTETabPage.Text = "PLACES WTE";
            this.placesWTETabPage.UseVisualStyleBackColor = true;
            // 
            // placesWTESearchComboBox
            // 
            this.placesWTESearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.placesWTESearchComboBox.FormattingEnabled = true;
            this.placesWTESearchComboBox.Items.AddRange(new object[] {
            "NAME",
            "CID"});
            this.placesWTESearchComboBox.Location = new System.Drawing.Point(6, 6);
            this.placesWTESearchComboBox.Name = "placesWTESearchComboBox";
            this.placesWTESearchComboBox.Size = new System.Drawing.Size(93, 23);
            this.placesWTESearchComboBox.TabIndex = 5;
            // 
            // placesWTESearchTextbox
            // 
            this.placesWTESearchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placesWTESearchTextbox.Location = new System.Drawing.Point(101, 6);
            this.placesWTESearchTextbox.Name = "placesWTESearchTextbox";
            this.placesWTESearchTextbox.Size = new System.Drawing.Size(801, 23);
            this.placesWTESearchTextbox.TabIndex = 4;
            // 
            // placesWTEListView
            // 
            this.placesWTEListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.placesWTEListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placesWTEListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.placesWTEListView.GridLines = true;
            this.placesWTEListView.Location = new System.Drawing.Point(6, 34);
            this.placesWTEListView.Name = "placesWTEListView";
            this.placesWTEListView.Size = new System.Drawing.Size(971, 455);
            this.placesWTEListView.TabIndex = 3;
            this.placesWTEListView.UseCompatibleStateImageBehavior = false;
            this.placesWTEListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CID";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NAME";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TYPE";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CHAIN";
            this.columnHeader4.Width = 150;
            // 
            // placesWTESearchButton
            // 
            this.placesWTESearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.placesWTESearchButton.Location = new System.Drawing.Point(908, 6);
            this.placesWTESearchButton.Name = "placesWTESearchButton";
            this.placesWTESearchButton.Size = new System.Drawing.Size(69, 23);
            this.placesWTESearchButton.TabIndex = 6;
            this.placesWTESearchButton.Text = ">";
            this.placesWTESearchButton.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(983, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PLACES Templates";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bottomToolstrip
            // 
            this.bottomToolstrip.BackColor = System.Drawing.SystemColors.Control;
            this.bottomToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bottomToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolstrip,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2});
            this.bottomToolstrip.Location = new System.Drawing.Point(0, 0);
            this.bottomToolstrip.Name = "bottomToolstrip";
            this.bottomToolstrip.Size = new System.Drawing.Size(1015, 25);
            this.bottomToolstrip.TabIndex = 4;
            this.bottomToolstrip.Text = "toolStrip1";
            // 
            // refreshToolstrip
            // 
            this.refreshToolstrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolstrip.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolstrip.Image")));
            this.refreshToolstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolstrip.Name = "refreshToolstrip";
            this.refreshToolstrip.Size = new System.Drawing.Size(50, 22);
            this.refreshToolstrip.Text = "Refresh";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveSearchToolstrip});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(41, 22);
            this.toolStripDropDownButton1.Text = "Live";
            // 
            // liveSearchToolstrip
            // 
            this.liveSearchToolstrip.CheckOnClick = true;
            this.liveSearchToolstrip.Name = "liveSearchToolstrip";
            this.liveSearchToolstrip.Size = new System.Drawing.Size(109, 22);
            this.liveSearchToolstrip.Text = "Search";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // consoleTextbox
            // 
            this.consoleTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleTextbox.Location = new System.Drawing.Point(12, 600);
            this.consoleTextbox.Multiline = true;
            this.consoleTextbox.Name = "consoleTextbox";
            this.consoleTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTextbox.Size = new System.Drawing.Size(991, 105);
            this.consoleTextbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Console";
            // 
            // consoleCallerPathToggle
            // 
            this.consoleCallerPathToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleCallerPathToggle.AutoSize = true;
            this.consoleCallerPathToggle.Checked = true;
            this.consoleCallerPathToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consoleCallerPathToggle.Location = new System.Drawing.Point(875, 578);
            this.consoleCallerPathToggle.Name = "consoleCallerPathToggle";
            this.consoleCallerPathToggle.Size = new System.Drawing.Size(124, 19);
            this.consoleCallerPathToggle.TabIndex = 6;
            this.consoleCallerPathToggle.Text = "Show caller names";
            this.consoleCallerPathToggle.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 717);
            this.Controls.Add(this.consoleCallerPathToggle);
            this.Controls.Add(this.consoleTextbox);
            this.Controls.Add(this.bottomToolstrip);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.chooseWorkingAreaButton);
            this.Controls.Add(this.workingDirectoryTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "2000-EGR Place Manager";
            this.mainTabControl.ResumeLayout(false);
            this.placesLiveTabPage.ResumeLayout(false);
            this.placesLiveTabPage.PerformLayout();
            this.placesWTETabPage.ResumeLayout(false);
            this.placesWTETabPage.PerformLayout();
            this.bottomToolstrip.ResumeLayout(false);
            this.bottomToolstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox workingDirectoryTextbox;
        private System.Windows.Forms.Button chooseWorkingAreaButton;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage placesLiveTabPage;
        private System.Windows.Forms.TabPage placesWTETabPage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox placesLiveSearchTextbox;
        private System.Windows.Forms.ListView placesLiveListView;
        private System.Windows.Forms.TextBox placesWTESearchTextbox;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader cidHeader;
        private System.Windows.Forms.ToolStrip bottomToolstrip;
        private System.Windows.Forms.ToolStripButton refreshToolstrip;
        private System.Windows.Forms.TextBox consoleTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox consoleCallerPathToggle;
        private System.Windows.Forms.ComboBox placesLiveSearchComboBox;
        private System.Windows.Forms.Button placesLiveSearchButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem liveSearchToolstrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ColumnHeader typeHeader;
        private System.Windows.Forms.ColumnHeader chainHeader;
        private System.Windows.Forms.ComboBox placesWTESearchComboBox;
        private System.Windows.Forms.ListView placesWTEListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button placesWTESearchButton;
    }
}

