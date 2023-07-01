using System;
/*
 Example for Access Specifier: 'private' and 'public'
 */ 

namespace prja
{
    class CLSASba
    {
        private int x;

        public void setData(int i)
        {
            x = i;
        }
        public void showData()
        {
            Console.WriteLine("x: " + x);
        }
    }
    class CLSASbb
    {
        public static void Main()
        {
            CLSASba ba = new CLSASba();
            ba.setData(5);
            ba.showData();
        }
    }
}
/*
 Output:
 
    x: 5

 */
