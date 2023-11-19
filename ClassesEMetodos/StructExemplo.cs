using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    interface IMoverPonto
    {
        void MoverNaDiagonal(int deltaXAndY); // "private" here generates an error.
                                              // BY DEFAULT, Every interface's METHOD is public.
    }

    struct Coordenadas : IMoverPonto
    {
        public int X;
        public int Y;

        public Coordenadas(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int deltaXAndY) {
            X += deltaXAndY;
            Y += deltaXAndY;
        }
    }


    internal class StructExemplo
    {
        public static void Executar() {
            Coordenadas coordenadasIniciais;
            coordenadasIniciais.X = 2;
            coordenadasIniciais.Y = 2;

            Console.WriteLine("Coordenadas Iniciais:");
            Console.WriteLine("X: {0}", coordenadasIniciais.X);
            Console.WriteLine("Y: {0}", coordenadasIniciais.Y);


            var coordenadasFinais = new Coordenadas(x: 9, y: 1);
            coordenadasFinais.MoverNaDiagonal(10);

            Console.WriteLine("Coordenadas Finais:");
            Console.WriteLine("X: {0}", coordenadasFinais.X);
            Console.WriteLine("Y: {0}", coordenadasFinais.Y);
        }
    }
}
// When watching this class, I couldn't understand a thing.
// The instructor started talking about "interface", but didn't explain what the f. is that.
//
// Then he started coding, just throwing code on the screen, and in the end explained nothing that was going on.
// Just said that "struct" follows almost the same syntax as a Class.
//
// WTF?!?!? And yes, in case it wasn't clear, he didn't explain what is a "struct". It was just randomness all around (??????).
// Hopefully, it will make some sense later...

