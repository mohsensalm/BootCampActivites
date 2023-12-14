using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohsenTools.Utilites
{
    public   class StringHelper
    {
        /// <summary>
        /// simple readline methode
        /// </summary>
        /// <returns></returns>
      public   string GEtStringFromConsole()
        {
            Console.WriteLine("inter an number");
            return Console.ReadLine();
        }
        /// <summary>
        /// get number from user input
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public  int GetNumber( string str)
        {
            return Convert.ToInt32(str);

        }
        /// <summary>
        /// general use
        /// </summary>
        /// <returns></returns>
        public string GeneralGetStringFromConsole()
        {
            return Console.ReadLine();
        }
    }
}
