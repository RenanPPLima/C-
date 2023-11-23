using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima; // can be transmitted by inheritance.
        int VelocidadeAtual; // private attribute.

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) { // this method is encapsulated.

            // return VelocidadeAtual = Math.Min(VelocidadeMaxima, Math.Max(0, VelocidadeAtual + delta)); // FROM Renanzeira.

            int novaVelocidade = VelocidadeAtual + delta;
            if (novaVelocidade < 0) {
                return VelocidadeAtual = 0;
            }
            if (novaVelocidade > VelocidadeMaxima) {
                return VelocidadeAtual = VelocidadeMaxima;
            }
            return VelocidadeAtual = novaVelocidade;
        }

        public virtual int Acelerar() { // (2)
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro // (1)
    {
        public Uno() : base(200) {
        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350) {
        }

        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        public new int Frear() { // (3)
            return AlterarVelocidade(-15);
        }
    }


    internal class Heranca
    {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro (Polymorphism)...");
            Carro carro3 = new Ferrari(); // Polymorphism (Type Carro - new Object Ferrari).
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear()); // (4)
            Console.WriteLine(carro3.Frear()); // (4)

            Console.WriteLine("Uno com tipo Carro (Polymorphism)...");
            carro3 = new Uno(); // Polymorphism (carro3, now is UNO).
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}

// (1)
// Since I don't have a default constructor,
// I have to do this (create a new one using the father's / base constructor).
// If I had a default constructor, I wouldn't need to call the BASE constructor.
//
// (2) Key-Word VIRTUAL: It means that this methods can be overridden by inheritance.
//
// (3) Using the key-word "NEW" instead of OVERRIDE, it means that you're hiding the father's method.
//
// (4) Here, it inherited the method FREAR from CARRO, not from FERRARI.
//     Our variable type here is "CARRO", so that's why it invoking the method from CARRO.
//
//     If I created a variable type FERRARI (Ferrari carro3 = new Ferrari();),
//     it would call "FREAR" from FERRARI, not from CARRO.
//
//     WE HAVE TO BE CAREFUL HERE, because we can trigger different methods!
//
//     If you don't explicity declare a constructor in the inherited class, it will implicitly call the father's class.
//
// (5) Basically, in this case we have 3 ways of Polymorphism: Method Overloading, Method Overriding and Method Hiding.

// This topic continues on CONSTRUTOR THIS (take a look there).