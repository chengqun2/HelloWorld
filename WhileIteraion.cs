using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteraion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while(displayMenu)
            {
                displayMenu = MainMenu();
            } 
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Chose an Option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guess Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print nubmners!");
            Console.Write("Type a number:");
            int result = int.Parse(Console.ReadLine());
            int conser = 1;
            while (conser < result + 1)
            {
                Console.Write(conser);
                if (conser < result)
                {
                    Console.Write("-");
                }
                conser++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game!");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.Write("Guess a numner 1 to 10:");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.Write("Wrong!");
                }
            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses.",guesses);
            Console.ReadLine();
        }
    }
}
