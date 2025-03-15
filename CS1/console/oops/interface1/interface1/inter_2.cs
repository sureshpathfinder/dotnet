using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{
    class inter_2
    {
        public static void Main(string[] args)
        {
            square s = new sample1();
            Console.WriteLine("Square=" + s.disp(2));
            cube c = new sample1();
            Console.WriteLine("Cube=" + c.disp(2));

        }
    }
    interface square
    {
        int disp(int a);
    }
    interface cube
    {
        int disp(int a);
    }
    class sample1 :parent,square, cube
    {
        int square.disp(int a)
        {
            return a * a;
        }
        int cube.disp(int a)
        {
            return a * a * a;
        }
    }
    class parent
    {
        int x;
    }
}
