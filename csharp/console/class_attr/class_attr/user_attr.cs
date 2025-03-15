
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace class_attr
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class Author : Attribute
    {
        public string name;
        public int price;
        public Author(string name,int a)
        {
            this.name = name;
            this.price = a;
        }
        public override string ToString()
        {
            string value = "Author : " + name+"    Value="+price;            
            return value;
        }
    }

    [Author("Sample",43)]
    class Book
    {     
        public void AddOrder()
        {
            //		
        }
    }


    
    class user_attr
    {
        public static void Main()
        {
             MemberInfo info = typeof(Book);
             object[] a = info.GetCustomAttributes(true);
             Console.WriteLine("Attributes from Book Class");
             Console.WriteLine("--------------------------------------");
             for (int i = 0; i < a.Length; i++)
             {
                 Console.WriteLine(a[i]);
             }

        }
    }
}
