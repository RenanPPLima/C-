using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaDoWhile
    {
        public static void Executar() {
            // (1) This structure is also used for indeterminate loops.
            // Here's something different from WHILE. When using DO the block WILL BE EXECUTED at least once (the first time).
            // In WHILE, if the expression is false right at the first time, it won't get executed.
            string input;
            do {
                Console.Write("What's your name? ");
                input = Console.ReadLine();
                Console.WriteLine("Welcome, {0}!", input);
                Console.Write("Do you want to continue (Y/N)? ");
                input = Console.ReadLine();
                Console.WriteLine();
            } while (input.ToLower() == "y");
            // (1) The program will be executed as long as the user inputs answers "y".
            // That's why this is also used for indeterminate loops.
        }
    }
}
