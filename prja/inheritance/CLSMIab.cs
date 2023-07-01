﻿using System;
/*
 Example for Multiple inheritance with Constructor and Destructor features
 */
namespace prja.inheritance
{
    interface ITMIaa
    {
        void uSum(int x, int y);
        double uMinus(double x, double y);
    }
    interface ITMIab
    {
        int uMultiply(int x, int y);
        void uDIvide(double x, double y);
    }
    class CLSMIaa:ITMIaa,ITMIab
    {
        public CLSMIaa()
        {
            Console.WriteLine("Constructor: CLSMIaa");
        }
        ~CLSMIaa()
        {
            Console.WriteLine("Destructor: CLSMIaa");
        }
        public void uSum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public double uMinus(double x, double y)
        {
            return x-y;
        }
        public int uMultiply(int x, int y)
        {
            return x * y;
        }
        public void uDivide(double x, double y)
        {
            Console.WriteLine(x / y);
        }

        public void uDIvide(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
    class CLSMIab
    {
        public static void Main()
        {
            CLSMIaa aa = new CLSMIaa();

            aa.uSum(1, 9);
            Console.WriteLine(aa.uMinus(8, 5));

            Console.WriteLine(aa.uMultiply(2, 7));
            aa.uDivide(20, 3);
        }
    }
}
/*
 Output:

Constructor: CLSMIaa
10
3
14
6.66666666666667
Destructor: CLSMIaa

 */
