/*using System;

 Example for 'protected' access specifier (or modifier)

namespace prja.AccessSpecifier
{
    class CLSASda
    {
        protected int x;

    }
    class CLSASdb:CLSASda
    {
        public void showData()
        {
            Console.WriteLine(x);
        }
    }
    class CLSASdc
    {
        public static void Main()
        {
            CLSASdb db = new CLSASdb();
            db.showData();
            //Console.WriteLine(db.x);
        }
    }
}

 Output:
 
    0

 */
