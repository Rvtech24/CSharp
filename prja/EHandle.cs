using System;
/*
 Example for Exception  Handling
 */ 
namespace prja
{
    class EHandle
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Welcome");
                int i = 10, j = 0;
                Console.WriteLine(i / j);
            }
            catch(Exception e)
            {
                Console.WriteLine("err.:" + e.Message);
            }
            Console.WriteLine("visit again");
        }
    }
}

/*
 Welcome
err.:Attempted to divide by zero.
visit again
*/
