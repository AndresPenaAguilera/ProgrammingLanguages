using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.POO
{
   
    public class Vehicle
    {
        public decimal MaximumSpeed { get; set; }
        public int NumberOfWheels { get; set; }
        public string TradeMark { get; set; }
        public string Model { get; set; }

        public Vehicle(string tradeMark, string model) 
        {
            TradeMark = tradeMark;
            Model = model;
        }

        public virtual void Start() 
        { 
            //arrancar
        }

    }
}
