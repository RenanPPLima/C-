using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        // Here, we have a problem, because C# doesn't know which one I'm referring to when passing the parameters (below).
        // Because we have the same Method Signature ---> Same NAME and PARAMETERS TYPES ( Somar(int..., int...) ).
        // If I add a THIRD parameter to the FIRST method, now they are different.
        // REMEMBER: THIS RULE IS APPLIED WHEN INSIDE THE SAME CLASS. If we are in different classes, no problem having that.


        //public int Somar(int c, int d, int e) {
        //    return c + d;
        //} 

        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }
    
    class CalculadoraEmCadeia
    {
        int memoria; // int default = 0;
        // Every new CalculadoraEmCadeia that I create will have a different space in memory for "memoria".
        // I think it's related to what Renanzeira explained. Here we have an INT type, so the reference is by VALUE not by REFERENCE.

        public CalculadoraEmCadeia Somar(int a) {
            memoria += a;
            return this; // this é sempre uma instancia.
        }

        public CalculadoraEmCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraEmCadeia LimparMemoria() {
            memoria = 0;
            return this;
        }

        public CalculadoraEmCadeia PrintOnConsole() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }

    internal class MetodosComRetorno
    {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultadoDaSoma = calculadoraComum.Somar(5, 5);
            // Here I can't have chainable methods, because their return is an INT.
            // Check: CalculadoraEmCadeia.

            Console.WriteLine(resultadoDaSoma);
            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));


            Console.WriteLine("\nCalculadoraEmCadeia:");
            var calculadoraEmCadeia = new CalculadoraEmCadeia();
            calculadoraEmCadeia.Somar(3).Multiplicar(7).PrintOnConsole().LimparMemoria().PrintOnConsole();
            
            //The line right above is the same as doing the following:

            //calculadoraEmCadeia.Somar(3);
            //calculadoraEmCadeia.Multiplicar(7);
            //calculadoraEmCadeia.PrintOnConsole();
            //calculadoraEmCadeia.LimparMemoria();
            //calculadoraEmCadeia.PrintOnConsole();

            var resultado = calculadoraEmCadeia.Somar(3).Multiplicar(5).Resultado();
            Console.WriteLine(resultado);

            // METHOD CHAINING / CHAINABLE METHODS / CHAIN PATTERN:
            // Method chaining, also known as named parameter idiom,
            // is a common syntax for invoking multiple method calls in object-oriented programming languages.
            // Each method returns an object, allowing the calls to be chained together in a single statement
            // without requiring variables to store the intermediate results.
        }
    }
}
