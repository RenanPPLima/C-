using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso2;

        public Comida(double peso2) { // Parameterized Constructor.
            Peso2 = peso2;
        }

        public Comida() { // Default Construtor.
        } 
    }

    public class Feijao2 : Comida
    {
        public Feijao2(double peso2) : base(peso2) {
        }
    }

    public class Arroz2 : Comida
    {
    }

    public class Carne2 : Comida
    {
    }

    public class Pessoa2 // (1)
    {
        public double Peso2;

        public void Comer(Comida comida) {
            Peso2 += comida.Peso2;
        }
    }

    internal class PolimorfismoPt2
    {
        public static void Executar() {
            Feijao2 ingredienteUm = new Feijao2(0.3); // Using Parameterized Constructor

            Arroz2 ingredienteDois = new Arroz2(); // Using Default Constructor
            ingredienteDois.Peso2 = 0.25;          // I have to set the value here, different from Feijao2.
            Carne2 ingredienteTres = new Carne2(); // Using Default Constructor
            ingredienteTres.Peso2 = 0.3;

            Pessoa2 cliente2 = new Pessoa2(); // (1)
            cliente2.Peso2 = 80.2;

            cliente2.Comer(ingredienteUm);
            cliente2.Comer(ingredienteDois); // Can't use chainable methods here, because all of them are VOID.
            cliente2.Comer(ingredienteTres);

            Console.WriteLine("Agora o Peso do Cliente é: {0}kg", cliente2.Peso2);
        }
    }
}

// (1) The instructor gives an example for not having a reuse of code despite having the same method / attribute:
//     Pessoa IS NOT Comida. So, it's not advised AT ALL forcing an inheritance here, because it doesn't make sense.
//     We could inhrerit from Comida, we would have a reuse of code. But, like said, Pessoa is not Comida,
//     thereby, it's better to make the method / attribute again inside Class Pessoa, so the code doesn't get really confusing.
