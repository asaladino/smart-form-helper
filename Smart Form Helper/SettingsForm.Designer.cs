namespace Smart_Form_Helper
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.xsdCommandTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xsdEktronUrlTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonXdsFile = new System.Windows.Forms.Button();
            this.checkBoxDownload = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "XSD Command";
            // 
            // xsdCommandTextBox
            // 
            this.xsdCommandTextBox.Location = new System.Drawing.Point(15, 25);
            this.xsdCommandTextBox.Name = "xsdCommandTextBox";
            this.xsdCommandTextBox.Size = new System.Drawing.Size(249, 20);
            this.xsdCommandTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "XSD Ektron URL";
            // 
            // xsdEktronUrlTextBox
            // 
            this.xsdEktronUrlTextBox.Location = new System.Drawing.Point(15, 64);
            this.xsdEktronUrlTextBox.Name = "xsdEktronUrlTextBox";
            this.xsdEktronUrlTextBox.Size = new System.Drawing.Size(281, 20);
            this.xsdEktronUrlTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonXdsFile
            // 
            this.buttonXdsFile.Location = new System.Drawing.Point(270, 23);
            this.buttonXdsFile.Name = "buttonXdsFile";
            this.buttonXdsFile.Size = new System.Drawing.Size(26, 23);
            this.buttonXdsFile.TabIndex = 6;
            this.buttonXdsFile.Text = "...";
            this.buttonXdsFile.UseVisualStyleBackColor = true;
            this.buttonXdsFile.Click += new System.EventHandler(this.buttonXdsFile_Click);
            // 
            // checkBoxDownload
            // 
            this.checkBoxDownload.AutoSize = true;
            this.checkBoxDownload.Location = new System.Drawing.Point(15, 90);
            this.checkBoxDownload.Name = "checkBoxDownload";
            this.checkBoxDownload.Size = new System.Drawing.Size(159, 17);
            this.checkBoxDownload.TabIndex = 7;
            this.checkBoxDownload.Text = "Download XSD From Server";
            this.checkBoxDownload.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 158);
            this.Controls.Add(this.checkBoxDownload);
            this.Controls.Add(this.buttonXdsFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xsdEktronUrlTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xsdCommandTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(316, 190);
            this.MinimumSize = new System.Drawing.Size(316, 190);
            this.Name = "SettingsForm";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xsdCommandTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xsdEktronUrlTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonXdsFile;
        private System.Windows.Forms.CheckBox checkBoxDownload;
    }
}