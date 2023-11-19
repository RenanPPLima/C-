using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar() {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            // ReadLine is only for strings, and you can't convert it to a number using only ReadLine, it generates an error.
            int age = int.Parse(Console.ReadLine());
            // So, in this case we use "Parse" --> It transforms a "number string" into an actual number, so we can make operations with it.

            Console.Write("How much do you earn? ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{name} {age} ${salary}");

            // WE HAVE TO BE CAREFUL WITH "." AND "," WHEN SEPARATING THE NUMBERS IN THE CONSOLE, because my Windows is in Portuguese,
            // so, when there's a decimal input in the console, I have to use ",". If I use ".", it will be ignored by the console.

            // To make this problem ignored by the system, (1) we use: "using System.Globalization;" and on the decimal we want this to happen,
            // we use this: "CultureInfo.InvariantCulture".
        }
    }
}
