using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar() {
            string userInput;

            Console.Write("Type in the Student's grade: ");
            userInput = Console.ReadLine();
            Double.TryParse(userInput, out double grade);

            if (grade >= 7) {
                Console.WriteLine("Approved!");
                Console.WriteLine("You did what you were supposed to do...");
            } else {
                Console.WriteLine("Retake tests");
            }

            if (grade >= 9)
                Console.WriteLine("Great!");
            else
                Console.WriteLine("Failed again, didn't you? Champion...");
            Console.WriteLine("What a shame...");
            // BE CAREFUL WITH THIS, THIS WILL GET EXECUTED BECAUSE
            // IT'S OUT OF "ELSE". Beetools Devs, when using a single statement for if/else, write on the same line.




        }
    }
}
