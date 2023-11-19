namespace CursoCSharp.EstruturasDeControle
{
    internal class UsandoContinue
    {
        public static void Executar() {
            int interval = 50;
            Console.WriteLine("Even Numbers between 1 and {0}?", interval);
            for (int i = 1; i <= interval; i++) {
                if (i % 2 == 1) { continue; } // If modulo operation is = 1, it means the number is ODD.
                Console.WriteLine(i);         // That's why we must use "continue" because the expression will be false
                                              // after the first or second execution and the loop out stop.
            }
            /* 
               if (i % 2 == 1) { continue; } ---> Here's the idea: 
               IN THIS CASE, I could also do this (i % 2 != 1) without using "continue".

               When having a Modulo operation, if I use (variable % 2), I'll always have a return of 0 or 1.
               Modulus works only with integers/whole numbers. So, for example: If I have (47 % 2).
               The return will be 1, because (47 % 2) is the same as (23.5 x 2).
               
               So, since it works with whole numbers, the calculation will be (23 x 2 = 46).
               That's why the Modulo return will be 1.

               IMPORTANT: In order to get ODD or EVEN numbers, always go with (variable % 2),
               because for every number, the return will be 0 or 1.
            */

            for (int i = 2; i <= interval; i+= 2) {
                Console.WriteLine(i);
            } // This would be a more appropriate way of doing it (no need to use conditionals and stuff...)
        }
    }
}