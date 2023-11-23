using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento; // Using Encapsulamento (different project / Assembly - AmigoProximo, FilhoReconhecido, SubCelebridade).


namespace CursoCSharp.OO
{

    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos() { // (1)
            Console.WriteLine("- Filho Não Reconhecido (Herança)...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            // Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            // Console.WriteLine(SegredoFamilia);
            // Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("- Amigo Distante (Por Composição)...");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }

    public class Encapsulamento
    {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();

            // (2)
            sub.InfoPublica = "Testing";
            // sub.CorDosOlhos = "Azul";
            // sub.NumeroCelular = 21421;
            // sub.JeitoDeFalar = "Séria";
            // sub.SegredoFamilia = "BlaBla";
            // sub.UsaMuitoPhotoshop = false;
            sub.MeusAcessos();
            
            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();

        }
    }

}

// (1) Here, we're using "public NEW void" so we hide this method from the father class.
//
// (2) The only Member that I have access here is "InfoPublica".
//     This one I can change for this NEW instance, the rest I can't change.
//     Check Class SubCelebridade to see what we have inside it.
//
// (3) The instructor says that's the chellenge is to know what kind of visibility to use.
//     His tip is to use the more restricted ones and when you have a good reason to change it, you do it.       
