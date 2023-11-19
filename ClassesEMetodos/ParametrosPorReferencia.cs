using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosPorReferencia // Key-Words: REF and OUT = arumentos de entrada para a função.
    {
        public static void AtribuicaoPorValorA(int numero) {
            numero = numero + 1_000;
        }

        public static void AtribuicaoPorValorB(int numero) {
            numero = numero + 15;
        }

        public static void AlterarRef(ref int numero) {                     // We can't use Default Values for REF and OUT.
            numero = numero + 1_000;
        }

        public static void AlterarOut(out int numero1, out int numero2) {
            numero1 = 0; // I have to assign zero here, when using OUT. Why???
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }

        public static void Executar() {
            int a = 3;
            AtribuicaoPorValorA(a); // here a COPY is passed.
            Console.WriteLine(a); // that's why the output here is still "3".

            AlterarRef(ref a); // REF is like a 2 way street.
            Console.WriteLine(a);

            int b = 2;
            AtribuicaoPorValorB(b); // same as "a". A COPY is passed here.
            Console.WriteLine(b);

            // int c;
            // int d;
            AlterarOut(out int c, out int d); // OUT is like 1 way.
            Console.WriteLine($"{c}, {d}");
            // You pass these variables to the method, they get manipulated and when the methods gets executed,
            // you have access, in this case, to both values.
            // This is a way of having MORE THAN ONE "return".

            // This is the difference from REF. You just have OUTPUT, you don't manipulate the original values.
        }
    }
}
// The instructor says that using OUT is better because you have this one way behavior.
// When using by REF he says it can generate more bugs. Using Ref can cause some negatives impacts
// in the application. It makes sense, right? You may have a lot of variables poiting to the same space in memory.
// OUT just generates an output, you don't pass a data to an OUT parameter, it simply generates an output.
// You just pass a variable and when the methods ends, you have access to this variable.

/*
    Alguns alunos tem relatado que a funcionalidade de out não ficou muito clara na aula, 
    então estamos trazendo mais um exemplo que pode ajudar a compreender este conceito.

    O OUT é útil como uma forma de uma função "retornar" mais de um valor, 
    já que existem casos onde vamos querer obter mais de um valor a partir de uma função. 
    Então, como não podemos retornar uma segunda variável pois isso não é permitido no C#, 
    temos parâmetros marcados como OUT, 
    que nada mais são do que variáveis para guardarmos valores que queremos retornar além do valor no return da função.

    Um bom exemplo é o método TryParse que é usado para converter uma string num int. Caso ele consiga converter a string sem problemas, 
    este método põe o resultado na variável out e retorna true, caso contrário, ele põe o número zero na variável out e retorna false. 
    Um exemplo de uso típico desse método é o seguinte:

        string str = "100";
        if (int.TryParse(str, out int num)) {
            Console.WriteLine("{0}", num + 1);
        } else {
            Console.WriteLine("A conversão falhou!");
        }

    Outro exemplo que pode ajudar a compreender este conceito é o exemplo abaixo, 
    onde temos uma função que serve para calcular a media de 3 notas de um aluno, 
    e além de retornar a média deste aluno também nos "retorna" por meio de um out se este aluno está aprovado ou reprovado:

        double calcularMedia(double nota1, double nota2, double nota3, out String conc) {
            double media = (nota1 + nota2 + nota3) / 3;
            conc = media >= 7 ? "aprovado" : "reprovado";
            return media;
        }

        String conceito;

        double mediaDoAluno = Program.calcularMedia(1.6, 9.4, 5.0, out conceito);
        Console.WriteLine("A media é " + mediaDoAluno + " e o aluno está " + conceito);

        Espero que com estes exemplos o conceito tenha ficado mais claro.

        Bons estudos!!
*/
