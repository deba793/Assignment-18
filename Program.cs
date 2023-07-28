using assignment_18;
using System;
namespace assignment_18
{


    class  Program
    {
        static void Main()
        {
            Smartphone smartphone = new Smartphone();
            smartphone.Connect();
            smartphone.Charge(98);
            Console.WriteLine($"Smartphone connected: {smartphone.Connect()}");
            Console.WriteLine($"Smartphone Battery Level: {smartphone.BatteryLevel}");
            Console.WriteLine(smartphone.Display());

            Console.WriteLine();

            Laptop laptop = new Laptop();
            laptop.Connect();
            laptop.Charge(79);
            Console.WriteLine($"Laptop connected: {laptop.Connect()}");
            Console.WriteLine($"Laptop Battery Level: {laptop.BatteryLevel}");
            Console.WriteLine(laptop.Display());
        }
    }
}