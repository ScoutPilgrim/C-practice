using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVer = "1.0.0";
            string appAuth = "Ian Christner";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}:{1}:{2}",appName,appVer,appAuth);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("What is your name?");
            string userName;
            userName = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Hello {0}, let us ", userName);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("PLAY");
            Console.ResetColor();
            Console.WriteLine(" a game ;)");

            Random rand = new Random();
            int numGuess = rand.Next(1, 10);
            string qu = "Guess a number between 1 and 10.";
            Console.WriteLine("{0}", qu);

            string guess = Console.ReadLine();
            bool gameFlag = gameFunc(guess, numGuess);
            while (!gameFlag)
            {
                guess = Console.ReadLine();
                gameFlag = gameFunc(guess, numGuess);
            }

            printSuccess();
            

            


        }
        private static void errPrint()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Please enter a number between 1 and 10");
            Console.ResetColor();
        }

        private static bool gameFunc(string input, int secretNum)
        {
            int intGuess;
            if (Int32.TryParse(input, out intGuess))
            {

            }
            else
            {
                errPrint();
                return false;
            }
            if (intGuess < 1 || intGuess > 10)
            {
                errPrint();
                return false;
            }
            if(intGuess < secretNum)
            {
                Console.WriteLine("The secret number is higher than {0}", intGuess);
                return false;
            }
            if(intGuess > secretNum)
            {
                Console.WriteLine("The secret number is lower than {0}", intGuess);
                return false;
            }
            if(intGuess == secretNum)
            {
                return true;
            }
            return false;
        }

        private static void printSuccess()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("C O N G R A T S");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("YOU GUESSED THE SECRET NUMBER!!!!!");
            Console.ResetColor();
        }

    }
}
