using System;

namespace Classes_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car()
            {
                Make = "Jeep",
                Model = "Cherokee",
                Year = 1994
            };
            Console.WriteLine($"{newCar.Year} {newCar.Make} {newCar.Model} ");
        }
    }
}
