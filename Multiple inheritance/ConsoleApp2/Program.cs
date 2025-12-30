using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IAnimal
        //Multiple inheritance
    {
        void Eat();
    }
    interface IPet
    {
        void Play();
    }
    class Dog : IAnimal, IPet
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
        public void Play()
        {
            Console.WriteLine("Dog is playing");
        }
    }
    class Program
    {
        static void Main()
        {
            Dog d = new Dog();
            d.Eat();
            d.Play();

        }
    }
}
