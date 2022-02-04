using System;
using System.Text;

namespace BasicConcepts.TypeOfData
{
    public class Struct
    {

        public struct Book 
        {
            public String Name;
            public int Year;
            public String Editorial;

            public Book(String name, int year, String editorial) 
            {
                Name = name;
                Year = year;
                Editorial = editorial;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Name: {0}, Year: {1}, Editorial{2}",Name, Year, Editorial);
                return sb.ToString();
            }
        }

    }
}
