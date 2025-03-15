using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance1
{
    class single1
    {
        public static void Main()
        {
            square s = new square();
            s.getline();
            s.disp();
            Console.WriteLine("Area of square=" + s.area_square());

        }

    }
    class line
    {
        protected int l;
        public void getline()
        {
            Console.WriteLine("Enter the line=");
            l = int.Parse(Console.ReadLine());
        }
        public void disp()
        {
            Console.WriteLine("Line=" + l);
        }
    }
 class square:line
    {
       public int area_square()
       {
           return l * l;
       }
    }
}
