using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            int negativeValue = -5;
            int number1 = 2;
            int number2 = 3;
            bool boolean = true;

            Console.WriteLine(-negativeValue); // it inverts the sign!
            Console.WriteLine(!boolean); // negation.

            number1++; // ++ after the variable ---> POSTFIX OPERATOR.
            Console.WriteLine(number1);

            --number1; // -- before the variable ---> PREFIX OPERATOR.
            Console.WriteLine(number1);

            Console.WriteLine(number1++ == --number2);

            /*
                In this case, "number1" will be incremented AFTER the comparison and "number2" decremented BEFORE it.
                The output is: TRUE.
                However, if we print their values (right below) we'll see that "number1 = 3" and "number2 = 2".
            */
            Console.WriteLine($"{number1} {number2}");

            /*
                VERY IMPORTANT: in this case right above - Console.WriteLine(number1++ == --number2); -
                the instructor says it's a bad practice because it's CONFUSING.

                YOU'RE MIXING INCREMENT, DECREMENT, POSTFIX AND PREFIX, AND MAKING A COMPARISON.
                So, this is not a good practice because it's a difficult code to read and understand what's happening.
            */ 
        }
    }
}
