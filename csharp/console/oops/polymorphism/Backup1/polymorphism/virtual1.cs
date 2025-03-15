using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
   //base class
    public class DrawingObject
    {
        public int a;
        public void disp()
        {
            Console.WriteLine("a=" + a);
        }

        public virtual void area()
        {
            Console.WriteLine("It is area about the shape.");
        }
    }

    //derived class1
    public class square : DrawingObject
    {
        public override void area()
        {
            a = 20;            
            Console.WriteLine("area of square=" + (a*a));

        }
    }
    //derived class2
    public class Cube : DrawingObject
    {
        public override void area()
        {
            a = 4;
            Console.WriteLine("area OF Cube= "+(a*a*a));
           
        }
    }
    
    public class DrawDemo
    {
        public static int Main()
        {
            square b = new square();
            Cube c = new Cube();
            DrawingObject d = new DrawingObject();
            b.disp();
            b.area();

            c.disp();
            c.area();

            d.disp();
            d.area();
            

            return 0;
        }
    }
}
