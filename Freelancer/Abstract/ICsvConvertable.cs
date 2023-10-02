using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Abstract
{
    internal interface ICsvConvertable
    {
        string GetValuesCSV();

        void SetValuesCSV(string csv);
    }
}
