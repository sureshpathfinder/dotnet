using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Linq6();
        }
        public void Linq6()
        {
            var list = new List<int>{ 2, 7, 1, 3, 9 };
 
                var result =
                    from i in list    
                        where i > 1    
                            select i;

        }
    
}
