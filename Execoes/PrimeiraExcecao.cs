using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp.Execoes;

namespace CursoCSharp.Execoes // (1)
{
    public class ContaCorrente
    {
        double Saldo;

        public void Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo Insuficiente."); // (3)
            }
            Saldo -= valor;
        }
    }
}

internal class PrimeiraExcecao
{
    public static void Executar() {
        var conta = new ContaCorrente();
        conta.Conta(1_223.45);

        try {
            conta.Sacar(1_600);
            Console.WriteLine("Retirada com sucesso!");
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        // (2)
        } finally { 
            Console.WriteLine("Obrigado!");
        }

        // Forcing an error here to see the difference between EXCEPTION and ARGUMENT EXCEPTION ( //(3) ).
        try {
            int.Parse("abc");
            conta.Sacar(1_200);
            Console.WriteLine("Retirada com sucesso!");
        } catch (Exception ex) { // (3)
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine(ex.Message);
        } finally {
            Console.WriteLine("Obrigado!");
        }
    }
}
// (1) In C# the exception type is: UNCHECKED. In Java we have CHECKED and UNCHECKED.
//
//     If there is an error when executing a method, you can throw (lançar) the exceptions to treat them later.
//     If you don't have an error, the method will return whatever is expected of it.
//
//     Here's the idea: There is a concept about STACK of Execution here.
//     The first method of every project in C# is MAIN. Then you have a second method, a third, and so on...
//     If you don't treat the error, the TENTH method will go back to the NINTH, then the EIGHTH, and so on...
//
//     So, when you get out of a method in an abrupt way because of an exeception (error), the method doesn't return
//     what it should.The expected flow of the program doesn't happen.
//     That's why we must treat the error.
//
//     For example: we can have an error in STACK 10. The code will go back STACK by STACK (10th, 9th, 8th...) until it finds
//     a treatment for that error. Otherwise, it will end up at the MAIN and crash.
//     So, we can have a TRY CATCH at STACK 2, for example, treating errors (throw) from stacks above.
//
// (2) The structure of "try - catch" resembles "if - else" a little bit.
//     "finally" ALWAYS gets executed (if used, it's not mandatory...).
//
// (3) "ArgumentException" is more specific than "Exception".
//     So, when I use "Execption" - the more generic one - it will treat whatever is in the "try" block.
//
//     When I use "int.Parse("abc");" It generates an error, but using "Exception" it gets printed.
//     If I use "ArgumentException", like in the "SACAR" method, it treats that one specifically, and the error is printed in RED on the console.
//     To see this happening, IN LINE 47 - Change "Exception" to "ArgumentException".
