using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46._getters___setters
{
    public class Car
    {
        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public Car(int speed)
        {
            this.Speed = speed;
        }
    }
}
