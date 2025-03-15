using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class Class2
    {
        public static void Main()
        {
            student s1 = new student(12, "Gopa");
            //s1.get(12,"Sunil");
            s1.disp();

            student[] s = new student[10];

            s[0] = new student(1, "Sunil");
            s[0].disp();

            s[1] = new student(2, "Ravi");
            s[1].disp();

            s[2] = new student(3, "Dinesh");
            s[2].disp();
        }
        
    }
}
