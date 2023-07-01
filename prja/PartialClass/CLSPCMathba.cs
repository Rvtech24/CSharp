using System;
namespace prja.PartialClass
{
    class CLSPCMathba
    {
        public static void Main()
        {
            CLSPCMathaa aa = new CLSPCMathaa();

            Console.WriteLine(aa.i);
            Console.WriteLine(aa.j);

            aa.uMinus(8, 3);
            Console.WriteLine(aa.uSum(4, 3));
        }
    }
}
/*
 Output:

7
2
5
7

 */
