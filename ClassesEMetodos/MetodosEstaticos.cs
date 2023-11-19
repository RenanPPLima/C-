using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {
            // Here's the idea: When I have a STATIC METHOD, I can access it directly from the class
            // not needing to create a variable to have a new instance
            // and from there access the methods through a new object.

            // I.E.: A STATIC MEMBER (attributes or methods) BELONG TO THE CLASS, NOT TO THE INSTANCE/OBJECT.

            public static int Somar(int a, int b) {
                return a + b;
            } // CLASS METHOD

            public int Multiplicar(int a, int b) {
                return (a * b);
            } // INSTANCE METHOD
        }

        public static void Executar() {

            Console.WriteLine(CalculadoraEstatica.Somar(2, 24)); // I can print it directly.

            int somar = CalculadoraEstatica.Somar(2, 14); // OR store it in a variable.
            Console.WriteLine(somar);
            // Using this static method I don't need to create a new object/instance,
            // and from it access the methods (like seen before, example below):

            var multiplicar = new CalculadoraEstatica();
            Console.WriteLine(multiplicar.Multiplicar(2, 16));

        }
    }
}
