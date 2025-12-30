using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Vehicle
        //multilevel inheritance 
    {
        public void Start()
        {
            Console.WriteLine("Car is starting");
        }
    }
    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }
    class SportsCar : Car
    {
        public void Turbo()
        {
            Console.WriteLine("Sports car is using turbo");
        }
    }
    class Program
    {
        static void Main()
        {
            SportsCar sc = new SportsCar();
            sc.Start();
            sc.Drive();
            sc.Turbo();

        }
    }
}
