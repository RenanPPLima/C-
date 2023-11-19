using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto // STRUCT Ponto
    {
        public int X;
        public int Y;
    }

    public class CPonto // CLASS Ponto
    {
        public int X;
        public int Y;
    }


    internal class StructVsClass
    {
        public static void Executar() {
            // STRUCT:
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // (1) Atribuição por VALOR.
            ponto1.X = 5;
            
            Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            Console.WriteLine("Cópia Ponto 1 X: {0}", copiaPonto1.X);

            
            // CLASS:
            CPonto ponto2 = new CPonto { X = 1, Y = 3 };
            CPonto copiaPonto2 = ponto2; // (2) Atribuição por REFERÊNCIA.
            ponto2.X = 5;

            Console.WriteLine("\nPonto 2 X: {0}", ponto2.X);
            Console.WriteLine("Cópia Ponto 2 X: {0}", copiaPonto2.X);
        }
    }
}

// (1) Atribuição por VALOR (STRUCT):
// Como o Renanzeeiiira tinha explicado, uma vez que mexe em um deles, não gera efeito no outro.
// Já que essa atribuição por VALOR apontam para DIFERENTES lugares na memória.
// O instrutor comenta que o "Paradigma Funcional" trabalha muito em cima disso, cópia por valor e não por referência.

// (2) Atribuição por REFERÊNCIA (CLASS):
// Apontam para o MESMO local de memória. Ou seja, à partir de uma variável, o que você alterar,
// a outra variável irá enxegar, pois elas apontam para o MESMO local.

// (3) Conclusão:
// Segundo o instrutor, essa diferença é MUITO forte, muito basilar e é uma ferramenta poderosa.
// A questão da REFERÊNCIA é que você poderá ter várias variáveis apontando para o mesmo dado/local.
// Isso pode gerar efeitos colaterais (quando trabalhando por referência):
// Ex: Ambiente de múltiplas threads.
// Você tendo atribuições por valor, previne essas possíveis modificações do mesmo dado/local.
// Essa é a diferença de STRUCT para CLASS (Valor vs Referência).

