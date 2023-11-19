using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 10;

        static int b = 20;

        public static void Executar() {
            // Acessar a variavel "a" dentro do método Executar() sem mexer na variavel.

            var acessarA = new DesafioAtributo();
            Console.WriteLine(acessarA.a);

            // Usei "VAR" para criar a nova instância, mas lembrando que poderia usar "DesafioAtributo acessarA = new ..."
            // Criei uma nova instância para conseguir acessar "a",
            // tendo em vista que esse atributo não é static (pertence às instâncias/objetos, não à classe).

            Console.WriteLine(DesafioAtributo.b);
            Console.WriteLine(b);

            // Aqui, temos um atributo static "b". Preciso nem usar "DesafioAtributo.b" para imprimir o valor de "b".
            // Basta colocar direto o identificador da variável e o valor já é impresso.
            // Pois, estamos dentro da classe "DesafioAtributo".
            // LEMBRANDO QUE NÃO USAMOS "THIS." PARA REFERIR-SE À ATRIBUTOS STATIC, pois o "this." é só para instâncias.

        }
        
    }
}
