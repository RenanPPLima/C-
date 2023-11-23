using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO // I MADE A PART 2 OF THIS EXERCISE, SO WE CAN SEE THE DIFERENCE, TAKE A LOOK THERE!
{

    public class Feijao
    {
        public double Peso;
    }

    public class Arroz
    {
        public double Peso;
    }

    public class Carne
    {
        public double Peso;
    }

    public class Pessoa
    {
        public double Peso;

        public void Comer(Feijao feijao) {
            this.Peso += feijao.Peso;
        }
        
        public void Comer(Arroz arroz) {
            this.Peso += arroz.Peso;
        }
        
        public void Comer(Carne carne) {
            this.Peso += carne.Peso;
        }

        public override string ToString() { // Just for fun.
            return "Peso do Cliente após refeição: ";
        }

    }

    internal class Polimorfismo
    {
        public static void Executar() {
            Feijao ingrediente1 = new Feijao(); // Default constructor from Class Feijao and so on...
            ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;

            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2); // Can't use chainable methods here, because all of them are VOID.
            cliente.Comer(ingrediente3);

            Console.Write(cliente);      // Just playing with "Override ToString()" method.
            Console.WriteLine(cliente.Peso);
            Console.WriteLine("Agora o Peso do Cliente é: {0}kg", cliente.Peso);
        }
    }
}
