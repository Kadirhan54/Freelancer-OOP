using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Freelancer.Utils
{
    internal static class TypeUtils
    {
        public static string GetTypeOfObject(object Objectt) => Objectt.GetType().ToString().Split(".").LastOrDefault();
    }
}
