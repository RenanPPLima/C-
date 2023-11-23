using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Nullables
    {
        public static void Executar() {
            Nullable<int> num1 = null;
            int? num2 = null; // (1)

            if (num1.HasValue) {
                Console.WriteLine("O valor de num1 é: {0}", num1);
            } else {
                Console.WriteLine("A variável não possui valor atribuído (null).");
            }

            // int num3 = num1;  // (2)
            int num3 = num1 ?? 27;
            Console.WriteLine(num3);

            bool? booleano = null;
            bool resultado = booleano.GetValueOrDefault(); // bool default = false.
            Console.WriteLine(resultado);

            try {
                int x = num1.Value;
                int y = num2.Value;
            } catch (Exception ex){
                Console.WriteLine(ex.Message); // same error as "// (2)".
            }
        }
    }
}
// (1) Two ways of setting a Nullable (declaring explicitly) or using "?".
//
// (2) If you're trying to make this assignment to "int num3 = num1" - There will be an error (line 21 of the code).
//     Because "num3" is an "int" as is not set as a Nullable. So, when can use the notation "??" to solve this:
//     If the number is NULL, use the value after the "??" (Null Coalescing Operator / Operador de Coalescência Nula).
