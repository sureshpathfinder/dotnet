using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Collection2
{
    class dictionary1
    {
        static void Main(string[] args)
        {
            Dictionary<int, emp> s= new Dictionary<int, emp>();

            emp e1 = new emp(101, "sunil", 25);
            emp e2 = new emp(102, "Ram", 26);
            emp e3 = new emp(103, "Arin", 23);

            s.Add(e1.eid, e1);
            s.Add(e2.eid, e2);
            s.Add(e3.eid, e3);

            foreach (KeyValuePair<int, emp> e in s)
            {
                //Console.WriteLine("sam ID:  {0}, Name: {1}",
                //    custKeyVal.Key,
                //    custKeyVal.Value.n);

                Console.WriteLine("employee id= " + e.Key + " Name : " + e.Value.name+"  Age:  "+ e.Value.age);
            }
            

            //Console.WriteLine(s[101].age);
            Console.ReadKey();
        }
    }
    class emp 
    {
        public int eid,age;
        public string name;
        public emp(int x, string s,int a)
        {
            eid=x;
           name=s;
            age=a;
        }
    }
}
