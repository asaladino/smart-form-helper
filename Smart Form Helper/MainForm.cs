using Smart_Form_Helper.Core.Repositories;
using Smart_Form_Helper.Core.Services;
using Smart_Form_Helper.Data.Models;
using Smart_Form_Helper.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Smart_Form_Helper
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// XSD service to manage CS generation.
        /// </summary>
        private XsdService XsdService;

        private MappingGenerate mappingGenerate;

        private Addition addition;

        private string OrginalTitle = "";

        /// <summary>
        /// Configuration file location.
        /// </summary>
        public string JsonFile;

        public MainForm()
        {
            InitializeComponent();
            OrginalTitle = Text;
            UiOpenClosed();
        }

        /// <summary>
        /// Open a configuration file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "json files (*.json)|*.json";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                InitializeReposAndService(openFileDialog.FileName);
            }
        }

        private void UiOpenClosed()
        {
            if (XsdService == null)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                configrationToolStripMenuItem.Enabled = false;
                buildToolStripMenuItem.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                configrationToolStripMenuItem.Enabled = true;
                buildToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// Save the currently loaded configuration file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XsdService.SaveConfiguration();
            Text = OrginalTitle;
        }

        /// <summary>
        /// Exit smart form helper.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Initialize all the repos and the service.
        /// </summary>
        /// <param name="jsonFile">the configuration file location</param>
        public void InitializeReposAndService(string jsonFile)
        {
            this.JsonFile = jsonFile;
            if (File.Exists(this.JsonFile))
            {
                IConfigurationsRepository configurationsRespository = new JsonConfigurationsRepository(JsonFile);
                Configuration configuration = configurationsRespository.Find();
                IXsdCsRepository xsdCsRepository = new ProcessXsdCsRepository(configuration);
                ISmartFormsRespository smartFormsRepository = new HttpSmartFormsRepository(configuration);
                XsdService = new XsdService(configuration, configurationsRespository, xsdCsRepository, smartFormsRepository);
                mapComboBox.DataSource = null;
                mapComboBox.DataSource = XsdService.Configuration.MappingGenerates;
                FileInfo fileInfo = new FileInfo(JsonFile);
                OrginalTitle += " | " + fileInfo.Name;
                Text = OrginalTitle;
            }
            UiOpenClosed();
        }

        private void mapComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            mappingGenerate = (MappingGenerate)mapComboBox.SelectedItem;
            additionsComboBox.DataSource = null;
            if (mappingGenerate != null)
            {
                smartFormIdTextBox.Text = mappingGenerate.SmartFormId + "";
                languageTextBox.Text = mappingGenerate.Language; 
                xsdFileTextBox.Text = mappingGenerate.XsdFile;
                classNameTextBox.Text = mappingGenerate.ClassName;
                outputDirTextBox.Text = mappingGenerate.OutputDir;
                additionsComboBox.DataSource = mappingGenerate.Additions;
            }
            else
            {
                smartFormIdTextBox.Text = "";
                languageTextBox.Text = "";
                xsdFileTextBox.Text = "";
                classNameTextBox.Text = "";
                outputDirTextBox.Text = "";
            }
        }

        private void addMappingButton_Click(object sender, EventArgs e)
        {
            MappingGenerate mapping = new MappingGenerate();
            mapping.ClassName = "NewClassName";
            mapping.SmartFormId = -1;
            XsdService.Configuration.MappingGenerates.Add(mapping);
            mapComboBox.DataSource = null;
            mapComboBox.DataSource = XsdService.Configuration.MappingGenerates;
            Text = OrginalTitle + " *[Save Needed]";
        }

        private void deleteMappingButton_Click(object sender, EventArgs e)
        {
            XsdService.Configuration.MappingGenerates.Remove(mappingGenerate);
            mapComboBox.DataSource = null;
            mapComboBox.DataSource = XsdService.Configuration.MappingGenerates;
            Text = OrginalTitle + " *[Save Needed]";
        }

        private void smartFormIdTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                mappingGenerate.SmartFormId = Int32.Parse(smartFormIdTextBox.Text);
            }
            catch (Exception)
            {
                mappingGenerate.SmartFormId = 0;
            }
            mappingGenerate.Language = languageTextBox.Text;
            mappingGenerate.XsdFile = xsdFileTextBox.Text;
            mappingGenerate.ClassName = classNameTextBox.Text;
            mappingGenerate.OutputDir = outputDirTextBox.Text;
            Text = OrginalTitle + " *[Save Needed]";
        }

        private void additionsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            addition = (Addition)additionsComboBox.SelectedItem;
            if (addition != null)
            {
                additionNameTextBox.Text = addition.Name;
                lineNumberTextBox.Text = addition.AfterSearchTerm;
                codeTextBox.Text = addition.Code;
            }
            else
            {
                additionNameTextBox.Text = "";
                lineNumberTextBox.Text = "";
                codeTextBox.Text = "";
            }
        }

        private void additionNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            addition.AfterSearchTerm = lineNumberTextBox.Text;
            addition.Name = additionNameTextBox.Text;
            addition.Code = codeTextBox.Text;
            Text = OrginalTitle + " *[Save Needed]";
        }

        private void addAdditionButton_Click(object sender, EventArgs e)
        {
            Addition add = new Addition();
            add.Name = "new addition";
            add.AfterSearchTerm = "";
            add.Code = "// Something to add";
            mappingGenerate.Additions.Add(add);
            additionsComboBox.DataSource = null;
            additionsComboBox.DataSource = mappingGenerate.Additions;
            Text = OrginalTitle + " *[Save Needed]";
        }

        private void deleteAdditionButton_Click(object sender, EventArgs e)
        {
            mappingGenerate.Additions.Remove(addition);
            additionsComboBox.DataSource = null;
            additionsComboBox.DataSource = mappingGenerate.Additions;
            Text = OrginalTitle + " *[Save Needed]";
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XsdService.SyncCsFilesWithSmartFormsAsync();
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XsdService.SyncCsFileWithSmartFormAsync(mappingGenerate);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void configrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm frmAbout = new SettingsForm(ref XsdService);
            frmAbout.ShowDialog();
        }

        private void buttonXdsFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = mappingGenerate.XsdFile;
            saveFileDialog.Filter = "XSD files (*.xsd)|*.xsd";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = false;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                xsdFileTextBox.Text = saveFileDialog.FileName;
                mappingGenerate.XsdFile = xsdFileTextBox.Text;
                Text = OrginalTitle + " *[Save Needed]";
            }
        }

        private void buttonCsFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.SelectedPath = mappingGenerate.OutputDir;
            DialogResult result = openFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                outputDirTextBox.Text = openFolderDialog.SelectedPath;
                mappingGenerate.OutputDir = outputDirTextBox.Text;
                Text = OrginalTitle + " *[Save Needed]";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "json files (*.json)|*.json";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = false;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string newJsonFile = saveFileDialog.FileName;
                IConfigurationsRepository configurationsRespository = new JsonConfigurationsRepository(newJsonFile);
                XsdService = new XsdService(configurationsRespository);
                XsdService.GenerateEmptyJsonFile();
                InitializeReposAndService(newJsonFile);
            }
        }

        private void linkLabelOpenXsdFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(xsdFileTextBox.Text);
        }

        private void linkLabelOutputDirectory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(outputDirTextBox.Text);
        }
    }
}
