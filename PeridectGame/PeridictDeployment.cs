using MohsenTools.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeridectGame
{

    internal class PeridictDeployment
    {
        StringHelper helper = new StringHelper();
        public void EasyMode(int randomNum)
        {

            do
            {
                var userinput = helper.GetNumber(helper.GEtStringFromConsole());


                if (userinput > randomNum)
                {
                    Console.WriteLine("ur number is high");
                    continue;

                }
                else if (userinput < randomNum)
                {
                    Console.WriteLine("ur number is low");
                    continue;
                }
                else
                {
                    break;
                }

            }
            while (true);

            Console.WriteLine("u find it");
        }

        public void MediumMode(int randNUm)
        {
            var x = 0;
            do
            {
                var userinput = helper.GetNumber(helper.GEtStringFromConsole());


                if (userinput > randNUm)
                {
                    Console.WriteLine("ur number is high");
                    x++;
                    continue;

                }
                else if (userinput < randNUm)
                {
                    Console.WriteLine("ur number is low");
                    x++;
                    continue;
                }
                else
                {
                    break;
                }

            }
            while (x < 10);

            if (x >= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" u out of luck dud");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("u find it");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        #region my_hard_mode_game
        //public void HardMod(int rndNumber)
        //{
        //    var f = 0;
        //    var guide = "u have pased half of ur chances but i have help for u u wante it or not ? yes    or    no  ";
        //    var userTrays = 0;
        //    List<int> usersNumbers = new List<int>();


        //    for (int i = 0; i < 15; i++)
        //    {
        //        if ((userTrays *= 2) >= 10)
        //        {
        //            Console.WriteLine(guide);
        //            var x = helper.GEtStringFromConsole();
        //            if (x == "yes" || x == "Yes")
        //            {
        //                Console.WriteLine($"ur guess is betwean {usersNumbers[i - 1]} and  {usersNumbers[i]}");

        //            }
        //            else
        //            {

        //                Console.WriteLine("fareWell dud");

        //            }

        //        }
        //        else
        //        {
        //            do
        //            {
        //                var userinput = helper.GetNumber(helper.GEtStringFromConsole());


        //                if (userinput > rndNumber)
        //                {
        //                    Console.WriteLine("ur number is high");
        //                    f++;
        //                    continue;

        //                }
        //                else if (userinput < rndNumber)
        //                {
        //                    Console.WriteLine("ur number is low");
        //                    f++;
        //                    continue;
        //                }
        //                else
        //                {
        //                    break;
        //                }

        //            }
        //            while (f < 10);

        //        }
        //    }

        #endregion

        /// <summary>
        /// ai logic  
        /// </summary>
        /// <param name="rndNumber"></param>
        public void HardMode(int rndNumber)
        {

            Console.WriteLine("Welcome to the Advanced Number Guessing Game!");

            // Generate a random number between 1 and 100
           

            int attempts = 0;
            int maxAttempts = 10; // Set the maximum number of attempts
            int points = 100; // Initial points
            int lives = 3; // Initial lives

            while (attempts < maxAttempts && lives > 0)
            {
                Console.WriteLine($"Points: {points} | Lives: {lives}");

                Console.Write("Enter your guess (between 1 and 100): ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int userGuess))
                {
                    attempts++;

                    if (userGuess < 1 || userGuess > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100.");
                    }
                    else if (userGuess < rndNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                        points -= 10; // Deduct points for a wrong guess
                    }
                    else if (userGuess > rndNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                        points -= 10; // Deduct points for a wrong guess
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the correct number ({rndNumber}) in {attempts} attempts.");
                        Console.WriteLine($"Your final score: {points}");
                        return; // End the game
                    }

                    // Deduct points and lose a life after 5 incorrect attempts
                    if (attempts % 5 == 0)
                    {
                        points -= 20;
                        lives--;

                        Console.WriteLine($"Hint: You lost a life. Remaining lives: {lives}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine($"Sorry, you've reached the maximum number of attempts or ran out of lives. The correct number was {rndNumber}.");
            Console.WriteLine($"Your final score: {points}");
            Console.WriteLine("Thanks for playing!");





        }


    }
}
