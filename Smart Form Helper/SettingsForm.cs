using Smart_Form_Helper.Core.Services;
using Smart_Form_Helper.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Form_Helper
{
    public partial class SettingsForm : Form
    {
        private XsdService XsdService;

        public SettingsForm(ref XsdService XsdService)
        {
            this.XsdService = XsdService;
            InitializeComponent();
            xsdCommandTextBox.Text = XsdService.Configuration.XsdCommand;
            xsdEktronUrlTextBox.Text = XsdService.Configuration.XsdWebServiceUrl;
            checkBoxDownload.Checked = XsdService.Configuration.XsdDownloadFromServer;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XsdService.Configuration.XsdCommand = xsdCommandTextBox.Text;
            XsdService.Configuration.XsdWebServiceUrl = xsdEktronUrlTextBox.Text;
            XsdService.Configuration.XsdDownloadFromServer = checkBoxDownload.Checked;
            Close();
        }

        private void buttonXdsFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.InitialDirectory = XsdService.Configuration.XsdCommand;
            saveFileDialog.Filter = "Executable files (*.exe)|*.exe";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = false;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                xsdCommandTextBox.Text = saveFileDialog.FileName;
                XsdService.Configuration.XsdCommand = xsdCommandTextBox.Text;
            }
        }
    }
}
