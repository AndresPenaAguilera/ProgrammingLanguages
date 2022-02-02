using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.POO
{
    public class Car: Vehicle
    {
        public string Traction { get; set; }

        public Car(string tradeMark, string model, string traction) : base(tradeMark, model)
        {
            Traction = traction;
        }

        public override void Start()
        {

        }
    }
}
