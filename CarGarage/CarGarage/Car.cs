using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public int Speed { get; set;}
        public void Accelerate()
        {
            Speed = Speed + 15;
        }

    }
}
