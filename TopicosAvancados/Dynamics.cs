using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Dynamics
    {
        public static void Executar() {
            dynamic meuObjeto = "string"; 
            meuObjeto = 3;
            meuObjeto++; // (1)
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject(); // (2)
            aluno.nome = "Maria";
            aluno.idade = 24;
            aluno.nota = 8.9;
        }
    }
}
// (1) The bad thing about using the "dynamic" is that the errors only will occur when executing the code (RunTime).
//     Not before (when we have the red underlining in the code).
//
//     E.g.:
//
//     string meuObjeto = "string";
//
//     meuObjeto++;
//     
//     Here, we would have the red underlining on "meuObjeto++;" - because, of course, we can't use this operator "++" with a string.
//     However, if we change from type string to dynamic, the error would come out only when executing the code (Run Time Error).
//
// (2) Creating an object in a dynamic way. This is very similar to JS, but here it's an exception, in JS it's a rule.
//
//     It's good that C# offers this more flexible possibilities, however, it's not JS. Remember that.