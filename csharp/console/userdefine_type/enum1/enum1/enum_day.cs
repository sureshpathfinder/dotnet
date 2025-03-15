using System;
using System.Collections.Generic;
using System.Text;

namespace enum1
{
    enum day
    {
        monday,
        tuesday=10,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }

    class enum_day
    {
        public static void Main()
        {
            day d=0;
            Console.WriteLine("Day="+d);
            int a = (int)day.friday;
            Console.WriteLine("Day=" + a);
        }
            
    }
}
