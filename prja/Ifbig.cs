using System;
/*
 Find bigest  number between three numbers using 'if' conditional statement 
 */ 

namespace prja
{
    class Ifbig
    {
        public  static void Main()
        {
            int i = 5, j = 9, k = 2;
            if(i>j && i>k)
            {
                Console.WriteLine("Bigest number is: " + i);
            }
            else if(j>k)
            {
                Console.WriteLine("Bigest number is: " + j);
            }
            else
            {
                Console.WriteLine("Bigest number is: " + k);
            }
        }
    }
}

/*
 Output:
 
 Bigest number is: 9
 Press any key to continue . . .

 */
