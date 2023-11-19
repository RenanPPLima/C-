using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar() {
            int wholeNumber = 10;
            double decimals = wholeNumber;
            // In this case an integer can be converted into a "double", no problem.
            // The compiler didn't demand that I explicitly commanded the conversion.
            Console.WriteLine(decimals);

            // C# Type CASTING/CAST:
            // Type casting is when you assign a value of one data type to another type
            // (1) Implicit and (2) Explicit Casting.

            double grade = 9.7;

            // int truncatedGrade = grade; ---> IMPLICIT CONVERSION.
            // Não é possível converter implicitamente tipo double em int.
            // Existe uma conversão explícita (há uma conversão ausente?). --> So, it's possible to convert: Explicitly.

            int truncatedGrade = (int)grade; // EXPLICIT CONVERSION.
            // In this case the conversion will simply ignore the decimals.
            Console.WriteLine("Truncated Grade: {0}", truncatedGrade);
            Console.WriteLine($"Truncaded Grade: {truncatedGrade}");


            // (1) // CONVERTING A STRING INTO AN INTEGER:
            Console.Write("Type in your age: ");
            string ageString = Console.ReadLine();
            int ageInteger = int.Parse(ageString);
            Console.WriteLine("Age inserted {0}", ageInteger);
            
            // (2) // This is another possibility:
            ageInteger = Convert.ToInt32(ageInteger);
            Console.WriteLine("Result: {0}", ageInteger);

            // Both (1) and (2), if have a wrong input (a decimal or characters) an ERROR will be generated.

            // This is how we can fix this problem
            // (3):
            Console.Write("Type in the first number: ");
            string word = Console.ReadLine();
            int number1;
            Console.WriteLine(int.TryParse(word, out number1)); 
            Console.WriteLine("The first result is: {0}", number1);
            // TryParse = try to convert the string into a number. It returns a boolean.
            // After using this Method, if the conversion wasn't possible (false), it assigns "ZERO" to my variable.

            // (4):
            // Also, this is a way of optimizing the code:
            Console.Write("Type in the second number: ");
            Console.WriteLine(int.TryParse(Console.ReadLine(), out int number2));
            Console.WriteLine("The second result is: {0}", number2);

            // So, with solutions (3) and (4), being (4) way more optimized, it doesn't generate an error like (1) and (2). 

            /*
                To finish these examples, here's the idea:
                When there is a chance of losing information, C# won't allow implicit conversions (it won't do it automatically).
                That's why we need the TYPE CASTING.
                Also, we have the ".Parse()" and ".TryParse()" Methods:
                The first one will generate an error if the user input is different from what's requested.
                The second one won't generate this error. It's like you're assuming that it can happen, so better be prepared.
                Also, the second one returns a Boolean ---> we can treat this return with control structures.
                I would say that using ".Parse()" or ".TryParse()" would depend on the application that you're building.
                That is, having ".Parse()" generating an error, may be a good thing, depending on the situation.
            */
        }
    }
}