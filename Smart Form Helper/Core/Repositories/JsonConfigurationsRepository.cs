using Newtonsoft.Json;
using Smart_Form_Helper.Data.Models;
using Smart_Form_Helper.Data.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Form_Helper.Core.Repositories
{
    /// <summary>
    /// This repository helps load and save the config file to json.
    /// </summary>
    public class JsonConfigurationsRepository : IConfigurationsRepository
    {
        /// <summary>
        /// Location of the json configuration file.
        /// </summary>
        private string Filename;

        /// <summary>
        /// Build the repository with the file location.
        /// </summary>
        /// <param name="filename">location of the json file.</param>
        public JsonConfigurationsRepository(String filename)
        {
            this.Filename = filename;
        }

        /// <summary>
        /// Retrieve the configuration from the json file.
        /// </summary>
        /// <returns>the configuration.</returns>
        public Configuration Find()
        {
            if (File.Exists(this.Filename))
            {
                string json = File.ReadAllText(this.Filename);
                return JsonConvert.DeserializeObject<Configuration>(json);
            }
            return null;
        }

        /// <summary>
        /// Save the configuration to the json file.
        /// </summary>
        /// <param name="configuration">to save.</param>
        public void Save(Configuration configuration)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.Indented;
            string json = JsonConvert.SerializeObject(configuration, settings);
            File.WriteAllText(this.Filename, json);
        }
    }
}
