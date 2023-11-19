using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecaoLIST
    {
        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco) {
                this.Nome = nome;
                this.Preco = preco;
            }
        }

        public static void Executar() {
            Produto livro = new Produto("GoT", 49.9);

            var carrinhoDeCompra = new List<Produto>(); // (1) (2)
            carrinhoDeCompra.Add(livro);

            List<Produto> comboPromocao = new List<Produto> { // I can ADD many objects at the same time.
                new Produto("Camiseta", 29.9),
                new Produto("8ª Temporada GoT", 99.9),
                new Produto("Poster", 10),
            };

            Console.WriteLine(carrinhoDeCompra.Count); // livro

            carrinhoDeCompra.AddRange(comboPromocao);
            Console.WriteLine(carrinhoDeCompra.Count); // livro + comboPromocao added.

            carrinhoDeCompra.RemoveAt(3);
            // carrinhoDeCompra.RemoveAt(4); It generates and error: This index doesn't exist.

            foreach (var item in carrinhoDeCompra) {
                Console.Write(carrinhoDeCompra.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");

                var lista = new List<string>(); // I CAN ALSO CREATE A GENERIC LIST.
                lista.Add("renan");
                lista.Add("Zórzi");
            }

            // carrinhoDeCompra.Add(livro); (3)
        }
    }
}



// Lists in C# are very similar to lists in Java.
// A list is an object which holds variables in a specific order.
// The type of variable that the list can store is defined using the generic syntax.
//
// https://www.geeksforgeeks.org/c-sharp-list-class/
//
// (1) The instructor says that having a HOMOGENEOUS LIST is better.
// That is, not mixing data types / different data inside it.
// Like: in the same LIST, storing Produto, Cliente, Imposto, etc...
// This way you won't have a predictable object. That's why it's better not mixing this data.
//
// Arrays are very good when it comes to performance, because it already stores
// a determined amount of items. So, it's easier to manage the data inside it.
// However, since it's a STATIC structure, you must know already the data you'll store inside it.
// In order to have a dynamic structure, you can't use Array. You can use LIST.
//
// (2) Different from Arrays, the LIST is dynamic. You can add more items inside it.
//
// (3) LIST accepts data repetition. In this example, we can add "livro" again, despite being the same object.
//
// In this class we saw: A Generic LIST; LIST is a dynamic structure; LIST takes repetitions; LIST is an indexed structure.

