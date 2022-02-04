namespace BasicConcepts.POO
{
    public class Motorcicle: Vehicle
    {
        public int CylinderCapacity { get; set; }

        public Motorcicle(string tradeMark, string model, int cylinderCapacity) : base (tradeMark, model)
        {
            CylinderCapacity = cylinderCapacity;
        }

        public new void Start() 
        { 
        
        }
    }
}
