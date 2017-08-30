using Smart_Form_Helper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Form_Helper.Data.Repositories
{
    public interface ISmartFormsRespository
    {
        string FindXsdById(MappingGenerate mappingGenerate);
    }
}
