using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    // In C#, "params" is a keyword which is used to specify a parameter that takes variable number of arguments.
    // It is useful when we don't know the number of arguments prior/before.
    // ONLY ONE "params" keyword is allowed and NO ADDITIONAL PARAMETER IS PERMITTED after "params" keyword in a function declaration.

    internal class Params
    {
        public static void Recepcionar(params string[] pessoas) { 
            foreach (string pessoa in pessoas) {
                Console.WriteLine("Hello {0}", pessoa);
            }
        }

        public static void UsingFor(params string[] people) {
            for (int i = 0; i < people.Length; i++) {
                string person = people[i];
                Console.WriteLine("Using For: Hello {0}", person);
            }
        }

        public static void Executar() {
            Recepcionar("Pedro", "Renan", "Paulo", "Jonas");
            UsingFor("Paulo", "Ricardão", "Renan", "Marcelo");
        }

    }
}
