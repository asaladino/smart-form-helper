using Smart_Form_Helper.Data.Models;
using Smart_Form_Helper.Data.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smart_Form_Helper.Core.Services
{
    public class XsdService
    {
        public Configuration Configuration;
        private IConfigurationsRepository ConfigurationsRespository;
        private IXsdCsRepository XsdCsRepository;
        private ISmartFormsRespository SmartFormsRepository;

        private Thread SyncCsFilesWithSmartFormsThread;
        private Thread SyncCsFileWithSmartFormThread;

        public XsdService(
            Configuration configuration,
            IConfigurationsRepository configurationsRespository,
            IXsdCsRepository xsdCsRepository,
            ISmartFormsRespository smartFormsRepository)
        {
            this.Configuration = configuration;
            this.ConfigurationsRespository = configurationsRespository;
            this.XsdCsRepository = xsdCsRepository;
            this.SmartFormsRepository = smartFormsRepository;
        }

        /// <summary>
        /// Build the XSD Service with just a configuration repository.
        /// </summary>
        /// <param name="configurationsRespository">to save and load a configuration.</param>
        public XsdService(IConfigurationsRepository configurationsRespository) {
            this.ConfigurationsRespository = configurationsRespository;
        }

        /// <summary>
        /// Generate empty sample json file.
        /// </summary>
        public void GenerateEmptyJsonFile()
        {
            Configuration configuration = new Configuration();
            MappingGenerate mappingGenerate = new MappingGenerate();
            mappingGenerate.Additions.Add(new Addition());
            configuration.MappingGenerates.Add(mappingGenerate);
            ConfigurationsRespository.Save(configuration);
        }

        /// <summary>
        /// Save the current configuration to file.
        /// </summary>
        public void SaveConfiguration()
        {
            ConfigurationsRespository.Save(Configuration);
        }

        /// <summary>
        /// Check to see if the configuration file exists.
        /// </summary>
        /// <param name="JsonFile"></param>
        /// <returns></returns>
        public bool DoesJsonFileExist(string JsonFile)
        {
            return File.Exists(JsonFile);
        }

        /// <summary>
        /// Async version of SyncCsFilesWithSmartForms
        /// </summary>
        public void SyncCsFilesWithSmartFormsAsync()
        {
            if (SyncCsFilesWithSmartFormsThread == null || !SyncCsFilesWithSmartFormsThread.IsAlive)
            {
                SyncCsFilesWithSmartFormsThread = new Thread(() => SyncCsFilesWithSmartForms());
                SyncCsFilesWithSmartFormsThread.Start();
            }
        }

        /// <summary>
        /// Sync all the CS files with the XSD changes.
        /// </summary>
        public void SyncCsFilesWithSmartForms()
        {
            foreach (MappingGenerate mappingGenerate in Configuration.MappingGenerates)
            {
                SyncCsFileWithSmartForm(mappingGenerate);
            }
            Console.WriteLine("============== Done With All ================");
        }

        /// <summary>
        /// Async version of SyncCsFileWithSmartForm. Syncs the CS file with any Smart Form changes.
        /// </summary>
        /// <param name="mappingGenerate">Mapping configuraitons for the CS file.</param>
        public void SyncCsFileWithSmartFormAsync(MappingGenerate mappingGenerate)
        {
            if (SyncCsFileWithSmartFormThread == null || !SyncCsFileWithSmartFormThread.IsAlive)
            {
                SyncCsFileWithSmartFormThread = new Thread(() => SyncCsFileWithSmartForm(mappingGenerate));
                SyncCsFileWithSmartFormThread.Start();
            }
        }

        /// <summary>
        /// Syncs the CS file with any Smart Form changes.
        /// </summary>
        /// <param name="mappingGenerate">Mapping configuraitons for the CS file.</param>
        public void SyncCsFileWithSmartForm(MappingGenerate mappingGenerate)
        {
            if (Configuration.XsdDownloadFromServer)
            {
                Console.WriteLine("Retrieving XSD for Smart Form: " + mappingGenerate.SmartFormId + "...");
                Console.WriteLine("Connecting to: " + Configuration.XsdWebServiceUrl.Substring(0, 40) + "...");
                string xsd = SmartFormsRepository.FindXsdById(mappingGenerate);
                Console.WriteLine("Writing XSD to file.");
                XsdCsRepository.WriteXsd(mappingGenerate, xsd);
            }
            Console.WriteLine("\nComparing hash for changes:");
            Console.WriteLine("CH: " + mappingGenerate.LastHash);
            Console.WriteLine("DH: " + mappingGenerate.CurrentFileHash());
            if (mappingGenerate.IsXsdDifferent() || !File.Exists(mappingGenerate.GetCsFileLocation()))
            {
                if (File.Exists(mappingGenerate.GetCsFileLocation()))
                {
                    File.Copy(mappingGenerate.GetCsFileLocation(), mappingGenerate.GetCsFileLocation() + "-" + timestamp());
                }
                Console.WriteLine("\nXSD changed. Updating hash");
                mappingGenerate.UpdateLastHash();
                ConfigurationsRespository.Save(Configuration);
                Console.WriteLine("Generating class: " + mappingGenerate.ClassName + "\n");
                XsdCsRepository.Save(mappingGenerate);
            }
            else
            {
                Console.WriteLine("\nXSD file has not changed, nothing to update.\n");
            }
            Console.WriteLine("================== Done ===================");
        }

        /// <summary>
        /// Generate a unix style timestamp.
        /// </summary>
        /// <returns>unix time stamp as string.</returns>
        private string timestamp()
        {
            //Find unix timestamp (seconds since 01/01/1970)
            long ticks = DateTime.UtcNow.Ticks - DateTime.Parse("01/01/1970 00:00:00").Ticks;
            ticks /= 10000000; //Convert windows ticks to seconds
            return ticks.ToString();
        }
    }
}
