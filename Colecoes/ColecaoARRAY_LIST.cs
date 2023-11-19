using System;
using System.Collections; // I have to declare it, or take "Generic" out from the line below.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecaoARRAYLIST
    {
        public static void Executar() {
            var arrayList = new ArrayList {
                "Palavra",
                32,
                true,
            };

            arrayList.Add(3.14); // double

            foreach (object item in arrayList) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}

// (1) In C#, the ArrayList is a non-generic collection of objects whose size increases dynamically.
// It is the same as Array except that its size increases dynamically.
// An ArrayList can be used to add unknown data where you don't know the types and the size of the data.
