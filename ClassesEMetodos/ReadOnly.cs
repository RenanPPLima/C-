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
    public class Client
    {
        public string Name;
        readonly DateTime Birth;
        public readonly string SurName;
        // To set an immutable value (a const) when creating an instance, we have to use "readonly".
        // We can't use "const", because C# demands that you assign something to a "const" when declaring it.

        //  const int x = 100; -----> this is ok.
        //  const int y; ------> error.


        public Client(string name, DateTime birth) {
            this.Name = name;
            this.Birth = birth;
            this.SurName = "Renan";
        }
        
        public string GetBirthDayDate() {
            return String.Format("{0}/{1}/{2}", Birth.Day, Birth.Month, Birth.Year);
        }
    }


    internal class ReadOnly
    {
        public static void Executar() {
            var newClient = new Client("Ana Silva", new DateTime(1987, 5, 22)); // DateTime syntax (int year, int month, int day).
            Console.WriteLine($"{newClient.Name}: {newClient.GetBirthDayDate()}");
            Console.WriteLine("{0}: {1}", newClient.Name, newClient.GetBirthDayDate());
            Console.WriteLine(newClient.SurName);
            // newClient.SurName = "Zore"; ----> ERROR. Because it's ReadOnly.
        }
    }
}
