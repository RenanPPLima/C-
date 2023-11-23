using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular // (1)
    {
        public abstract string AssistentePessoal(); // (1)

        public string Tocar() { // (2)
            return "Trim Trim Trim...";
        }
    }

    public class Samsung : Celular // (3)
    {
        public override string AssistentePessoal() {
            return "Olá, eu sou a Bixby";
        }
    }

    public class iPhone : Celular
    {
        public override string AssistentePessoal() {
            return "Olá, eu sou a Siri";
        }
    }


    internal class ClasseAbstrata // The opposite of a CONCRETE class. Obviously.
    {
        public static void Executar() {
            // Celular celular = new Celular(); // (1)

            var celulares = new List<Celular> {
                new iPhone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.AssistentePessoal());
            }
        }
    }
}

//     Abstract classes have the purpose to be inherited by other classes.
//     Therefore, they can't be instantiated.
//     It can have all the methods implemented / concrete (with body) or abstracts methods.
//     The derived class can also be abstract, but, when you come to the concrete class, in the end you'll have to implement
//     the abstract methods.
//
// (1) Abstract classes can't be instantiated. When you instantiate an object, you're "giving life" to it.
//     However, there are some concepts that are abstract in the real world. Like: Cellphone.
//     Cellphone is a concept, iPhone is a cellphone/smartphone, right?
//     That's why you must create another class, a concrete one, that inherits from the abstract one.
//     So that you can instantiate, create objects, from the concrete class that inherits concepts/members of the abstract class.
//     Like the method "AssistentePessoal();" - You can't determine in the abstract class WHAT personal assistant cellphone will have.
//     This will be determined by the concrete class that inherits from "Celular", and every "Celular" MUST have an "AssistentePessoal()".
//
//     I.e., if a concrete class inherits from "Celular" (abstract class) it must implement the method also "AssistentePessoal".
//     That's why we don't have a body to the "AssistentePessoal()" method.
//
// (2) We can have concrete methods inside abstract classes also (I know... confusing kkk). This can happen because depending on the case,
//     you already know some concrete attribute or behavior that it must have.
//
// (3) When "Samsung" inherited from "Celular" the first thing that appeared was an error saying that the method "AssistentePessoal" wasn't implemented.
//     So, despite being an abstract method, we have to override it to implement an giving it a body.
//     The method "Tocar()" didn't need to be implemented... why? Because it's a concrete one and I already got it because of the inheritance.