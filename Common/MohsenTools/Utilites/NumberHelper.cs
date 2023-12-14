using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohsenTools.Utilites
{
    public  class NumberHelper
    {
        /// <summary>
        /// number generator betwean 10 to 100
        /// </summary>
        /// <returns></returns>
        public  int DefineRandomGenerator()
        {
            var rnd = new Random();
            return rnd.Next(10, 100);

        }
        /// <summary>
        ///  compelety random generator 
        /// </summary>
        /// <returns></returns>
        public  int UndefinedRandomGenerator()
        {
            var rnd = new Random();
            return rnd.Next();
        }
    }
}
