using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar() {
            double value = 15.175;
            // When using ".ToString()" --> inside the parentheses I define the conversion format.
            Console.WriteLine(value.ToString("F1")); // "F1" is to use only 1 decimal place, and it rounds the decimals.
            Console.WriteLine(value.ToString("C")); // "C" = Currency (my Windows is in Portuguese).
            Console.WriteLine(value.ToString("P")); // "P" = Multiplies times 100 and inserts a percentual.,
            Console.WriteLine(value.ToString("#.##")); // "#.##" is the same as using "F2" in this case (remember it rounds the number).

            CultureInfo culture = new CultureInfo("pt-BR");
            Console.WriteLine(value.ToString("C2", culture)); // "Cx" = how many decimals you want to have (it rounds the number).
                                                              // Also, by default ("C") uses 2 decimal places and also rounds the number.
            int integer = 256;
            Console.WriteLine(integer.ToString("D5")); // "Dx" adds zeroes to the left of the number. It takes into account the number itself.
                                                       // This is useful when transforming a number into text, and wants the zeroes to appear.
        }
    }
}
