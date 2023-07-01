using System;
/*
 Example for sub-program category: procedure
 */ 

namespace prja
{
    class SPab
    {
        public void udSum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void udMinus(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public static void Main()
        {
            SPab spb = new prja.SPab();
            spb.udSum(1, 9);
            SPab.udMinus(6, 3);
        }
    }
}
/*
 10
 3
 */
