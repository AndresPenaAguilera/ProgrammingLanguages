using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.TypeOfData
{
    public class Generics<T>
    {
        private int i = 0;
        private T[] matriz;

        public Generics(int elements) 
        {
            matriz = new T[elements];
        }

        public void AddElement(T element) 
        {
            matriz[i] = element;
            i++;
        }

        public T GetElement(int position) 
        {
            return matriz[position];
        }
    }


    public class Student 
    {
        double Score { get; set; }

        public Student(double score) 
        {
            Score = score;
        }
    }
}
