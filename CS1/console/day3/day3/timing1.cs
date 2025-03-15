using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ConsoleApplication1
{
    class timing1
    {
       
        public static void Main()
        {
            Employee e = new Employee();

            e.Eid = 12;
            e.Name = "sunil";

            // 4) Subscribe an event
            e.nameevent += new Idchange(e_nameevent);
            e.Eid = 3;

            //Timer t = new Timer(1000);
            //t.Elapsed += new ElapsedEventHandler(t_Elapsed);
            //t.Start();

            Console.ReadKey();

        }

        static void t_Elapsed(object sender, ElapsedEventArgs e)
        {
            
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }

        static void e_nameevent(int id)
        {
            Console.WriteLine("Eid is changed: " + id);
        }

       
        // 1) delegate declaration
        public delegate void Idchange(int s);

    public class Employee
    {

        private int eid;

        public int Eid
        {
            get { return eid; }
            set {
                eid = value;
                if (nameevent != null)
                    nameevent(eid);// 3)invoking an event
            }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public event Idchange nameevent;  // 2) event declaration
    }

    }
}
