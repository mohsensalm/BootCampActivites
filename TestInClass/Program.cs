using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace TestInClass
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo inf = new DirectoryInfo("C:\\");
            FileInfo[] fileINfo = inf.GetFiles();

            var linqx = from n in fileINfo
                        select n;

            foreach (var item in linqx)
            {
                Console.WriteLine(item.FullName);
            }
            Console.ReadKey();

            int[] x = { 83, 32, 1, 444, 321, 555, 777, 434, 23, 44, 42 };
            
            var linqs = from n in x
                        group n by n % 3 into v
                        select new
                        {
                            reinder = v.Key,
                            numberingroup = v
                        };
            foreach (var item in linqs)
            {
                Console.WriteLine($"{item.reinder}");
                var str = "";
                foreach (var number in item.numberingroup)
                {
                    str += number + ",";
                }
                Console.WriteLine(str);
            }
            Console.ReadKey();


        }
    }
}


