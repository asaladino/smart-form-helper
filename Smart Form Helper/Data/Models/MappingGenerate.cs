using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Form_Helper.Data.Models
{
    /// <summary>
    /// This model helps the generate CS file from an XSD file.
    /// </summary>
    public class MappingGenerate
    {

        /// <summary>
        /// Smart form ID for the mapping.
        /// </summary>
        public int SmartFormId = -1;

        /// <summary>
        /// XSD file location. {0} command entry.
        /// </summary>
        public string XsdFile = "";

        /// <summary>
        /// Language to generate the class in. {1} command entry.
        /// </summary>
        public string Language = "CS";

        /// <summary>
        /// Namespace for the class. {2} command entry.
        /// </summary>
        public string NameSpacePrefix = "MSMC.Common.Model.";

        /// <summary>
        /// Name of the class to create. {3} command entry.
        /// </summary>
        public string ClassName = "";

        /// <summary>
        /// Where the cs file will be outputed. {4} command entry.
        /// </summary>
        public string OutputDir = "";

        /// <summary>
        /// Last hash value of the xsd to check for changes.
        /// </summary>
        public string LastHash = "";

        /// <summary>
        /// Additions to be made to the cs file.
        /// </summary>
        public List<Addition> Additions = new List<Addition>();

        /// <summary>
        /// The name of the mapping generate class is the ClassName and SmartFormId
        /// </summary>
        /// <returns>The class name</returns>
        override public string ToString()
        {
            return ClassName + " | " + SmartFormId;
        }

        /// <summary>
        /// Check if the hash for the xsd has changed.
        /// </summary>
        /// <returns>true if has never been checked or has changed.</returns>
        public bool IsXsdDifferent()
        {
            return LastHash == "" || HashForFile(XsdFile) != LastHash;
        }

        /// <summary>
        /// Get the expected CS file location.
        /// </summary>
        /// <returns>the location</returns>
        public string GetCsFileLocation()
        {
            return OutputDir + "\\" + ClassName + "." + Language.ToLower();
        }

        /// <summary>
        /// Update the last hash for the xsd file.
        /// </summary>
        public void UpdateLastHash()
        {
            LastHash = CurrentFileHash();
        }

        /// <summary>
        /// Get the current hash for the XSD file.
        /// </summary>
        /// <returns>hashed value.</returns>
        public string CurrentFileHash()
        {
            return HashForFile(XsdFile);
        }

        /// <summary>
        /// Generate a has for a file.
        /// </summary>
        /// <param name="Filename">Absolute path to a file.</param>
        /// <returns></returns>
        private string HashForFile(string filename)
        {
            string contents = File.ReadAllText(filename);
            return CreateSHAHash(contents);
        }

        /// <summary>
        /// Create an SHA hash for a string.
        /// </summary>
        /// <param name="Phrase">string to hash</param>
        /// <returns>hashed string</returns>
        private static string CreateSHAHash(string Phrase)
        {
            SHA512Managed HashTool = new SHA512Managed();
            Byte[] PhraseAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Phrase));
            Byte[] EncryptedBytes = HashTool.ComputeHash(PhraseAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }

        /// <summary>
        /// Get the arguments is a specific order.
        /// </summary>
        /// <returns>an array list of arguments.</returns>
        public string[] AsArguments()
        {
            return new string[] { " \"" + XsdFile + "\" ", Language, NameSpacePrefix, ClassName, "\"" + OutputDir + "\"" };
        }
    }
}
