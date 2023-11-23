using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    interface Teste
    {
        bool Test(string a); // Herança já tem a lógica pronta. Interface não. 
    }                       // Herança = mãe (só tem uma). Interface = assinar contratos (podemos assinar vários).

    interface Teste2 : Teste // (5)
    {
        string Test2(string b);
    }

    interface OperacaoBinaria // (2)
    {
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria, Teste // (4)
    {
        public int Operacao(int a, int b) { // (3)
            return a + b;
        }

        public bool Test(string nomeDoTeste) {
            if (nomeDoTeste == "Hello") { return true; } else { return false; }
        }
    }

    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b) {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";

            foreach (OperacaoBinaria op in operacoes) {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return resultado;
        }
    }


    internal class Interface // (1)
    {
        public static void Executar() {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.ExecutarOperacoes(10, 12));

            Soma soma = new Soma();
            Console.WriteLine(soma.Test("Hello"));
        }
    }
}

// (1) In C#, an interface is similar to abstract class. However, unlike abstract classes,
//     all methods of an interface are fully abstract (method without body).
//
//     Also, using interface, the class can have multiple interface implementations.
//     I.e., we can have many classes that implement an interface (different from Inheritance).
//     Or, many interfaces implemented in one class.
//
//     Interface, in C#, is a code structure that defines a contract between an object and its user.    
//     It contains a collection of semantically similar properties and methods
//     that can be implemented by a class or a struct that adheres to the contract.
//
//     Why And When To Use Interfaces?
//  a) To achieve security - hide certain details and only show the important details of an object (interface).
//  b) C# does not support "multiple inheritance" (a class can only inherit from one base class).
//    However, it can be achieved with interfaces, because the class can implement multiple interfaces.
//    Note: To implement multiple interfaces, separate them with a comma.
//
// (2) By default the methods of an Interface are all ABSTRACT and PUBLIC. That's why we don't need to use the key-words.
//     Also, we can't define a body to the methods of the interfaces.
//
// (3) Interfaces Members ARE always PUBLIC and ABSTRACT.
//
// (4) When implementing an INTERFACE, the Class MUST implement all the methods of that interface.
//     Also, like seen there, we can implement more than one interface in the same class.
//
// (5) We can also have an INTERFACE inheriting from another. In this case,
//     the Class that will implement the interface MUST also implement the methods from the father interface.

