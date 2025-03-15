using System;
using System.Collections.Generic;
using System.Text;

namespace struct1
{
    enum week
    {
        monday, tuesday, wednesday=10, thursday, friday, saturday, sunday
    };
    class enum1
    {

        static void Main(string[] args)
        {
            int x = (int)week.thursday;
            Console.WriteLine("x="+x);
        }
    }
}
