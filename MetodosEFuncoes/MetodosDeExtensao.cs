using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int num2) { // (2)
            return num + num2;
        }

        public static int Subatracao(this int num, int num2) {
            return num - num2;
        }
    }

    internal class MetodosDeExtensao
    {
        public static void Executar() {
            int num = 5;
            int num2 = 3;

            // (1)
            Console.WriteLine(num2.Soma(5));
            Console.WriteLine(num.Subatracao(10));

            Console.WriteLine(5.Soma(3));
            Console.WriteLine(5.Subatracao(10));
        }
    }
}

// (1) Here's the idea: when using Extension Methods, we kind of create functions that didn't exist before and use them
//     as if they were from the C# API! Interesting, right?
//     That's why we can do this "(5.Soma(3));" ---> It's like "Soma()" is a function from C# to INTs.
//     It's a customized method that behaves like it's from C# itself, basically.
//
// (2) When using "THIS" means that you are extending that paremeter (always the first one).
