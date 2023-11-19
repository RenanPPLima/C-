using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegateComoParametro
    {
        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y) {
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y) {
            int resultado = op(x, y); // here, "resultado" gets "int" because of the parameters.
            return "O Resultado é: " + resultado;
        }

        public static void Executar() {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine("O Resultado é: " + subtracao(20, 30));

            Console.WriteLine(Calculadora(Soma, 20, 30));
        }
    }
}
