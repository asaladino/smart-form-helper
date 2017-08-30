using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Form_Helper.Data.Models
{
    /// <summary>
    /// Add some addition code to the CS file after generation on a specific line number.
    /// </summary>
    public class Addition
    {
        /// <summary>
        /// Name of the addition
        /// </summary>
        public string Name = "New Addition";

        /// <summary>
        /// Line number in the cs file.
        /// </summary>
        public string AfterSearchTerm = "";

        /// <summary>
        /// Code to insert at the line number.
        /// </summary>
        public string Code = "// empty";

        /// <summary>
        /// Get the name of the class.
        /// </summary>
        /// <returns>the name</returns>
        override public string ToString()
        {
            return Name;
        }
    }
}
