using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    sealed class PaisSemFilhos
    {
        public double ValorDaHeranca() {
            return 1_407_033.65;
        }
    }

    //class SouFilho : PaisSemFilhos ---> Erro: Não é possível herdar da classe SELADA "PaisSemFilhos".

    public class Avo
    {
        public virtual bool UsarNomeFamilia() { // ---> Here, we can override the method and don't use the family name.
            return true;
        }
    }

    public class Pai : Avo
    {
        public sealed override bool UsarNomeFamilia() { // ---> Here, the father doesn't allow override. We MUST use the family name.
            return true;
        }
    }

    public class FilhoRebelde : Pai
    {
        //      public new bool UsarNomeFamilia() {  // ---> Can't use OVERRIDE here, but we can hide the original method using "new".
        //          return false;
        //      }
    }

    internal class ClasseEMetodoSealed // (1)
    {
        public static void Executar() {
            PaisSemFilhos paisSemFilhos = new PaisSemFilhos();
            Console.WriteLine(paisSemFilhos.ValorDaHeranca());

            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde.UsarNomeFamilia());
        }
    }
}

// (1) Abstract classes were created to have children classes that will instantiate the by inheritance the abstract class.
//     Otherwise, there is no purpose in having abstract classes, since they can't be instatiated, right?
//
//     A SEALED CLASS DOESN'T allow inheritance. Also, the SEALED MEMBER can't be overriden.
//
// (2) 