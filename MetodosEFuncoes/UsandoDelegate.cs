using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class UsandoDelegate
    {
        delegate double Soma(double x, double y);
        delegate void ImprimirSoma(double x, double y);

        static double MinhaSoma(double x, double y) {
            return x + y;
        }

        static void MeuImprimirSoma(double x, double y) {
            Console.WriteLine(x + y);
        }

        public static void Executar() {
            Soma op1 = MinhaSoma; // (1)
            Console.WriteLine(op1(2, 3.9));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(3.2, 4);

            Func<double, double, double> op3 = MinhaSoma; // 2 double parameters + 1 return double.
            Console.WriteLine(op3(2.5, 3));

            Action<double,double> op4 = MeuImprimirSoma;
            op4(9, 13.5);
        }
    }
}
// (1) We can use pre-existing methods / functions and store them into a DELEGATE type variable.
//     HOWEVER, the signature of the DELEGATE and the FUNCTION MUST BE the same.
//     
//     A delegate is a reference type variable that holds the reference to a method.
