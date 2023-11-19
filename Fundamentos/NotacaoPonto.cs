using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar() {
            string greeting = "Hello".Insert(5, "Mundo!").Replace("Mundo!", " World!").ToUpper();
            Console.WriteLine(greeting);

            Console.WriteLine("Test".Length);

            string importantValue = null;
            // Console.WriteLine(importantValue.Length);

            /* 
                Error: Object reference not set to an instance of an object.
                The instructor is warning us to be careful with empty "things", because the DOT NOTATION is all around the system.
                However, we have a feature in the language that's called "SAFE NAVIGATION OPERATOR" ---> "?".
            */

            Console.WriteLine(importantValue?.Length); // now we don't have an error.
        }

    }
}
