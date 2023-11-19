using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// In some situations some data type are not so good defined as a string or int.
// If I want to represent the Week Days: If I use strings, the user can input "sabado" with no accent,
// or "SExta" with different cases...
// Days of the Week are a defined data set (conjunto de dados), I could represent with ints.
// However, what if the user inputs 16? There's no such weekday.
// So, in this case, we can create enums - enumerations (enumerações).

namespace CursoCSharp.ClassesEMetodos
{
    internal class EnumExemplo
    {
        public enum GeneroFilme { Acao, Aventura, Terror, Animacao, Comedia }; // They aren't STRINGS!
        // syxtax: Pascal Case and no accents.
        // We can only assign integers to the enums.

        public class Filme
        {
            public string Titulo;
            public GeneroFilme Genero;
        }


        public static void Executar() {
            int id = (int) GeneroFilme.Animacao;
            Console.WriteLine(id); // It returns the index, kind of like an Array, but it's different.

            var familyMovie = new Filme();
            familyMovie.Titulo = "Sharknado";
            familyMovie.Genero = GeneroFilme.Comedia;

            Console.WriteLine("{0} é um filme de {1}.", familyMovie.Titulo, familyMovie.Genero);

            var myTest = (GeneroFilme) 1;
            Console.WriteLine(myTest); // This is how I can access the value based on the index.
        }
    }
}
// We can use ENUMS to set a predefined data, so we can use it later in the attributes of the instance.
// Like done above, we have a predefined movie genres, so we used these values to set them on "new Filme".
// OR we can do something like this:

// enum year
// {
//    // items of the enum
//    January,    //1
//    February,   //2
//    March,      //3
//    April,      //11
//    May,        //12
//    June        //13
// }

// https://www.loginradius.com/blog/engineering/enum-csharp/

// We can assign different values for the values inside the enums, like:
// public enum GeneroFilme { Acao = 20, Aventura = 12, Terror = 56, Animacao = 7, Comedia = 19 };

// We can assign one value to two enum names: (but do I access both of them by their index??????)
//
// enum color
// {
//    Blue = 1,
//    Green = 1,
//    Yellow = 2
// }

