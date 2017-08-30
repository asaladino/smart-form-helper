namespace Smart_Form_Helper
{
    partial class MainForm
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
            this.mapComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteMappingButton = new System.Windows.Forms.Button();
            this.addMappingButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabelOpenXsdFile = new System.Windows.Forms.LinkLabel();
            this.buttonCsFile = new System.Windows.Forms.Button();
            this.buttonXdsFile = new System.Windows.Forms.Button();
            this.outputDirTextBox = new System.Windows.Forms.TextBox();
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xsdFileTextBox = new System.Windows.Forms.TextBox();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.smartFormIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.additionNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteAdditionButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addAdditionButton = new System.Windows.Forms.Button();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lineNumberTextBox = new System.Windows.Forms.TextBox();
            this.additionsComboBox = new System.Windows.Forms.ComboBox();
            this.linkLabelOutputDirectory = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapComboBox
            // 
            this.mapComboBox.FormattingEnabled = true;
            this.mapComboBox.Location = new System.Drawing.Point(9, 19);
            this.mapComboBox.Name = "mapComboBox";
            this.mapComboBox.Size = new System.Drawing.Size(245, 21);
            this.mapComboBox.TabIndex = 0;
            this.mapComboBox.SelectedValueChanged += new System.EventHandler(this.mapComboBox_SelectedValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.buildToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.configrationToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // configrationToolStripMenuItem
            // 
            this.configrationToolStripMenuItem.Name = "configrationToolStripMenuItem";
            this.configrationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.configrationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.configrationToolStripMenuItem.Text = "Configration...";
            this.configrationToolStripMenuItem.Click += new System.EventHandler(this.configrationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentToolStripMenuItem,
            this.allToolStripMenuItem});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.currentToolStripMenuItem.Text = "Current";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.allToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 449);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteMappingButton);
            this.groupBox2.Controls.Add(this.addMappingButton);
            this.groupBox2.Controls.Add(this.mapComboBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mappings";
            // 
            // deleteMappingButton
            // 
            this.deleteMappingButton.Location = new System.Drawing.Point(293, 17);
            this.deleteMappingButton.Name = "deleteMappingButton";
            this.deleteMappingButton.Size = new System.Drawing.Size(26, 23);
            this.deleteMappingButton.TabIndex = 2;
            this.deleteMappingButton.Text = "-";
            this.deleteMappingButton.UseVisualStyleBackColor = true;
            this.deleteMappingButton.Click += new System.EventHandler(this.deleteMappingButton_Click);
            // 
            // addMappingButton
            // 
            this.addMappingButton.Location = new System.Drawing.Point(260, 17);
            this.addMappingButton.Name = "addMappingButton";
            this.addMappingButton.Size = new System.Drawing.Size(27, 23);
            this.addMappingButton.TabIndex = 1;
            this.addMappingButton.Text = "+";
            this.addMappingButton.UseVisualStyleBackColor = true;
            this.addMappingButton.Click += new System.EventHandler(this.addMappingButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabelOutputDirectory);
            this.groupBox1.Controls.Add(this.linkLabelOpenXsdFile);
            this.groupBox1.Controls.Add(this.buttonCsFile);
            this.groupBox1.Controls.Add(this.buttonXdsFile);
            this.groupBox1.Controls.Add(this.outputDirTextBox);
            this.groupBox1.Controls.Add(this.classNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.xsdFileTextBox);
            this.groupBox1.Controls.Add(this.languageTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.smartFormIdTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smart Form";
            // 
            // linkLabelOpenXsdFile
            // 
            this.linkLabelOpenXsdFile.AutoSize = true;
            this.linkLabelOpenXsdFile.Location = new System.Drawing.Point(6, 55);
            this.linkLabelOpenXsdFile.Name = "linkLabelOpenXsdFile";
            this.linkLabelOpenXsdFile.Size = new System.Drawing.Size(86, 13);
            this.linkLabelOpenXsdFile.TabIndex = 10;
            this.linkLabelOpenXsdFile.TabStop = true;
            this.linkLabelOpenXsdFile.Text = "XDS File Loction";
            this.linkLabelOpenXsdFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOpenXsdFile_LinkClicked);
            // 
            // buttonCsFile
            // 
            this.buttonCsFile.Location = new System.Drawing.Point(293, 147);
            this.buttonCsFile.Name = "buttonCsFile";
            this.buttonCsFile.Size = new System.Drawing.Size(26, 23);
            this.buttonCsFile.TabIndex = 9;
            this.buttonCsFile.Text = "...";
            this.buttonCsFile.UseVisualStyleBackColor = true;
            this.buttonCsFile.Click += new System.EventHandler(this.buttonCsFile_Click);
            // 
            // buttonXdsFile
            // 
            this.buttonXdsFile.Location = new System.Drawing.Point(293, 68);
            this.buttonXdsFile.Name = "buttonXdsFile";
            this.buttonXdsFile.Size = new System.Drawing.Size(26, 23);
            this.buttonXdsFile.TabIndex = 3;
            this.buttonXdsFile.Text = "...";
            this.buttonXdsFile.UseVisualStyleBackColor = true;
            this.buttonXdsFile.Click += new System.EventHandler(this.buttonXdsFile_Click);
            // 
            // outputDirTextBox
            // 
            this.outputDirTextBox.Location = new System.Drawing.Point(9, 149);
            this.outputDirTextBox.Name = "outputDirTextBox";
            this.outputDirTextBox.Size = new System.Drawing.Size(278, 20);
            this.outputDirTextBox.TabIndex = 8;
            this.outputDirTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.smartFormIdTextBox_KeyUp);
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.Location = new System.Drawing.Point(9, 110);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.classNameTextBox.TabIndex = 6;
            this.classNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.smartFormIdTextBox_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class Name";
            // 
            // xsdFileTextBox
            // 
            this.xsdFileTextBox.Location = new System.Drawing.Point(9, 71);
            this.xsdFileTextBox.Name = "xsdFileTextBox";
            this.xsdFileTextBox.Size = new System.Drawing.Size(278, 20);
            this.xsdFileTextBox.TabIndex = 5;
            this.xsdFileTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.smartFormIdTextBox_KeyUp);
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(162, 32);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(148, 20);
            this.languageTextBox.TabIndex = 3;
            this.languageTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.smartFormIdTextBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // smartFormIdTextBox
            // 
            this.smartFormIdTextBox.Location = new System.Drawing.Point(9, 32);
            this.smartFormIdTextBox.Name = "smartFormIdTextBox";
            this.smartFormIdTextBox.Size = new System.Drawing.Size(147, 20);
            this.smartFormIdTextBox.TabIndex = 0;
            this.smartFormIdTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.smartFormIdTextBox_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.additionNameTextBox);
            this.groupBox3.Controls.Add(this.deleteAdditionButton);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.addAdditionButton);
            this.groupBox3.Controls.Add(this.codeTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lineNumberTextBox);
            this.groupBox3.Controls.Add(this.additionsComboBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 204);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additions";
            // 
            // additionNameTextBox
            // 
            this.additionNameTextBox.Location = new System.Drawing.Point(9, 60);
            this.additionNameTextBox.Name = "additionNameTextBox";
            this.additionNameTextBox.Size = new System.Drawing.Size(117, 20);
            this.additionNameTextBox.TabIndex = 10;
            this.additionNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.additionNameTextBox_KeyUp);
            // 
            // deleteAdditionButton
            // 
            this.deleteAdditionButton.Location = new System.Drawing.Point(293, 17);
            this.deleteAdditionButton.Name = "deleteAdditionButton";
            this.deleteAdditionButton.Size = new System.Drawing.Size(26, 23);
            this.deleteAdditionButton.TabIndex = 4;
            this.deleteAdditionButton.Text = "-";
            this.deleteAdditionButton.UseVisualStyleBackColor = true;
            this.deleteAdditionButton.Click += new System.EventHandler(this.deleteAdditionButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Text";
            // 
            // addAdditionButton
            // 
            this.addAdditionButton.Location = new System.Drawing.Point(260, 17);
            this.addAdditionButton.Name = "addAdditionButton";
            this.addAdditionButton.Size = new System.Drawing.Size(27, 23);
            this.addAdditionButton.TabIndex = 3;
            this.addAdditionButton.Text = "+";
            this.addAdditionButton.UseVisualStyleBackColor = true;
            this.addAdditionButton.Click += new System.EventHandler(this.addAdditionButton_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(9, 100);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(301, 92);
            this.codeTextBox.TabIndex = 3;
            this.codeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.additionNameTextBox_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Place Text After";
            // 
            // lineNumberTextBox
            // 
            this.lineNumberTextBox.Location = new System.Drawing.Point(132, 60);
            this.lineNumberTextBox.Name = "lineNumberTextBox";
            this.lineNumberTextBox.Size = new System.Drawing.Size(178, 20);
            this.lineNumberTextBox.TabIndex = 1;
            this.lineNumberTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.additionNameTextBox_KeyUp);
            // 
            // additionsComboBox
            // 
            this.additionsComboBox.FormattingEnabled = true;
            this.additionsComboBox.Location = new System.Drawing.Point(9, 19);
            this.additionsComboBox.Name = "additionsComboBox";
            this.additionsComboBox.Size = new System.Drawing.Size(245, 21);
            this.additionsComboBox.TabIndex = 0;
            this.additionsComboBox.SelectedValueChanged += new System.EventHandler(this.additionsComboBox_SelectedValueChanged);
            // 
            // linkLabelOutputDirectory
            // 
            this.linkLabelOutputDirectory.AutoSize = true;
            this.linkLabelOutputDirectory.Location = new System.Drawing.Point(6, 133);
            this.linkLabelOutputDirectory.Name = "linkLabelOutputDirectory";
            this.linkLabelOutputDirectory.Size = new System.Drawing.Size(120, 13);
            this.linkLabelOutputDirectory.TabIndex = 11;
            this.linkLabelOutputDirectory.TabStop = true;
            this.linkLabelOutputDirectory.Text = "CS File Output Directory";
            this.linkLabelOutputDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOutputDirectory_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 488);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(360, 520);
            this.MinimumSize = new System.Drawing.Size(360, 520);
            this.Name = "MainForm";
            this.Text = "Smart Form Helper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mapComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox xsdFileTextBox;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox smartFormIdTextBox;
        private System.Windows.Forms.TextBox outputDirTextBox;
        private System.Windows.Forms.TextBox classNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox additionsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lineNumberTextBox;
        private System.Windows.Forms.Button deleteMappingButton;
        private System.Windows.Forms.Button addMappingButton;
        private System.Windows.Forms.Button deleteAdditionButton;
        private System.Windows.Forms.Button addAdditionButton;
        private System.Windows.Forms.TextBox additionNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button buttonCsFile;
        private System.Windows.Forms.Button buttonXdsFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabelOpenXsdFile;
        private System.Windows.Forms.LinkLabel linkLabelOutputDirectory;
    }
}