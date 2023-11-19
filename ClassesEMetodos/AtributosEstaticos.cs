using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lembrando:
// public = outro namespace pode acessar
// static = não precisa criar um objeto para acessar o método
// void = sem retorno

namespace CursoCSharp.ClassesEMetodos
{
    internal class AtributosEstaticos
    {
        public class Produto
        {
            public string Nome;
            public double Preco;
            public static double Desconto = 0.1;

            public Produto(string nome, double preco, double desconto) { // parameterized constructor.
                this.Nome = nome; // No need to use "this", just following Beetools pattern.
                this.Preco = preco;
                Produto.Desconto = desconto;
            }

            public Produto() { 
                // default constructor
            }

            public double CalcularDesconto() {
                return Preco - Preco * Desconto;
            }
            
        }
        
        public static void Executar() {

            // Console.WriteLine(Produto.Desconto); ---> output: 0.1

            var produto1 = new Produto("Caneta", 3.2, 0.5);
            
            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.3,
                //Desconto = 0.3 --> If I uncomment this line, there will be an error.
            };
            
            Console.WriteLine("#1: Price with Discount ---> {0}", produto1.CalcularDesconto());
            Console.WriteLine($"#2: Price with Discount ---> {produto2.CalcularDesconto()}");
            
            //Console.WriteLine(Produto.Desconto); ---> output: 0.5

        }
    }
}
