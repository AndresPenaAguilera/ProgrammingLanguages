using System;

namespace BasicConcepts
{
    public class Tupla
    {
        public Tupla() 
        {
            //Tupla
            (double, int) tipoTupla = (4.5, 5);

            (string Name, byte Long, long Number, int ZIP) tipoTupla2 = ("Luis", 50, 9999885, 00112);

            //Acces to data
            String Name = tipoTupla2.Name;

            //Tupla Method type 
            (int, int, string) result = TuplaMethodType(1, 2);
        }

        private (int, int, string) TuplaMethodType(int number1, int number2)
        {
            string returnString = string.Concat("Sum = {0}", (number2 + number2));
            return (number1, number2, returnString);
        }
    }
}
