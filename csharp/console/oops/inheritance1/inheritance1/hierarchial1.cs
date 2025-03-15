using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance1
{
    class hierarchial1
    {
        public static void Main()
        {
            square2 s = new square2();
            s.getdata();
            s.area_sqre();

            rectangle r = new rectangle();
            r.getdata();
            r.area_rec();

        }
    }
    class shape
    {
        protected int length,breadth;
        public void getdata()
        {
            Console.WriteLine("Enter a length and breadth value:");
            length = int.Parse(Console.ReadLine());
            breadth= int.Parse(Console.ReadLine());
        }
    }
    class square2 : shape
    {
        protected int area;
        public void area_sqre()
        {
            area = length * length;
            Console.WriteLine("Area of Square=" + area);
        }
    }

    class rectangle : shape
    {
        protected int area;
        public void area_rec()
        {
            area = length * breadth;
            Console.WriteLine("Area of Rectangle=" + area);
        }

    }


}
