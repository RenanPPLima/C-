using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{

    delegate double Operacao(double x, double y); // (1)

    internal class LambdasDelegate
    {
        public static void Executar() {
            Operacao soma = (x, y) => x + y;
            Operacao multiplicar = (x, y) => x * y;
            Operacao subtrair = (x, y) => x - y;
            // var subtrair = (x, y) => x - y;  // (2)

            Console.WriteLine(soma(2.25, 3.4)); // (3)
            Console.WriteLine(multiplicar(2.25, 3.4));
            Console.WriteLine(subtrair(2.25, 3.4));
        }
    }
}

// (1) Here, we're creating a TYPE. Not using FUNC or ACTION. The syntax is the same, though.
//     BUT, I'm instantiating "Operacao" and then creating the function and storing it inside "soma".
//     The path is a little different from "ExemploLambda".
//     DELEGATE is like a Class = It is a TYPE created.
//
// (2) We can't use INFERENCE. We must use the type explicitly.
//
// (3) When you create a delegate variable, it is expected that you have a function and respect its signature.
