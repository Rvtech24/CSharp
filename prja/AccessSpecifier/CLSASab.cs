using System;
/*
 Example for Access Specifier: 'private'
 */
namespace prja
{
    class CLSASaa
    {
        private int i;
    }
    class CLSASab
    {
        public static void Main()
        {
            CLSASaa aa = new CLSASaa();
            //Console.WriteLine(aa.i);
        }
    }
}
