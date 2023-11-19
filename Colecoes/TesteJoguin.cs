using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class TesteJoguin
    {
        public static void Executar() {

            int guess = 0;
            Random random = new Random();
            int secretNumber = random.Next(1, 16);
            bool foundNumber = false;
            int attemptsLeft = 5;
            int userAttempts = 0;


            while (attemptsLeft > 0 && !foundNumber) {
                Console.Write("Insert your Guess: ");
                string input = Console.ReadLine();
                int.TryParse(input, out guess);
                attemptsLeft--;
                userAttempts++;

                if (secretNumber == guess) {
                    foundNumber = true;

                    var previousConsoleColor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("You found the secret number in: {0} attempts! You saved the Estagiário!", userAttempts);
                    Console.BackgroundColor = previousConsoleColor;

                } else if (secretNumber < guess && attemptsLeft > 0) {
                    Console.WriteLine("Less... You have {0} attempts left to save the Estagiário!\n", attemptsLeft);

                } else if (secretNumber > guess && attemptsLeft > 0) {
                    Console.WriteLine("Greater... You have {0} attempts left to save the Estagiário!\n", attemptsLeft);

                } else {
                    var previousConsoleColor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("ERRRRRRROOOUUUU! A Beetools Explodiu!");
                    Console.BackgroundColor = previousConsoleColor;

                }
            }
        }
    }
}
