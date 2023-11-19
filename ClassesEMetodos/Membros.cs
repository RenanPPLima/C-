namespace CursoCSharp.ClassesEMetodos
{
    public class Membros
    {
        public static void Executar() {
            Pessoa fulano = new Pessoa(); // Pessoa = Type of the variable; fulano = the variable itself.
            fulano.Name = "Renato";
            fulano.Age = 21;

            Console.WriteLine($"{fulano.Name} is {fulano.Age} years-old.");
            // Can I do this without having to repeat this sentence for every person? YES!
            // Classes can also have Methods! Take a look at the class Pessoa.

            fulano.PrintIntroductionOnConsole();
            fulano.ResetPersonData();
            Console.Write("Fulano's Data Reset -----> ");
            fulano.PrintIntroductionOnConsole();

            if (fulano.Name == "" || fulano.Age <= 0) {
                Console.WriteLine("Please, check Name and Age input.");
            }

            Console.WriteLine();
            var siclano = new Pessoa(); // I can use VAR here, so the code gets the variable type by inference.
            siclano.Name = "Beto";
            siclano.Age = 44;
            var siclanoIntroduction = siclano.Introduction();
            // The instructor says it's way more useful to have the string return than using directly "PrintIntrocutionOnConsole".
            // Why? Because you are tied to print the information on the console. I.e., having the string return, you can do more with it.
            // For example:

            Console.WriteLine(siclanoIntroduction); // I can print it if I want, but also:
            Console.WriteLine(siclanoIntroduction.Length == siclano.Age);
            Console.WriteLine(siclanoIntroduction.Length == fulano.Age);

            // See? I can do more things with it.

        }
    }
}

// Class Pessoa is managed by REFERENCE.
//      var ciclano = new Pessoa();
//      ciclano.Name = "Renan";

//      var fulano = ciclano;
//      fulano.Name = "Cris";

//      Console.WriteLine(ciclano.Name); ----> output: Cris
//      Console.WriteLine(fulano.Name);  ----> output: Cris


// Type INT is managed by VALUE.
//      var precoProdutoA = 10;

//      var precoProdutoB = precoProdutoA;
//      precoProdutoB = 5;

//      Console.WriteLine(precoProdutoA); ----> output: 10
//      Console.WriteLine(precoProdutoB); ----> output: 5


// var fulanoSameRef = fulano;
// var fulanoCopy = fulano.GetCopy(); 

// Todos os modelos baixados do servidor são do tipo struct, pois essa memoria é menos custosa para gerenciar.
// A classe é mais custosa para gerenciar, por isso a escolha aqui na Beetools de usar o STRUCT.





