using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.var
{
    class CLSvarac
    {
        public static void Main()
        {
            var er = new { Rno = 1001, Sname = new { FName = "Ganesh", LName = "Siva" } };
            Console.WriteLine("Roll No : {0}", er.Rno);
            Console.WriteLine("Name : {0}", er.Sname);
            Console.WriteLine("Mark-1 : {0}", er.Sname.FName);
            Console.WriteLine("Mark-2 : {0}", er.Sname.LName);

        }
    }
}

/*
 
Output:
    
Roll No : 1001
Name : { FName = Ganesh, LName = Siva }
Mark-1 : Ganesh
Mark-2 : Siva 
 
 */
