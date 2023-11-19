using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecaoARRAY // ARRAY IS NOT A COLLECTION!!! É uma "MATRIZ". Mas, ao pegar a página em inglês, ele traduz Matrizes para ARRAY (???).
                                // Então, Arrays, em português = Matrizes. CRAZY!!! Tenho que confirmar isso.  
    {
        public static void Executar() {
            // string[] = string array.

            string[] alunos = new string[5]; // (1), (2), (3) (4)
            alunos[0] = "Renan";
            alunos[1] = "Marcio";
            alunos[2] = "Daniela";
            alunos[3] = "Rafael";
            alunos[4] = "Carla";
            // alunos[5] = "teste"; ---> Ocorreu um erro: Index was outside the bounds of the array.
            // C# doesn't indicate a problem when coding, but this error occurs in the output / when executing.

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas) {
                somatorio += nota;
            } // We can also use "FOR" Loop in order to do the same thing, but FOREACH is way better. 

            Console.WriteLine("Quantas notas no total para calcular a média? {0}", notas.Length); // (5)
            Console.WriteLine("Somatório Total = {0}", somatorio);

            double mediaNotas = somatorio / notas.Length;
            Console.WriteLine("Média das notas (37,9 / 5) = {0}", mediaNotas);


            if (mediaNotas >= 7) { Console.WriteLine("A turma está aprovada!"); } else { Console.WriteLine("A turma está reprovada!"); }

            char[] letras = { 'A', 'r', 'r', 'a', 'y', 'T', 'e', 's', 't' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}


// (1) This Array has 5 positions and its identifier is "alunos".
//
// (2) Array is a homogeneous structure. In other words, once you declare a string Array,
//     you can't mix with different type of values (like numbers, bools, etc...).
//
// (3) Array is a STATIC structure. It doesn't grow or shrink. It will always have those number of positions.
//      * I can, however, use the same variable to declare a NEW Array with more or less positions,
//      * unless, of course, my variable is not a CONST.
//
// (4) Array is an indexed structure.
//
// So, Arrays have 3 major qualities: They are HOMOGENEOUS, STATIC and INDEXED.
// Also, Arrays are very good when it comes to performance, because it already stores
// a determined amount of items. So, it's easier to manage the data inside it.
// However, since it's a STATIC structure, you must know already the data you'll store inside it.
// In order to have a dynamic structure, you can't use Array. You can use LIST.
//
// (5) LENGTH: It's an ATTRIBUTE of Arrays, NOT a method. That's why we don't need "()".
// Array IS NOT A COLLECTION! That's why we don't use "COUNT"!!!!.
