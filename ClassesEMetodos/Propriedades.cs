using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
    // VERY IMPORTANT: PROPERTY = ATTRIBUTE WITH GET and/or SET!!!
{   // According to the instructor, this is a smarter way of implementing GET and/or SET:


    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;

        public string Nome {
            // (1) The following GET and SET are implemented "by hand".

            // DON'T USE semicolon ( ; ) after " } " in GET and SET.
            // The line below shows an example of how to TREAT the attribute and one of the reasons to use "private" ones.
            get { return "Optional: " + nome; }

            set { nome = value; } // "value" is a reserved key-word in C# that refers to "SET", so it gets assigned to the attribute.
        }


        // (2) Auto-Implemented Properties (GET and SET, so you don't have to it "by hand" every f. time):

        public double Preco { get; set; }
        // I can declare this and later implement a logic to "SET".


        // (3) ReadOnly (kind of self-explanatory):
        // THIS IS A READONLY PROPERTY BECAUSE WE DON'T HAVE "SET" IMPLEMENTED.

        public double PrecoComDesconto { 
            get => Preco - (desconto * Preco); // This is a Lambda ("=>").

            // Using Lambda in this case is the same as doing this:
            // get { return Preco - (desconto * Preco); }
        }

        public CarroOpcional() {
            // default constructor
        }

        public CarroOpcional(string nome, double preco) {
            this.Nome = nome;
            this.Preco = preco;
        }
    }


    internal class Propriedades // *** Propriedade = atributo com get e/ou set! ***
    {
        public static void Executar() {
            var opt1 = new CarroOpcional("Ar Condicionado", 3_499.90);
            // opt1.PrecoComDesconto = 3000; ---> Error: ReadOnly. Because "set" wasn't implemented.

            var opt2 = new CarroOpcional();
            opt2.Nome = "Direção Elétrica";
            opt2.Preco = 2_349.90;

            Console.WriteLine(opt1.Nome);
            Console.WriteLine(opt1.Preco);
            Console.WriteLine("Price with discount: {0}", opt1.PrecoComDesconto);

            Console.WriteLine(opt2.Nome);
            Console.WriteLine(opt2.Preco);
            Console.WriteLine("Price with discount: {0}", opt2.PrecoComDesconto);
        }

    }
}


// (2) Auto-Implemented Properties concept:
// In C# 3.0 and later, auto-implemented properties make property-declaration
// more concise WHEN NO ADDITIONAL LOGIC IS REQUIRED in the property accessors.

// They also enable client code to create objects.
// When you declare a property as shown in the following example, the compiler creates a private,
// anonymous backing field that can only be accessed through the property's get and set accessors.
// In C# 9 and later, init accessors can also be declared as auto-implemented properties.

// (3) When you don't implement SET, the property automatically becomes ReadOnly.