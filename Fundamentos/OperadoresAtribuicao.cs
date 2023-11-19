using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            int num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;
            a++; //a = a + 1. Increment Unary.
            b--; // b = b - 1. Decrement Unary.
            Console.WriteLine($"{a} {b}");

            // From now on, as the instructor said, don't worry too much about the code, but with the concept.
            dynamic c = new System.Dynamic.ExpandoObject();
            c.name = "João";

            dynamic d = c; // Assignment by reference.
            d.nome = "Maria";

            Console.WriteLine(c.nome);
            // So, in this case - "c.name" and "d.name" - both are sharing the same memory space / object.
            // This is a different kind of assingment than seen with "a" and "b" above.
            // Thereby, the assignment between variables can be by VALUE or REFERENCE type.

            /*
              Definition found on the internet:
             
              A Value Type holds the data within its own memory allocation and a Reference Type,
              CONTAINS A POINTER TO ANOTHER MEMORY LOCATION THAT HOLDS THE REAL DATA.
              Reference Type variables are stored in the heap while Value Type variables are stored in the stack.

            */
        }
    }
}
