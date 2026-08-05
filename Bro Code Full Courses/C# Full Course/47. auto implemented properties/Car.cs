using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47._auto_implemented_properties
{
    public class Car
    {
        public string Model { get; set; }

        public Car(string model)
        {
            this.Model = model;
        }
    }
}
