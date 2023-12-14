using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohsenTools.Utilites
{
    public static class I_OHelper
    {
        public static List<string> FileReciver(string path)
        {
            var Result = Directory.GetFiles(path, "*.txt");
            return Result.ToList();
        }
    }
}
