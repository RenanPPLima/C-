using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class InterpolacaoDeStrings
    {
        public static void Executar() {
            string name = "Gamer Laptop";
            string brand = "Lenovo";
            double price = 5700.00;

            Console.WriteLine("The " + name + " from " 
                + brand + " costs " + price + ".");

            // This is like a TEMPLATE STRING from JS.

            // 1st way:
            Console.WriteLine("The {0} from {1} costs {2}.", 
                name, brand, price); // This is like an Array, we use indexes, starting from zero.

            // 2nd way:
            Console.WriteLine($"The {name} from {brand} costs {price}.");

            // We can also do this:
            Console.WriteLine($"5 + 7 = {5 + 7}.");
        }
    }
}
