using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class UsandoBreak
    {
        public static void Executar() {
            Random random = new Random();
            int number = random.Next(1, 51);
            Console.WriteLine($"The number we want is: {number}");

            for (int i = 1; i <= number; i++) { // To print only the correct number, not the loop needed to find the number.
                if (i == number) {
                    Console.WriteLine("Found the number ({0})", i);
                }
            }

            for (int i = 1; i <= number; i++) { // To print the whole loop needed to find the number.
                if (i == 1) {
                    Console.WriteLine("Now, printing the whole Loop");
                }
                Console.WriteLine(i);
            }

            // Now the instructor will show when to use BREAK.
            for (int i = 1; i <= 50; i++) {
                Console.Write("{0} is the number we want? ", i);
                if (i == number) {
                    Console.WriteLine("Yes!");
                    break; // See notes below. But "break", breaks the LOOP, not "if" or "else".
                } else {
                    Console.WriteLine("Nope!");
                }
            }
        } // In this case, the instructor "provoked" this situation. He used "i <= 50",
          // so "else" gets executed even after finding the random number.
          // In this case, we must "BREAK" before "ELSE".
          // But, like I said, this is a "provoked" situation.
          // It is easily solved having "i <= number", like I did before,
          // even "ELSE" is not necessary the way I did before.

        // SOMETHING VERY IMPORTANT HERE: "BREAK" is not associated to the "IF" block, but to the LOOP (FOR in this case).
        // SO, BREAK IS USED FOR LOOPS!!! NOT FOR CONDITIONALS LIKE "IF", "ELSE", "ELSE IF".
        // When using it, "BREAK", BREAKS FROM THE LOOP!!! NOT THE CONDITIONAL "IF", "ELSE" IN THIS CASE!.
    }
}
