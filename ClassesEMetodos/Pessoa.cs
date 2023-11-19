using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Pessoa
    {
        // Creating an OBJECT from a Class is also called TO INSTANTIATE / Create an instance of a class.

        // IN THIS CLASS WE HAVE 3 MEMBERS: (1) Name = attribute 1; (2) Age = attribute 2; (3) "Introduction" = Method.
        public string Name;
        public int Age;

        // Here, we declared the variables, but with no assignment. The DEFAULT value for string is NULL and for int is 0.

        // A convention: When you're declaring an attribute directly inside a CLASS, we use Pascal Case in the first letter.
        // When declaring it inside a METHOD, we use lower case.

        public string Introduction() { // I don't need to pass parameters here, because the owner of the attributes is the CLASS.
            return string.Format("Hello! My name is {0} and I'm {1} years-old.", this.Name, this.Age);
        }
        public void PrintIntroductionOnConsole() {
            Console.WriteLine(Introduction());
        }
        // VERY IMPORTANT: I was trying to insert "Console.WriteLine" INSIDE the "Introduction" method,
        // but, It wasn't possible. Why? Because that Method has a specific return = string.
        // That's why I had to create another one of the "VOID" type. So, it only executes the printing action.
        // With no need to return something. Again, that's why I couldn't implement the printing method inside "Introduction".
        // Because it has a specific return.

        public void ResetPersonData() {
            Name = "";
            Age = 0;
        }
    }
}
// IN ORDER TO CREATE A NEW STRUCTURE TO HAVE A REFERENCE BY VALUE, NOT BY REFERENCE (Using STRUCT, not CLASS):
// OR we have to make a copy of a new instance of the class, so we can have 2 different spaces in the memory,
// they are still going to be HEAP type, not STACK, but now we'll have 2 different spaces in memory.

// public STRUCT PessoaByValue {

//      public Pessoa GetCopy() {
//          var copy = new Pessoa();
//          copy.Name = this.Name;
//          copy.Age = this.Age;
//          return copy;
//      }
// }
