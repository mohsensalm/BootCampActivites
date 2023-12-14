using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MohsenTools.Utilites;
using MohsenTools.Extensions;

namespace PeridectGame
{
    internal class Program
    {
        static void Main(string[] args)

        {
            var strHelper = new StringHelper();
            var numHelper = new NumberHelper();
            var gamemod = new PeridictDeployment();


            Console.WriteLine("hello dud pls deside mode of the game");

            do
            {
                var rndNumber = numHelper.DefineRandomGenerator();

                Console.WriteLine(
                    "1) Mode 1 (easy)\n" +
                    "2) Mode 2 (medium)\n" +
                    "3) Mode 3 (hard)\n" +
                    "0) you tierd and wane leave \n");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out var i))
                {
                    Console.WriteLine("invalid key");
                    continue;
                }
                if (i == 0) break;

                switch (i)
                {
                    case 1:

                        Console.ForegroundColor = ConsoleColor.Green;
                        gamemod.EasyMode(rndNumber);
                        Console.WriteLine();
                        break;



                    case 2:
                        gamemod.MediumMode(rndNumber);
                        Console.WriteLine();
                        break;

                    case 3:

                        break;
                    case 0:

                        break;
                }
            } while (true);
        }
    }
}
