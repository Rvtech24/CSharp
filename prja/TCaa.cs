using System;
/*
 Example for typecasting 'Parse' method
 */ 

namespace prja
{
    class TCaa
    {
        public static void Main()
        {
            string s = "fox";
            int i = 0;
            i = int.Parse(s);
            Console.WriteLine(i);
            Console.WriteLine(s);
        }
    }
}
/*
 System.FormatException: Input string was not in a correct format
 */
