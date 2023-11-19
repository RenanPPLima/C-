using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIF {
        public static void Executar() {
            bool goodBehavior = false;
            string userInput;

            Console.Write("Type in the Student's grade: ");
            userInput = Console.ReadLine();
            Double.TryParse(userInput, out double grade);

            Console.Write("Does the Student have Good Behavior (Y / N): ");
            userInput = Console.ReadLine();

            //if (userInput == "Y" || userInput == "y") ------> I CAN DO THIS, but it's not the best way.
            //    goodBehavior = true;

            // goodBehavior = userInput == "S" || userInput == "s"; -----> I can also do this.
            goodBehavior = userInput.ToLower() == "s"; // This would be the simpler way (.ToLower() converts Uppercase to Lowercase.

            if (grade >= 9.0 && goodBehavior) { // When having a BOOLEAN variable, no need to make a comparison.
                Console.WriteLine("Graduated with Honors!");
            }
            // Also, a very important warning here: BE CAREFUL WITH ";" because in C# it's a valid statement.
            int number1 = 1;
            int number2 = 2;
            if (number1 == number2) ;
            {
                Console.WriteLine("Careful with ';' for it can cause a BUG!"); 
                // This shouldn't be printed. But it gets printed because of ";" after the "if" control structure.
                // THIS IS A BUG in the code!
                // Except one, every control structure won't have a ";".
            }
        }
    }
}

