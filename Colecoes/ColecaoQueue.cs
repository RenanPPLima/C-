using System;
using System.Collections; // So I can create a NON-GENERIC Queue();
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecaoQueue // Queue is FI/FO = First in, First Out (like a line in a bank).
    {
        public static void Executar() {
            var fila = new Queue<string>(); // "using System.Collections.Generic;"

            fila.Enqueue("Fulano"); // Enqueue = Enfileirar.   (1)
            fila.Enqueue("Ciclano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); // (2)
            Console.WriteLine(fila.Count); // Count is an ATTRIBUTE of the collections, not a method. No need "()".

            Console.WriteLine(fila.Dequeue()); // Dequeue = Desenfileirar. Removes the object at the beginnning. (3)
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue(); // NOT GENERIC. I have to add "using System.Collections;"   (4)
            salada.Enqueue(32);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item")); // False. Because it's case sensitive!!!! Careful with that.

            Console.WriteLine(salada.Contains("Item")); // True

        }
    }
}

// (1) Enqueue():
// Adds an object to the END of the Queue.
//
// (2) Peek():
// Description: Returns the object at the beginning of the Queue <T> without removing it.
// In other words, the first object to GET OUT of the queue (FI/FO).
//
// (3) Dequeue():
// Removes and returns the object at the beginning of the Queue<T>.
//
// (4) Queue characteristics: Accepts repetition, it's a dynamic collection and takes heterogeneous values.