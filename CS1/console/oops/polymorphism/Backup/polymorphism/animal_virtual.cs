using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class animal_virtual
    {
        static void Main(string[] args)
        {
            cat1 c = new cat1();
            c.disp("cat");
            c.food("Milk");
            dog1 d = new dog1();
            c.disp("dog");
            c.food("Chicken");
        }
    }
    class animal1
    {
        
        public void disp(String a)
         {
             Console.WriteLine("Animals name="+a);
         }
        public virtual void food(String f)
        {
            Console.WriteLine("Food="+f);
        }
    }
    class cat1:animal1
    {

        public override void food(String f)
        {
            Console.WriteLine("Food=" + f);
        }
    }
    class dog1: animal1
    {
        public override void food(String f)
        {
            Console.WriteLine("Food=" + f);
        }
    }
}


