using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar() {
            Console.Write("Type in the Student's grade: ");

            string userInput = Console.ReadLine();
            double.TryParse(userInput, out double grade);

            if (grade >= 9.0 && grade <= 10) {
                Console.WriteLine("Graduated with Honors!");
            } else if (grade >= 7 && grade < 9) {
                Console.WriteLine("Approved!");
            } else if (grade >= 5 && grade < 7) {
                Console.WriteLine("Retake Test.");
            } else if (grade > 0 && grade < 5){
                Console.WriteLine("Failed again, right?");
            } else {
                Console.WriteLine("Invalid Grade Input, please check again.");
            }
        }
    }
}
