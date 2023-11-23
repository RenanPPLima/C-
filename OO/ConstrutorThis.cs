using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) { // (1)
            Console.WriteLine($"Cachorro {nome} foi inicializado.");
        }

        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }

        public override string ToString() {  // (2)
            return $"{Nome} tem {Altura}cm de altura.";
        }
    }
    // CRIAR MAIS UM ANIMAL COMO EXEMPLO.
    internal class ConstrutorThis
    {
        public static void Executar() {
            Cachorro spike = new Cachorro("Spike");
            Cachorro max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}

// (2) If I comment this method, it would be printed "CursoCSharp.OO.Cachorro".
//     Here, we're OVERRIDING the C# itself method ToString(). That's why, by default, it prints "CursoCSharp.OO.Cachorro".
//     We don't want, in this case, to use the default ToString(), that's why the OVERRIDE.
//     Also, that's why, we don't have a ToString() method explicit in the code.
//
// (1) Conforme explicação do Renanzeira, eu estava pensando o caminho inverso:
//     O caminho é o seguinte:
//     1º - Cachorro (string "SPIKE") SETA o nome do base(nome).
//     2º - Do base, agora - base("SPIKE") - ele sobe para o construtor Animal(string nome) {Nome = nome}.
//     3º - Dessa forma, salva o nome do Cachorro no atributo string Nome { get; set; }.
//     Esse é o caminho da execução.
//     A gente passa o "nome" para o "base" e não o contrário. Ou seja, a gente não "puxa" do base o nome.
//
//     Mas por que então usar o atributo "Nome" de Animal e não simplesmente criar uma variável direto na Classe Cachorro?
//     Por que TODOS os Animais devem ter um nome!
//
//     Porque então o Atributo "Altura" está somente dentro da Classe Cachorro?
//     Pq somente o Cachorro terá o atributo Altura!
//     Os outros Animais não terão "Altura" como atributo.
// 
// (3) Exercício: Criar outro Animal como exemplo, usando o Atributo da Classe pai (Nome), e um atributo próprio que não seja "Altura".
//
//
//

