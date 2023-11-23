using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T> // (1)
    {
        T valorPrivado; // attribute.

        public T Coisa { get; set; } // property.

        public Caixa(T coisa) { // pass a generic type to a constructor.
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor) { // pass a generic type to a method.
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor() {
            return valorPrivado;
        }
    }

    // Here's why having a generic class (inheritance, in this case).
    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0) {

        }
    }

    // (2)
    class CaixaProduto : Caixa<AtributosEstaticos.Produto>
    {
        public CaixaProduto() : base(new AtributosEstaticos.Produto()) {

        }
    }

    internal class Genericos
    {
        public static void Executar() {
            var caixa1 = new Caixa<int>(1_000);
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Método"));
            Console.WriteLine(caixa2.Coisa.GetType());

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
// (1) Here's the idea: we have the type "T". We can use it as a type for the variables and methods.
//     So, when we change it's type to "string", for example, it will change through the code also.
//
// (2) We can wrap the generics in two ways: 1 - when instantiating a new object; or, 2 - by inheritance.
