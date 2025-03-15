using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance1
{
    class multilevel1
    {
        public static void Main()
        {
            cube c = new cube();
            c.geta();
            c.area_sqre();
            c.volume_cube();

        }

    }
    class line_side
    {
        protected int a;
       internal void geta()
        {
            Console.WriteLine("Enter a line value");
            a = int.Parse(Console.ReadLine());
        }
    }
    class square_:line_side
    {
        protected int area;
        public void area_sqre()
        {
            area = a * a;
            Console.WriteLine("Area of Square=" + area);
        }
    }

    class cube: square_
    {
        protected int volume;
        
        public void volume_cube()
        {
         
            volume = area * a;
            Console.WriteLine("Area of Cube=" + volume);
        }
    }
}
