using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar() {
            Console.Write("Student's Grade: ");
            double.TryParse(Console.ReadLine(), out double grade);
            double passingScore = 7.0;

            Console.WriteLine("Invalid Grade Input (greater than 10.0)? {0}", grade > 10.0);
            Console.WriteLine("Invalid Grade Input (less than 0.0)? {0}", grade < 0.0);
            Console.WriteLine("Perfect Grade? {0}", grade == 10.0);
            Console.WriteLine("Can it be better? {0}", grade != 10.0);
            Console.WriteLine("Passed by average? {0}", grade >= passingScore);
            Console.WriteLine("Retake Tests? {0}", grade < passingScore);
            Console.WriteLine("Failed? {0}", grade <= 3.0);


        }
    }
}
