using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente // TRY changing the name from CLASS to STRUCT and check the output.
    {
        public string Nome; // string is class in C#.
        public int Idade; // int is a struct.
    }


    internal class ValorVsReferencia
    {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"Atribuição por VALOR ---> Número: {numero}. Cópia Número: {copiaNumero}");

            numero++;
            Console.WriteLine($"numero++ ---> Número: {numero}. Cópia Número: {copiaNumero}");


            Dependente dependente = new(); // or new Dependente();
            dependente.Nome = "Beto";
            dependente.Idade = 20;

            Dependente copiaDep = dependente; 
            Console.WriteLine($"\n{dependente.Nome}. Cópia: {copiaDep.Nome}");
            Console.WriteLine($"{dependente.Idade}. Cópia: {copiaDep.Idade}");

            // The copy has the 2 attributes, that's why I can use "copiaDep.Nome" and "copiaDep.Idade".

            // Thereby, this is a HEAP MEMORY TYPE (CLASS), SO THEIR VALUES WILL BE BY REFERENCE.


            copiaDep.Nome = "Renato"; // Here, it should only change the value of the COPY. But, it's by REFERENCE.
            dependente.Idade = 27; // Here, also by REFERENCE!!! Because it's an instance (Heap Memory - CLASS).

            Console.WriteLine($"\n{dependente.Nome}. Cópia: {copiaDep.Nome}");
            Console.WriteLine($"{dependente.Idade}. Cópia: {copiaDep.Idade}");
        }
    }
}

// Remembering how to create an instance (2 ways using default constructor):

//  (1) Like a JS Object:
//
//      var dependente = new Dependente {
//          Nome = "Beto",
//          Idade = 20
//      };
//
//
//  (2) Like seen here in C#:
//
//      Dependente dependente = new(); // or new Dependente();
//          dependente.Nome = "Beto";
//          dependente.Idade = 20;
//      }
