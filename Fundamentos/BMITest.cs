using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class BMITest
    {
        public static void Executar() {

            // CAREFUL WITH "," and "." when inputting the Height.
            Console.Write("Type in your Weight (in Kilos): ");
            string weight = Console.ReadLine();
            double userWeight = Convert.ToDouble(weight);

            Console.Write("Type in your Height (in Meters): ");
            string height = Console.ReadLine();
            double userHeight = Convert.ToDouble(height);

            double bmi = userWeight / Math.Pow (userHeight, 2);

            Console.WriteLine("Your BMI is: {0}", bmi);

            //----------------- I CAN ALSO DO THIS -----------------//

            Console.Write("Type in your Weight (in Kilos): ");
            double.TryParse(Console.ReadLine(), out double weight2);

            Console.Write("Type in your Height (in Meters): ");
            double.TryParse(Console.ReadLine(), out double height2);

            double bmi2 = weight2 / Math.Pow(height2, 2);

            Console.Write("Your BMI is: {0}", bmi2);
        }
    }
}
