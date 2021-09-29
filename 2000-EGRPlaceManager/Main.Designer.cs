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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.placesLiveTabPage = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.placesLiveSearchTextbox = new System.Windows.Forms.TextBox();
            this.placesLiveListView = new System.Windows.Forms.ListView();
            this.nameHeader = new System.Windows.Forms.ColumnHeader();
            this.cidHeader = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bottomToolstrip = new System.Windows.Forms.ToolStrip();
            this.refreshToolstrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.consoleTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.consoleCallerPathToggle = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.placesLiveTabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.workingDirectoryTextbox.Size = new System.Drawing.Size(742, 23);
            this.workingDirectoryTextbox.TabIndex = 1;
            // 
            // chooseWorkingAreaButton
            // 
            this.chooseWorkingAreaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseWorkingAreaButton.Location = new System.Drawing.Point(865, 26);
            this.chooseWorkingAreaButton.Name = "chooseWorkingAreaButton";
            this.chooseWorkingAreaButton.Size = new System.Drawing.Size(75, 23);
            this.chooseWorkingAreaButton.TabIndex = 2;
            this.chooseWorkingAreaButton.Text = "...";
            this.chooseWorkingAreaButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.placesLiveTabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 523);
            this.tabControl1.TabIndex = 3;
            // 
            // placesLiveTabPage
            // 
            this.placesLiveTabPage.Controls.Add(this.comboBox1);
            this.placesLiveTabPage.Controls.Add(this.placesLiveSearchTextbox);
            this.placesLiveTabPage.Controls.Add(this.placesLiveListView);
            this.placesLiveTabPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placesLiveTabPage.Location = new System.Drawing.Point(4, 24);
            this.placesLiveTabPage.Name = "placesLiveTabPage";
            this.placesLiveTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.placesLiveTabPage.Size = new System.Drawing.Size(924, 495);
            this.placesLiveTabPage.TabIndex = 0;
            this.placesLiveTabPage.Text = "PLACES Live";
            this.placesLiveTabPage.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NAME",
            "CID"});
            this.comboBox1.Location = new System.Drawing.Point(6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // placesLiveSearchTextbox
            // 
            this.placesLiveSearchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placesLiveSearchTextbox.Location = new System.Drawing.Point(101, 6);
            this.placesLiveSearchTextbox.Name = "placesLiveSearchTextbox";
            this.placesLiveSearchTextbox.Size = new System.Drawing.Size(817, 23);
            this.placesLiveSearchTextbox.TabIndex = 1;
            // 
            // placesLiveListView
            // 
            this.placesLiveListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placesLiveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.cidHeader});
            this.placesLiveListView.GridLines = true;
            this.placesLiveListView.LabelEdit = true;
            this.placesLiveListView.Location = new System.Drawing.Point(6, 34);
            this.placesLiveListView.Name = "placesLiveListView";
            this.placesLiveListView.Size = new System.Drawing.Size(912, 455);
            this.placesLiveListView.TabIndex = 0;
            this.placesLiveListView.UseCompatibleStateImageBehavior = false;
            this.placesLiveListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "NAME";
            this.nameHeader.Width = 250;
            // 
            // cidHeader
            // 
            this.cidHeader.Text = "CID";
            this.cidHeader.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PLACES WTE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 23);
            this.textBox1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(924, 495);
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
            this.toolStripSeparator1});
            this.bottomToolstrip.Location = new System.Drawing.Point(0, 0);
            this.bottomToolstrip.Name = "bottomToolstrip";
            this.bottomToolstrip.Size = new System.Drawing.Size(956, 25);
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
            // consoleTextbox
            // 
            this.consoleTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleTextbox.Location = new System.Drawing.Point(12, 600);
            this.consoleTextbox.Multiline = true;
            this.consoleTextbox.Name = "consoleTextbox";
            this.consoleTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTextbox.Size = new System.Drawing.Size(932, 105);
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
            this.consoleCallerPathToggle.Location = new System.Drawing.Point(816, 578);
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
            this.ClientSize = new System.Drawing.Size(956, 717);
            this.Controls.Add(this.consoleCallerPathToggle);
            this.Controls.Add(this.consoleTextbox);
            this.Controls.Add(this.bottomToolstrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.chooseWorkingAreaButton);
            this.Controls.Add(this.workingDirectoryTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "2000-EGR Place Manager";
            this.tabControl1.ResumeLayout(false);
            this.placesLiveTabPage.ResumeLayout(false);
            this.placesLiveTabPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.bottomToolstrip.ResumeLayout(false);
            this.bottomToolstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox workingDirectoryTextbox;
        private System.Windows.Forms.Button chooseWorkingAreaButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage placesLiveTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox placesLiveSearchTextbox;
        private System.Windows.Forms.ListView placesLiveListView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader cidHeader;
        private System.Windows.Forms.ToolStrip bottomToolstrip;
        private System.Windows.Forms.ToolStripButton refreshToolstrip;
        private System.Windows.Forms.TextBox consoleTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox consoleCallerPathToggle;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

