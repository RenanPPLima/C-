using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade___Equals_e_GetHashCode
    {
        public class Produto2
        {
            public string Nome;
            public double Preco;

            public Produto2(string nome, double preco) {
                this.Nome = nome;
                this.Preco = preco;
            }

            public override bool Equals(object? obj) { // This is auto-implemented. Put mouse cursor over "Produto2" and CTRL + . (DOT)
                return obj is Produto2 produto &&
                       Nome == produto.Nome &&
                       Preco == produto.Preco;
            }

            public override int GetHashCode() {
                return HashCode.Combine(Nome, Preco);
            }
        }


        public static void Executar() {
            var p1 = new Produto2("Caneta", 1.89);
            var p2 = new Produto2("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2); // Output: FALSE. Yes, it's crazy. Very different from JS.
            // Here's the idea, we have 2 different spaces in memory in this case. So, they are different.

            Console.WriteLine(p3 == p2); // TRUE! Because they point to SAME space in memory.

            // So, when I use "==" I'm comparing MEMORY SPACE!!!!!!!

            Console.WriteLine(p1.Equals(p2)); // STILL FALSE! (Before implementing GETHASHCODE and EQUALS).

            // I have to make the code compare by VALUE not by MEMORY REFERENCE.

            // WE HAVE TO IMPLEMENT GETHASHCODE AND EQUALS so C# can check the values (it's a little confusing),
            // but the code can make this for us.
        }
    }
}
