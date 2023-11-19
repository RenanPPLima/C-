using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaForEach
    {
        public static void Executar() {
            // The instructor says it's a very used structure.
            // Also, the difference from "FOR" is that, when using "for", we usually just want to iterate over/through the values inside it.

            string word = "Hello!";

            foreach (var letter in word) {
                Console.WriteLine(letter);
            }

            var students = new string[] { "Ana", "Bia", "Leo" };
            foreach (string student in students) {
                Console.WriteLine(student);
            }
            // The idea of ForEach is to simply iterate over the elements, from the first to the last one.
            // This is better than FOR because using ForEach, you don't have to create an expression (boolean),
            // to define a variable and increment or decrement. It's way simpler if you just want to "see" the values of the element.
        }
    }
}
