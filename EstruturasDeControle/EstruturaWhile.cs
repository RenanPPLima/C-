using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar() {

            int guess = 0;
            Random random = new Random();
            int secretNumber = random.Next(1, 16);
            bool foundNumber = false;
            int attepmtsLeft = 5;
            int attempts = 0;

            while (attepmtsLeft > 0 && !foundNumber) {
                Console.Write("Insert your guess: ");
                string input = Console.ReadLine();
                int.TryParse(input, out guess);
                attepmtsLeft--;
                attempts++;

                if (secretNumber == guess) {
                    foundNumber = true;
                    var previousConsoleColor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("You found the secret number in {0} attempts!", attempts);
                    Console.BackgroundColor = previousConsoleColor;
                } else if (secretNumber < guess && attepmtsLeft > 0)
                    Console.WriteLine("Less... Attempts Left: {0}\n", attepmtsLeft);

                else if (secretNumber > guess && attepmtsLeft > 0)
                    Console.WriteLine("Greater... Attempts Left: {0}\n", attepmtsLeft);

                else {
                    var previousConsoleColor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("You're out of luck today :(");
                    Console.BackgroundColor = previousConsoleColor;
                }
            }
        }
    }
}
