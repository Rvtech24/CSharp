using System;
/*
 Example for inheritance: Single inheritance
 */ 

namespace prja
{
    class CLSASca
    {
        public void udpSum(int i, int j)
        {
            Console.WriteLine(i + j);
        }
        public int udfMinus(int i, int j)
        {
            return i - j;
        }
    }
    class CLSAScb:CLSASca
    {
        public void udpMultiply(int i, int j)
        {
            Console.WriteLine(i * j);
        }
        public int udfDivide(int i, int j)
        {
            return i / j;
        }
        public static void Main()
        {
            CLSAScb cb = new CLSAScb();
            cb.udpSum(1,8);
            cb.udpMultiply(2, 7);
            Console.WriteLine(cb.udfMinus(5, 4));
            Console.WriteLine(cb.udfDivide(20, 6));
        }
    }
}
/*
 Output:

9
14
1
3

 */
