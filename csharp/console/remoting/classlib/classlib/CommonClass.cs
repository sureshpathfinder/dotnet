using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classlib
{
    public class CommonClass : MarshalByRefObject
    {

        public string FirstName;

        public string LastName;

        public string GetWelcomeString()
        {
            Console.WriteLine("Welcome " + FirstName + " " + LastName);
            return "Welcome " + FirstName + " " + LastName;
        }

    }

}
