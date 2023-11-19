using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            Console.Write("Type in the Student's Grade: ");
            double.TryParse(Console.ReadLine(), out double grade);

            Console.Write("Has the Student demonstrated Good Behavior (true or false)? ");
            bool.TryParse(Console.ReadLine(), out bool goodBehavior);

            string result = grade >= 7.0 && goodBehavior ? "Approved!" : "Failed Again, didn't you?";
            Console.Write(result);

            // Remember that we can use "TryParse" to a Boolean, because it's binary (0 = false; 1 = true).

        }
    }
}
