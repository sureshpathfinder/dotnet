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

        public virtual void Draw()
        {
            Console.WriteLine("I'm just a generic drawing object.");
        }
    }

    //derived class1
    public class Line : DrawingObject
    {
        public override void Draw()
        {
            a = 20;
            Console.WriteLine("I'm a Line.");
            Console.WriteLine("a=" + a);

        }
    }
    //derived class2
    public class Circle : DrawingObject
    {
        public override void Draw()
        {
            a = 4;
            Console.WriteLine("I'm a Circle.");
           
        }
    }
    //derived class3
    public class Square : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Square.");
        }
    }
    public class DrawDemo
    {
        public static int Main()
        {
            Line a = new Line();
            Square b = new Square();
            Circle c = new Circle();
            DrawingObject d = new DrawingObject();

            a.Draw();
            b.Draw();
            b.disp();
            c.Draw();
            c.disp();
            d.Draw();
            d.disp();
            return 0;
        }
    }
}
