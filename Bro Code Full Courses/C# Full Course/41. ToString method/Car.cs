using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41._ToString_method
{
    public class Car
    {
        public string make;
        public string model;
        public int year;
        public string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public override string ToString()
        {
            return $"This is a {make} {model}";
        }
    }
}
