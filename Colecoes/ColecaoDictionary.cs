using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecaoDictionary // THE SAME AS "MAP" in JAVA. (1)
    {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: {0}", filmes[2004]);
                Console.WriteLine("2004: " + filmes[2004]); // This is another way of interpolation.
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
                // The idea of using "GetValueOrDefault()" is that it doesn't generate an error if
                // the key doesn't exist.
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia")); // Returns a BOOL.

            Console.WriteLine("Removeu a chave e valor? " + filmes.Remove(2004));
            // REMOVE returns a BOOL if the method was able to REMOVE the item. I.e., if this KEY exists, it removes it and returns TRUE.
            // If not, returns false (and, obviously, doesn't remove anything, because it doesn't exist).

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine("Chave 2006: " + filme2006);

            filmes.TryGetValue(2016, out string filme2009);
            Console.WriteLine("Chave 2009: " + filme2009);

            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach (var filme in filmes) { // Here we're using inference for: "KeyValuePair<int, string>"
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}

// (1) The same as MAP in JAVA:
// It's a Data structure that you can access by Key and Value.
// Also, it takes repetition only in THE VALUE, NOT THE KEY.
// So, it's similar to "HashSet" for the KEY and a "List" for the VALUE.
