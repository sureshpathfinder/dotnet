using System;
using System.Collections.Generic;
using System.Text;

namespace class2
{
    class set_get1
    {
        public static void Main()
        {
            stud s = new stud();
            s.M = 10;
            Console.WriteLine("M=" + s.M);

        }
        

    }
    class stud
    {
        private int a;
        public int M
        {
            set
            {
                M = value;
            }
            get
            {
                return M;
            }
        }
    }
}
