using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Execoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { } // Default constructor inherited from Exception from C#.

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception innerException) : base(message, innerException) { } // (1)

    }

    public class NumImparException : Exception
    {
        public NumImparException(string message) : base(message) { }
    }

    internal class ExcecoesPersonalizadas
    {
        public static int NumPositivoEPar() {
            Random random = new Random();
            int numero = random.Next(-30, 30);

            if (numero < 0) {
                //Console.WriteLine(numero);
                throw new NegativoException($"Número negativo: {numero}.");
            }

            if (numero % 2 == 1) {
                //Console.WriteLine(numero);
                throw new NumImparException($"Número ímpar: {numero}.");
            }
            return numero;
        }

        public static void Executar() {
            // Console.WriteLine(NumPositivoEPar()); ---> REMEMBER the difference between printing like this and using TRY CATCH

            try {
                Console.WriteLine(NumPositivoEPar());
            } catch (NegativoException e) {
                // Console.WriteLine(numero); ---> Como printar o "numero" aqui? É possível? Qual a vantagem de printar aqui ao invés de fazer no IF?
                Console.WriteLine(e.Message);
            } catch (NumImparException e) {
                Console.WriteLine(e.Message);
            } // Here we could also have the default Exception like: "An unexpected error ocurred".
        }   
    }
}

// (1) Here, I'm defining some constructors that are inherited from "Exception": The first is the default;
//     The second is a custom one; The third is an exception of the exception.
//
//     About the THIRD case (innerException): It's like an error ocurred, but the cause was another thing.
//     Example: I tried to search for a file inside the PC. Nothing returns... So, it's an exception.
//              But why didn't I have the return? Because it's an occult item, for example. That's the cause of the exception.
//     Thereby, it's something like this: there was an error, however whatever is causing it, comes from another error.
//
//     So, an exception can be used to construct another exception so we know the real cause of the problem.