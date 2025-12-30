using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        public void Work()
        {
            Console.WriteLine("Employee works in an organization");
        }
        
    }
    class Teacher : Employee
    { 
        public void Teach()
        {
            Console.WriteLine("Teacher teaches students");
        }
    }
    class Manager : Employee
    {
        public void Manage()
        {
            Console.WriteLine("Manager manages the team");
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Teacher t = new Teacher();
            t.Work();
            t.Teach();

            Manager m = new Manager();
            m.Work();
            m.Manage();
        }
    }
}


