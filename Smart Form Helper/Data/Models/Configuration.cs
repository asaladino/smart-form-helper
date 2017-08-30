using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Form_Helper.Data.Models
{
    /// <summary>
    /// General configuration for the application
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// The command to generate the CS file from XSD file.
        /// </summary>
        public string XsdCommand = @"xsd";

        /// <summary>
        /// Arguments that get passed to the XSD command.
        /// </summary>
        public string XsdArguments = @"%0 /classes /language:%1 /namespace:%2%3 /outputdir:%4";
        
        /// <summary>
        /// Webservice URL to pull in the XSD file.
        /// </summary>
        public string XsdWebServiceUrl = "";

        /// <summary>
        /// Set to true to download the XSD from the server.
        /// </summary>
        public bool XsdDownloadFromServer = false;

        /// <summary>
        /// List of XSD to CS mappings.
        /// </summary>
        public IList<MappingGenerate> MappingGenerates = new List<MappingGenerate>();
    }
}
