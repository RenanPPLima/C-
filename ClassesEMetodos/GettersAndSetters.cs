using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    // BY DEFAULT C# SETS THE ATTRIBUTES AS "PRIVATE" IF YOU DON'T DECLARE ANYTHING:
    // E.G.: string Marca; ---> By DEFAULT it will be "PRIVATE".

    // Check definiton of PRIVATE in the end.
    // But, despite being a more complicated implementation, one of the good reasons to use PRIVATE is that
    // INSIDE THE GET / SET METHODS you can TREAT the value when setting it or getting it.

    // E.G.: You can treat the value so the attribute doesn't receive a negative value, before even assigning it, so you can make
    // the verification BEFORE the assignment itself, not after.

    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada) { // Parameterized Constructor.
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cilindrada = cilindrada;
            
            // (1) I can do this to make sure "CILINDRADA" is NOT a NEGATIVE NUMBER:
            // SetMarca(marca);
            // SetModelo(modelo);
            // SetCilindrada(cilindrada);
        }

        public Moto() { // Default Constructor.
        }

        // this.Marca:
        public void SetMarca(string marca) { // VOID because I only want to change "Marca" value. No need to return anything.
            this.Marca = marca;
        }
        public string GetMarca() { // STRING because I want the RETURN of what's assined to "Marca".
            return this.Marca; // I can't use "marca" because it doesn't exist in this context.
        }

        // this.Modelo:
        public void SetModelo(string modelo) {
            this.Modelo = modelo;
        }
        public string GetModelo() {
            return this.Modelo;
        }

        // this.Cilindrada:
        public void SetCilindrada(int cilindrada) {
            // (2) I can also do this (Cilindrada NOT negative):
            if (cilindrada > 0) this.Cilindrada = cilindrada;
            // (3) Using MATH.ABS = Math.Absolute ---> transforms/keeps numbers positive.
            else this.Cilindrada = Math.Abs(cilindrada);

            // (4) THE BEST OPTION IN THIS CASE IS TO USE "uint" INSTEAD OF "int".
            // "uint" doesn't allow negatives. THE BEST AND MORE ELEGANT WAY OF SOLVING THIS.
        }
        public int GetCilindrada() {
            return this.Cilindrada;
        }

    }

    internal class GettersAndSetters // get = see the value. set = change the value.
    {
        public static void Executar() {
            Moto moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());
            Console.WriteLine(moto1.GetCilindrada); // This is on purpose.  Just to see what is printed.

            // Using the default constructor, I have to SET the values this way:
            // (since I don't have parameters in the default constructor):

            Moto moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(-150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
            Console.WriteLine($"{moto2.GetMarca()} {moto2.GetModelo()} {moto2.GetCilindrada()}"); // The same content of the line above.
        }
    }
}

// Getters and Setters:
// First, we have to understand what is Encapsulation.
// Encapsulation = hide something.
// The instructor gave the example of a car: You don't need to know what is beneath the car's hood, but how to interact with it (drive).
// You only need to know how to interact with the car, not how the fuel burns inside the engine in order to drive it.
// In other words, there are hidden stuff that you don't to know how they work in order to drive.

// In a different way, encapsulation is a protective shield that prevents the data from being accessed by the code outside this shield.

// (1) Technically in encapsulation, the variables or data of a class are hidden from any other class,
// and can be accessed only through any member function of own class in which they are declared.
// (2) As in encapsulation, the data in a class is hidden from other classes, so it is also known as data-hiding.
// (3) Encapsulation can be achieved by: Declaring all the variables in the class as private and using C# Properties
// in the class to SET and GET the values of variables.

// The way to encapsulate is using the word "PRIVATE": "private" means that it can only be accessed by the class itself.
// This is good so we don't have collision with other codes,
// like other instances/objects or classes. Also, it becomes easier to make verifications without having to worry about
// other instances of the code.

// CHECK: "Propriedades". According to the instructor it's a better way to implement GET and SET, despite the concept seen here
// being important for that.
