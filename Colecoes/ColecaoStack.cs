using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecaoStack // LAST IN, FIRST OUT.
    {
        public static void Executar() {
            var pilha = new Stack();

            // (1)
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push("Renan");
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.WriteLine($"{item}");
            }

            // (2) (Pop removes the last element):
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            Console.WriteLine(pilha.Peek()); // Remember: Peek doesn't remove elements.
            Console.WriteLine(pilha.Count); // Remember: COUNT is not a method, it's an attribute.
        }
    }
}

// (1) Last in, First out: That is, the output after the "Push" method will be:
// 3.14, Renan, true, a, 3. That's why it's Last IN, First OUT.
// The POP method will remove from the Stack the element "3.14" (Last in, First Out).
