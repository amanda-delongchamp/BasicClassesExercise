using System;

namespace BasicClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Ford";
            myNewCar.Model = "Expedition";
            myNewCar.Year = 2021;

            Console.WriteLine($"My new car is a {myNewCar.Year} {myNewCar.Make} {myNewCar.Model}");
        }
    }
}
