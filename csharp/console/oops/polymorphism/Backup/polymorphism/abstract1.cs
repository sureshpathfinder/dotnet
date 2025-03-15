using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class abstract1
    {
        static void Main(string[] args)
        {
            cat c = new cat();
            c.disp("cat");
            c.food("Milk");
            dog d = new dog();
            c.disp("dog");
            c.food("Chicken");
        }
    }
    abstract class animal
    {
        
        public void disp(String a)
         {
             Console.WriteLine("Animals name="+a);
         }
        public abstract void food(String f);
    }
    class cat:animal
    {

        public override void food(String f)
        {
            Console.WriteLine("Food=" + f);
        }
    }
    class dog : animal
    {
        public override void food(String f)
        {
            Console.WriteLine("Food=" + f);
        }
    }
}
