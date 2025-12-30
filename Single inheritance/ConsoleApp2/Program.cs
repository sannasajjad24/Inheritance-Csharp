using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Animal
        //single inheritance
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Dog d = new Dog();
            d.Eat();
            d.Bark();
        }
    }
}
