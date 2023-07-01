using System;
/*
 Example for 'public' access specifier (or modifier)
 */ 

namespace prja.AccessSpecifier
{
    class CLSASea
    {
        public int x;
    }
    class CLSASeb:CLSASea
    {
        public void showData()
        {
            Console.WriteLine(x);
        }
    }
    class CLSASec
    {
        public static void Main()
        {
            CLSASeb eb = new CLSASeb();
            eb.showData();
            Console.WriteLine(eb.x);
        } 
    }
}
/*
 Output:

0
0
 */
