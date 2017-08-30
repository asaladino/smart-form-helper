using Smart_Form_Helper.Data.Models;
using Smart_Form_Helper.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Form_Helper.Core.Repositories
{
    /// <summary>
    /// Get the smartform xsd from the ektron webservice.
    /// </summary>
    public class HttpSmartFormsRepository : ISmartFormsRespository
    {
        /// <summary>
        /// Contians the connection information.
        /// </summary>
        private Configuration configuration;

        /// <summary>
        /// Load the repository with connection information.
        /// </summary>
        /// <param name="configuration">for the app.</param>
        public HttpSmartFormsRepository(Configuration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// Find the XSD by ID from the webservices.
        /// </summary>
        /// <param name="mappingGenerate">Smart form information</param>
        /// <returns>XSD contents</returns>
        public string FindXsdById(MappingGenerate mappingGenerate)
        {
            string xsd = string.Empty;
            using (WebClient client = new WebClient())
            {
                string url = String.Format(configuration.XsdWebServiceUrl, mappingGenerate.SmartFormId);
                xsd = client.DownloadString(url);
            }
            return xsd;
        }
    }
}
