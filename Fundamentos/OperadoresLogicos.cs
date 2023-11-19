using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar() {
            Console.Write("Answer with true or false: Did you get the Tuesday Job? ");
            bool.TryParse(Console.ReadLine(), out bool work1);

            Console.Write("Answer with true or false: Did you get the Thursday Job? ");
            bool.TryParse(Console.ReadLine(), out bool work2);

            bool fiftyInchTv = work1 && work2;
            Console.WriteLine("Have they bought the 50'' TV? {0}", fiftyInchTv);

            // In C# for XOR we use: "^".
            bool thirtyTwoInchTv = work1 ^ work2; 
            Console.WriteLine("Have they bought the 32'' TV? {0}", thirtyTwoInchTv);

            bool eatMcDonalds = work1 || work2;
            Console.WriteLine("Have they had McDonald's? {0}", eatMcDonalds);

            Console.WriteLine("Are they healthier? {0}", !eatMcDonalds);

            // When using ".TryParse" in this case, remember that an invalid input is converted to "0" (ZERO). And ZERO = false.
            // Reminder: XOR = operação lógica entre dois operandos que resulta em um valor lógico VERDADEIRO SE E SOMENTE SE os dois operandos forem DIFERENTES.
            // Reminder: Truth Table.
        }
    }
}
