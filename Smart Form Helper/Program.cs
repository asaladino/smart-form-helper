using Smart_Form_Helper.Core.Repositories;
using Smart_Form_Helper.Core.Services;
using Smart_Form_Helper.Data.Models;
using Smart_Form_Helper.Data.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Form_Helper
{
    /// <summary>
    /// Main Smart Form Helper class
    /// </summary>
    class Program
    {
        /// <summary>
        /// XSD service to manage CS generation.
        /// </summary>
        public XsdService XsdService;
        /// <summary>
        /// Configuration file location.
        /// </summary>
        public string JsonFile;

        /// <summary>
        /// Program startup.
        /// </summary>
        /// <param name="args">commandline args.</param>
        [STAThread]
        static void Main(string[] args)
        {
            Program program = new Program();
            if (args.Length >= 2 && args[1] == "auto")
            {
                program.InitializeReposAndService(args[0]);
                program.RunDefault();
            }
            else
            {
                MainForm mainForm = new MainForm();
                if (args.Length >= 1) { 
                    mainForm.InitializeReposAndService(args[0]);
                }
                Application.Run(mainForm);
            }
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Program() { }

        // "C:\Users\Administrator\Documents\Visual Studio 2013\Projects\Smart Form Helper\configuration.json" menu

        /// <summary>
        /// Build the program with a json file.
        /// </summary>
        /// <param name="jsonFile">Configuration file location</param>
        public Program(string jsonFile)
        {
            InitializeReposAndService(jsonFile);
        }

        /// <summary>
        /// Default service to run.
        /// </summary>
        public void RunDefault()
        {
            XsdService.SyncCsFilesWithSmartForms();
        }

        /// <summary>
        /// Display menu.
        /// </summary>
        /// <returns>The selected option.</returns>
        public int DisplayMenu()
        {
            Console.WriteLine("+++++++ Smart Form Helper +++++++");
            Console.WriteLine();
            Console.WriteLine("1) Set Config File Location");
            Console.WriteLine("2) Sync .cs Files with SmartForms");
            Console.WriteLine();
            Console.WriteLine("0) Exit");
            Console.WriteLine("---------------------------------");
            Console.Write("Select Option> ");
            string result = Console.ReadLine();
            Console.Clear();
            return MenuResult(result);
        }

        /// <summary>
        /// Get the menu result or exit.
        /// </summary>
        /// <param name="result">to parse.</param>
        /// <returns>The integer result or 0 to exit.</returns>
        public int MenuResult(string result)
        {
            try
            {
                return Convert.ToInt32(result);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// Handle menu response loop.
        /// </summary>
        public void MenuLoop()
        {
            int userInput = -1;
            do
            {
                try
                {
                    userInput = DisplayMenu();
                    switch (userInput)
                    {
                        case 1:
                            SetConfigurationFileLocation();
                            break;
                        case 2:
                            XsdService.SyncCsFilesWithSmartForms();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Yikes error...");
                    Console.WriteLine(e);
                    Console.WriteLine("---------------------------------");
                    throw;
                }

            } while (userInput != 0);
        }

        /// <summary>
        /// Initialize all the repos and the service.
        /// </summary>
        /// <param name="jsonFile">the configuration file location</param>
        public void InitializeReposAndService(string jsonFile)
        {
            this.JsonFile = jsonFile;
            IConfigurationsRepository configurationsRespository = new JsonConfigurationsRepository(JsonFile);
            Configuration configuration = configurationsRespository.Find();
            IXsdCsRepository xsdCsRepository = new ProcessXsdCsRepository(configuration);
            ISmartFormsRespository smartFormsRepository = new HttpSmartFormsRepository(configuration);
            XsdService = new XsdService(configuration, configurationsRespository, xsdCsRepository, smartFormsRepository);
        }

        /// <summary>
        /// Set a new configuration file location.
        /// </summary>
        private void SetConfigurationFileLocation()
        {
            Console.WriteLine("Set JSON file location (" + JsonFile + ") ");
            string result = Console.ReadLine();
            if (result != String.Empty)
            {
                InitializeReposAndService(result);
            }
        }
    }
}
