using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32._objects
{
    public class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
