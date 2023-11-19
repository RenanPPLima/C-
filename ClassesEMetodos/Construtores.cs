using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Car
    {
        public string Manufacturer;
        public string Model;
        public int Year;

        // Here we'll create a PARAMETERIZED Constructor (non-default / custom constructor).
        public Car(string manufacturer, string model, int year) {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            // if I want to use the pascal case inside the method, I can use "this.Model" for example,
            // to diferentiate the attribute from the parameter, like: this.Model = Model;
            // Where "this" refers to the class' attribute.
        }
        public Car() {
        }
        // After declaring a Parameterized Contructor (the above one), the default one gets substituted automatically.
        // That's why we have to declare again the default one (we're using in "car1" below).
        // The DEFAULT Construtor has some characteristics:
        // (1) it is provided implicitly by C#;
        // (2) It doesn't take any parameters;
        // (3) It exists in 2 situations: you don't have a customized constructor OR you declare it explicitly (like we did above).
    }
    public class Construtores
    {
        public static void Executar() {
            var car1 = new Car(); // DEFAULT CONSTRUCTOR.
            car1.Manufacturer = "BMW";
            car1.Model = "325i";
            car1.Year = 2017;
            Console.WriteLine($"{car1.Manufacturer}: {car1.Model}; Year: {car1.Year}");

            var car2 = new Car("Ford", "Ka", 2018); // PARAMETERIZED CONSTRUCTOR.
            Console.WriteLine($"{car2.Manufacturer}: {car2.Model}; Year: {car2.Year}");

            var car3 = new Car() { // DEFAULT CONSTRUCTOR (another way of instantiating the class / creating an object).
                Manufacturer = "Fiat",
                Model = "Uno",
                Year = 2019
                // Careful here with the semicolon ( ; ) in this specific way of creating the object.
            };
        Console.WriteLine($"{car3.Manufacturer}: {car3.Model}; Year: {car3.Year}");
        }
        
    }
}

// VERY VERY IMPORTANT:
// He said that C# supports overloading (sobrecarga) of constructors.
// This fits perfectly the example seen here. We have 2 constructors of the same name, but they are different:
// (1) Parameterized Constructor ---> public Car(string manufacturer, string model, int year) {...};
// (2) Default Constructor ---> public Car() {};


// Another example here (taken from the internet):
/*

   public class mySampleClass  
{  
    public mySampleClass()  
    {  
        // This is the no parameter constructor method.  
        // First Constructor  
    }  
    public mySampleClass(int Age)  
    {  
        // This is the constructor with one parameter.  
        // Second Constructor  
    }  
    public mySampleClass(int Age, string Name)  
    {  
        // This is the constructor with two parameters.  
        // Third Constructor  
    }  
}
    mySampleClass obj = new mySampleClass()  

    // At this time the code of no parameter   
    // constructor (First Constructor) will be executed 

    mySampleClass obj = new mySampleClass(12)  

    // At this time the code of one parameter   
    // constructor(Second Constructor) will be executed.  

*/