using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public Car ()
        {
            Fuel = 46;
        }
        public int Speed { get; set;}
        public int Fuel { get; set; }
        public void Accelerate()
        {
            Speed = Speed + 15;
        }
        public void Drive()
        {
            Fuel = Fuel - 23;
        }
        public void AddFuel()
        {
            Fuel = Fuel + 23;
        }
        public void Brake()
        {
            Speed = Speed - 7;
        }
    }
}
