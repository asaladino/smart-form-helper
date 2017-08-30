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
    /// Handle CS and XSD generation.
    /// </summary>
    public class ProcessXsdCsRepository : IXsdCsRepository
    {
        /// <summary>
        /// Information about the XSD generation
        /// </summary>
        private Configuration configuration;

        /// <summary>
        /// Create repository with a configuration.
        /// </summary>
        /// <param name="configuration">Information about the XSD generation</param>
        public ProcessXsdCsRepository(Configuration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// Generate the CS file from the mapping.
        /// </summary>
        /// <param name="mappingGenerate">mapping information and additions.</param>
        public void Save(MappingGenerate mappingGenerate)
        {
            runCommand(mappingGenerate);
            addReplacements(mappingGenerate);
        }

        /// <summary>
        /// Runs the command to generate the CS file.
        /// </summary>
        /// <param name="mappingGenerate">CS and XSD information</param>
        private void runCommand(MappingGenerate mappingGenerate)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = configuration.XsdCommand;
            startInfo.UseShellExecute = false;
            string [] xsdArguments = mappingGenerate.AsArguments();
            startInfo.Arguments = String.Format(configuration.XsdArguments, xsdArguments);
            Console.WriteLine("Running Command:\n" + startInfo.FileName + " " + startInfo.Arguments + "\n");
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        /// <summary>
        /// Add newlines to the newly created CS file.
        /// </summary>
        /// <param name="mappingGenerate">containing the additions.</param>
        private void addReplacements(MappingGenerate mappingGenerate)
        {
            if (File.Exists(mappingGenerate.GetCsFileLocation()))
            {
                List<string> lines = new List<string>(File.ReadAllLines(mappingGenerate.GetCsFileLocation()));
                foreach (var addition in mappingGenerate.Additions)
                {
                    int lineNumber = -1;
                    int lineTrack = 0;
                    foreach (var line in lines)
                    {
                        if (addition.AfterSearchTerm == "" ||
                            line.IndexOf(addition.AfterSearchTerm) > -1)
                        {
                            lineNumber = lineTrack + 1;
                            break;
                        }
                        lineTrack++;
                    }
                    if (lineNumber > -1)
                    {
                        lines.Insert(lineNumber, "");
                        lines.Insert(lineNumber + 1, addition.Code);
                    }
                }
                File.WriteAllLines(mappingGenerate.GetCsFileLocation(), lines); 
            }
        }

        /// <summary>
        /// Write XSD contents to the file.
        /// </summary>
        /// <param name="mappingGenerate">XSD file information</param>
        /// <param name="xsd">XML contents to write.</param>
        public void WriteXsd(MappingGenerate mappingGenerate, string xsd)
        {
            File.WriteAllText(mappingGenerate.XsdFile, xsd);
        }
    }
}
