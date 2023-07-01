﻿using System;
/*
 Example for 'call by value' and 'call by reference'
 */ namespace prja
{
    class CLSCBVCBRaa
    {
        public static void uSwap(int i, int j)
        {
            i = i + j;
            j = i - j;
            i = i - j;
            Console.WriteLine("swap[i]:" + i);
            Console.WriteLine("swap[j]:" + j);
        }
        public static void uExchange(ref int i, ref int j)
        {
            i = i + j;
            j = i - j;
            i = i - j;

            Console.WriteLine("uExchange[i]:" + i);
            Console.WriteLine("uExchange[j]:" + j);

        }
        public static void Main()
        {
            int a = 5, b = 2;
            int x = 4, y = 9;

            Console.WriteLine("before swap[i]:" + a);
            Console.WriteLine("before swap[j]:" + b);
            uSwap(a, b);
            Console.WriteLine("after swap[i]:" + a);
            Console.WriteLine("after swap[j]:" + b);

            Console.WriteLine("before Exchange[x]:" + x);
            Console.WriteLine("before Exchange[y]:" + y);
            uExchange(ref x, ref y);

            Console.WriteLine("after Exchange[y]:" + x);
            Console.WriteLine("after Exchange[y]:" + y);

        }
    }
}

/*
 
Output:

before swap[i]:5
before swap[j]:2

swap[i]:2
swap[j]:5

after swap[i]:5
after swap[j]:2

before Exchange[x]:4
before Exchange[y]:9

uExchange[i]:9
uExchange[j]:4

after Exchange[y]:9
after Exchange[y]:4

 */
