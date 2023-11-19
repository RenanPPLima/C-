using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegateFuncAnonima
    {
        delegate string StringOperacao(string str);

        public static void Executar() {
            StringOperacao inverter = delegate (string str) { // (1)
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string (charArray);
            };

            Console.WriteLine(inverter("C# is concert of ball"));
        }
    }
}
// (1) Here, I have an anonymous function of the type StringOperacao stored in "inverter".
//     Since I'm not using the Arrow Function here, I have to pass the parameter "(string str)" to the variable "inverter".