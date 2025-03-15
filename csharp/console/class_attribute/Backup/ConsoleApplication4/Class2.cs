using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ConsoleApplication4
{
    public class IsTested : Attribute
    {
        public override string ToString()
        {
            return "Code Is Tested";
        }
    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class Author : Attribute
    {
        private string name;
        private int version;

        public Author(string name)
        {
            this.name = name;
            this.version = 0;
        }

        public string Name
        {
            get { return name; }
        }

        public int Version
        {
            get { return version; }
            set { version = value; }
        }

        public override string ToString()
        {
            string value = "Author : " + Name;
            if (version != 0)
            {
                value += " Version : " + Version.ToString();
            }
            return value;
        }
    }

    [Author("Joe Programmer")]
    class Account
    {
        [IsTested]
        public void AddOrder(Order orderToAdd)
        {
            //		
        }
    }

    [Author("Jane Programmer", Version = 2), IsTested()]
    class Order
    {
    }
    class MainClass
    {
        public static void Main()
        {
            MemberInfo info = typeof(Account);
            object[] attributes = info.GetCustomAttributes(true);
            Console.WriteLine("Attributes from Account Class");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }
            info = typeof(Order);
            attributes = info.GetCustomAttributes(true);
            Console.WriteLine("Attributes from Order Class");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }
        }
    }
}
