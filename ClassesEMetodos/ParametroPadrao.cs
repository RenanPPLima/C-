using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametroPadrao // We can't use Default Values for REF and OUT.
    {

        public static int Somar(int a = 1, int b = 1) {
            return a + b;
        }

        public static void Executar() {
            Console.WriteLine(Somar(10, 33));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: -7));
        }
    }
}
// The good thing is: I don't have to pass all the parameters to the method. If I pass only one, it won't break.
// Also, like seen above, you can have many parameters, and use only one that's a named parameter.