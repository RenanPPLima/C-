using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritimeticos
    {
        public static void Executar() {
            // Price with Discount:
            int price = 1000;
            int taxes = 355;
            float discount = 0.1f;

            var totalPrice = price + taxes;
            var totalWithDiscount = totalPrice - (totalPrice * discount);
            Console.WriteLine("The final price is: {0}", totalWithDiscount);

            // Body Mass Index (BMI):
            float weight = 91.2f;
            float height = 1.82f;
            double bmi = weight / Math.Pow(height, 2); // Math.Power = potência. (base, exponent).
            Console.WriteLine($"Your BMI is: {bmi}");



            // Even and Odd numbers:
            int even = 24;
            int odd = 13565;
            Console.WriteLine("{0}/2 has a remainder of: {1} ", even, even % 2);
            Console.WriteLine("{0}/2 has a remainder of: {1} ", odd, odd % 2);


        }
    }
}
