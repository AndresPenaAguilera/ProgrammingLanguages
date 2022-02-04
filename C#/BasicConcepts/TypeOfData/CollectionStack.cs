using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.TypeOfData
{
    public class CollectionStack
    {
        public Stack<double> stack;
        public CollectionStack() 
        {
            stack = new Stack<double>();
        }

        public void AddElement(double value) 
        {
            stack.Push(value);
        }
        public string GetElement() 
        {
            int i = 0;
            string values="";
            foreach (double element in stack) 
            {
                values += string.Format("index {0} value {1} -", i++, element);
            }
            return values;
        }

        
    }
}
