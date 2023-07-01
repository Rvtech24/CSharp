using System;
/*
 Example for user-defined type-casting feature with exception handling
 */ 
namespace prja
{
    class TCac
    {
        public static void Main()
        {
            string s = "5";
            int i = 0;
            try
            {
                i = int.Parse(s);

            }
            catch(Exception e)
            {
                i = 0;
                Console.WriteLine("err-1:" + e.Message);
            }
            Console.WriteLine(s + "-" + s.GetType());
            Console.WriteLine(i + "-" + i.GetType());

            s = "fox9";
            try
            {
                i = int.Parse(s);

            }
            catch(Exception e)
            {
                i = 0;
                Console.WriteLine("err-2:" + e.Message);

            }
            Console.WriteLine(s + "-" + s.GetType());
            Console.WriteLine(i + "-" + i.GetType());
        }
    }
}

/*
 Output:

5-System.String
5-System.Int32
err-2:Input string was not in a correct format.
fox9-System.String
0-System.Int32

 */
