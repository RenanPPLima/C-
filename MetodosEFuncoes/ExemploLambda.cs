using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar() {
            Action algoNoConsole = () => { // (1)
                Console.WriteLine("Lambda com C#");
            };
            algoNoConsole(); // (2)

            Func<int> jogarDado = () => { // (3)
                Random randomDice = new Random();
                return randomDice.Next(1, 7);
            };
            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X"); // (4)
            Console.WriteLine(conversorHex(1234));

            // (5)
            //  Func<int, string> coversorHex = (numero) => {   
            //      return numero.ToString("X");
            //  };

            Func<int, int, int, string> formatarData = (dia, mes, ano) => 
            String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano); // mustn't use "return" here, because it's implicit.
            Console.WriteLine(formatarData(1, 1, 2019));

            Action<string> algoNoConsole2 = (a) => Console.WriteLine("Lambda com C#" + a);
            algoNoConsole2(": Testing something");
        }
    }
}

// (1) ARROW FUNCTION (Notação Arrow) - "=>"
//     ACTION is an anonymous function that doesn't have a return (i.e., VOID), the opposite from "FUNC".
//     This keyword allows us to store a function inside a variable.
//
// (2) "algoNoConsole" is not the function's name, it's the variable's name. The function - after "=" - is anonymous.
//
// (3) "Func<>" inside the "<>" you define the return.
//
// (4) Here, we're having a different syntax since we have only ONE STATEMENT in the function.
//
// (5) Here, we have the way seen before. If we use {}, we must use the keyword "return" and everything else.
//
// So, ACTION is a VOID function. Whatever is inside the "<>" are the parameters.
// When using FUNC, THE LAST "parameter" is the return type: Func <int, double, char, string>. String is the return.
