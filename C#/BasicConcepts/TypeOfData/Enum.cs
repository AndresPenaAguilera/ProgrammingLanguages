using System;

namespace BasicConcepts.TypeOfData
{
    class Enum
    {
        enum Week { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        enum Week2 { Monday=1, Tuesday=2, Wednesday=3, Thursday=4, Friday=5, Saturday=6, Sunday=7 }

        public Enum() 
        {
            Week Day = Week.Monday;
            String textDay = Day.ToString();

            Week2 day2 = Week2.Monday;
            int numberDay = (int)day2;
        }
    }
}
