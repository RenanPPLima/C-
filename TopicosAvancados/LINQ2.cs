using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class LINQ2
    {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Zorzi", Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8},
                // new Aluno() {Nome = "Fulano", Idade = 45, Nota = 10.0}
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome}: {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano")); // (1)
            if (fulano == null) {
                Console.WriteLine("The student is not registered!");
            } else {
                Console.WriteLine($"{fulano.Nome}: {fulano.Nota}");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"Ana 1 - Nota: {ana.Nota}");

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));
            if (sicrano == null) {
                Console.WriteLine("The student is not registered!");
            } else {
                Console.WriteLine($"{sicrano.Nome}: {sicrano.Nota}");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine("Ana 2 - Nota: {0}\n", outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3); // List partition.
            foreach (var aluno in exemploSkip) {
                Console.WriteLine(aluno.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine("A maior nota é: {0}.", maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine("A menor nota é: {0}.", menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);

            var mediaAlunosAprovados = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaAlunosAprovados);
        }
    }
}
// (1) Here, we don't have "fulano". So, using "SingleOrDefault", the default return of an OBJECT is NULL.
