using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaFor
    {
        public static void Executar() {
            // First we'll create a determinate WHILE loop.
            // Using WHILE we have the 3 necessary parts in different places.
            // (1) Variable declaration; (2) Boolean expression; (3) Increment or Decrement.

            int idx = 1;
            while (idx <= 10) {
                Console.WriteLine($"WHILE: The index value is: {idx}.");
                idx += 2;
            }

            // That's why FOR is more appropriate, because we have these 3 parts inside the FOR structure:
            for (int idx2 = 3; idx2 <= 15; idx2 += 3) { // DON'T FORGET THE STRONG TYPING LANGUAGE (INT idx2...)
                Console.WriteLine("FOR: The idex2 value is: {0}.", idx2);
            }// NOT ALWAYS we need the 3 parts to make a FOR loop.

            double sum = 0;
            string input;
            Console.Write("Inform the number of students: ");
            input = Console.ReadLine();
            int.TryParse(input, out int numberOfStudents);

            for (int i = 1; i <= numberOfStudents; i++) {
                Console.Write("Inform the Student's {0} Grade: ", i);
                input = Console.ReadLine();
                double.TryParse(input, out double currGrade);

                sum += currGrade;

            }
            double average = numberOfStudents > 0 ? sum / numberOfStudents : 0;
            Console.WriteLine("The class grade average is: {0}", average);

            /* MY CODE was Unfinished, but I put some effort here to make it work. */
            double sum2 = 0;
            string input2;
            Console.Write("Inform the number of Students (2): ");
            input2 = Console.ReadLine();
            int.TryParse(input2, out int numberOfStudents2);

            for (int i2 = 1; i2 <= numberOfStudents2; i2++) {
                Console.Write("Inform the Student #{0} Grade (2): ", i2);
                string studentGrade = Console.ReadLine();
                int.TryParse(studentGrade, out int currentGrade);

                sum2 = sum2 + currentGrade;
            } 
            double average2 = numberOfStudents2 != 0 ? sum2 / numberOfStudents2 : 0;
            Console.WriteLine("The class average2 is: {0}", average2);

            // WE CAN ALSO START FROM THE LAST STUDENT TO THE FIRST ONE:

            double sum3 = 0;
            string input3;
            Console.Write("Inform the number of Students (3): ");
            input3 = Console.ReadLine();
            int.TryParse(input3, out int numberOfStudents3);

            for (int i3 = numberOfStudents3; i3 >= 1; i3--) { // *** HERE'S THE DIFFERENCE
                Console.Write("Inform the Student #{0} Grade (3): ", i3);
                string studentGrade = Console.ReadLine();
                int.TryParse(studentGrade, out int currentGrade);

                sum3 = sum3 + currentGrade;
            }
            double average3 = numberOfStudents3 != 0 ? sum3 / numberOfStudents3 : 0;
            Console.WriteLine("The class average3 is: {0}", average3);
        }

    }
}






