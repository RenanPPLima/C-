using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecaoSET // (1) (2)
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
            var livro = new Produto("GoT", 49.9);

            var carrinhoDeCompra = new HashSet<Produto>();
            carrinhoDeCompra.Add(livro);

            HashSet<Produto> comboPromocao = new HashSet<Produto> {
                new Produto("Camiseta", 29.9),
                new Produto("8ª Temporada GoT", 99.9),
                new Produto("Poster", 10),
            };

            Console.WriteLine(carrinhoDeCompra.Count); 

            carrinhoDeCompra.UnionWith(comboPromocao); // união de conjunto (carrinhoDeCompra + comboPromocao)
            Console.WriteLine(carrinhoDeCompra.Count);

            // carrinhoDeCompra.RemoveAt(2); ---> (3)


            foreach (var item in carrinhoDeCompra) {
                // Console.Write(carrinhoDeCompra.IndexOf(item)); ---> (3)
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinhoDeCompra.Count); // (4)
            carrinhoDeCompra.Add(livro); // (4)
            Console.WriteLine(carrinhoDeCompra.Count); // (4)
        }
    }
}

// Basically SET is the "opposite" of a LIST:
// (1) SET (HashSet): It's not an indexed structure.
// (2) SET doesn't allow repetition.
// (3) ---> Can't have this 'cuz it's not an indexed structure.

// (4)
// Since SET doesn't allow repetition, the code should generate an error message,
// once I'm trying to add the same object twice, right? 
//
// Well, it doesn't generate the error in the code, but if I check what's printed, in fact it doesn't add.
//
// And, actually, this makes sense when thinking about an actual Online Store Cart. You can't add the same item twice,
// but you can change the number of items.