using System;

namespace HW11Week11
{
    class Program
    {
        // Create a class called Vehicle that has the Manufracturer name (enum), 
        // number of Cyclinders in the engine (int), 
        // and the owner (Person, see below).  
        // Then create a classs called Truck that is derived from Vehicle and has the 
        // additional following properties: the load capacity in tons (double), 
        // and towing capacity in pounds (int).  Be sure your class has a reasonable 
        // set of constructors, getters/setters, properties and suitably defined ToString 
        // and Equals methods.  Write a driver program to test all your methods. 

        static void Main(string[] args)
        {
            Person ownerA = new Person("Mark Aloka");
            Person ownerB = new Person("Samuel Peppetta");
            Vehicle xCar = new Vehicle(8, manufactureName.Porche911_Turbo, ownerB);
            Truck xTruck = new Truck(3439, 7275, 12, manufactureName.ROLLS_ROYCE_CULLINAN, ownerA);
            Console.WriteLine("");
            Console.WriteLine(xCar.ToString());

            Console.WriteLine("");
            Console.WriteLine(xTruck);
            Console.WriteLine("");

            Console.WriteLine(xTruck.Equals(xTruck)); //check for equality

            Console.WriteLine(xTruck.Equals(xCar)); //check for inequality

            Console.ReadLine();
        }
    }
}
