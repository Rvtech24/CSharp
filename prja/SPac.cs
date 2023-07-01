using System;
/*
 below class(SPac) call user-defind class library(UDCLmath)
 */ 
namespace prja
{
    class SPac
    {
        public static void Main()
        {
            UDCLmath umath = new UDCLmath();
            Console.WriteLine(umath.udmSum(1, 9));
            umath.udmMultiply(2, 8);
            Console.WriteLine(UDCLmath.udmMinus(6, 2));
            UDCLmath.udmDivide(20, 3);
        }
    }
}
/*
 Output:
  10
  16
  4
  6
 */
