using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace data1
{
    class Program
    {
        static void Main(string[] args)
        {
            
             SqlConnection cn;
             SqlCommand cmd1;
            
            cn = new SqlConnection("server=Server;database=sample;user id=sa");
            cn.Open();

            Object c;
            cmd1 = new SqlCommand("select count(*) from emp", cn);

            c=cmd1.ExecuteScalar();

            Console.WriteLine(c.ToString());


        }
    }
}
