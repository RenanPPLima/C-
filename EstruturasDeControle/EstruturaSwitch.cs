using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar() {
            Console.Write("Please, rate our services using a scale from 1 to 5: ");
            double.TryParse(Console.ReadLine(), out double userRate);
            switch (userRate) {
                case 0: Console.WriteLine("Aweful."); break;
                case 1:
                case 2: 
                    Console.WriteLine("Bad."); break;
                case 3: Console.WriteLine("Regular."); break;
                case 4: Console.WriteLine("Good."); break;
                case 5: 
                    {
                        Console.WriteLine("Great!");
                        Console.WriteLine("Congratulations!"); 
                        break;
                    }
                default:Console.WriteLine("Invalid Input."); break;
            }
            if (userRate >= 0 && userRate <= 5) Console.WriteLine("Thanks for the feedback!");
        }
    }
}
// UNLIKE IN JS, in C# we MUST use "break".
// We can't have the SWITCH executing all the cases, like we had in JS.
// For example: If I don't use "break" in the "case 0:" it will generate an Error.
// We can, however, have more than one command inside a case or even a block.
