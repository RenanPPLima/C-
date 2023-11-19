using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano); 
            
            // This D1, D2, D3, etc., thing is used to put ZEROES before the argument.
            // BUT, I still have to find its definition.

        }

        public static void Executar() {
            Formatar(mes: 1, dia: 6, ano: 1996);

            // The idea about having NAMED PARAMETERS IS THIS:

            // Named Parameters allow developers to pass a method arguments with parameter names.
            // Prior to these this feature, the method parameters were passed using a sequence only.
            // Now, using named parameters in C#, we can put any parameter in any sequence as long as the name is there.
            // The right parameter value based on their names will be mapped to the right variable.
            // The parameters name must match with the method definition parameter names.
            // The syntax of parameter names is (parametername: value). 
            
            // In the end we will end up writing more code, but if this makes the code clearer, it's a very good thing.
        }
    }
}
