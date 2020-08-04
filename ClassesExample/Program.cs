using ClassesExample.Animals;
using System;

// namespace = large, high level bundle of code
// using System is an example of a namespace
namespace ClassesExample
{
    class Program
    {
        //method is a function inside a class
        // all methods are functions but not all functions are methods
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var chicken = new Chicken("Liza");
            var bob = new Chicken("Bob");

            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");

            bob.Peck("watermelon");
        }
    }

}

// method signature
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
// first part is access method
// what kind of thing you will return
// name of method 
// parenthesis and arguement parameter
// public void Peck(string typeOfFood)
