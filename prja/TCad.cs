using System;
/*
 Example for Type-casting implicit and explicit conversion
 */ 
namespace prja
{
    class TCad
    {
        public static void Main()
        {
            int i = 5;
            double x = 6.5;
            int j = (int)x;
            double y= i;
            Console.WriteLine(i);
            Console.WriteLine(x);
            Console.WriteLine(j);
            Console.WriteLine(y);
        }
    }
}
/*
 Output:
 5
 6.5
 6
 5

 */
