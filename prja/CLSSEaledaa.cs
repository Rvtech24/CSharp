using System;
/*
 Example for 'sealed' class concept
 */
namespace prja
{
    class CLSSEaaa
    {
        public CLSSEaaa()
        {
            Console.WriteLine("Constructor: CLSSEaaa");
        }
        ~CLSSEaaa()
        {
            Console.WriteLine("Destructor: CLSSEaaa");
        }
    }
    sealed class CLSSEaab:CLSSEaaa
    {
        public CLSSEaab()
        {
            Console.WriteLine("Constructor: CLSSEaab");
        }
        ~CLSSEaab()
        {
            Console.WriteLine("Destructor: CLSSEaab");
        }

    }
   /* class CLSSEaac : CLSSEaab
    {
        public CLSSEaac()
        {
            Console.WriteLine("Constructor: CLSSEaac");
        }
        ~CLSSEaac()
        {
            Console.WriteLine("Destructor: CLSSEaac");
        }
    }*/
    class CLSSEaledaa
    {
        public static void Main()
        {
            new CLSSEaab();
        }
    }
}

/*
 
Output:

Constructor: CLSSEaaa
Constructor: CLSSEaab

Destructor: CLSSEaab
Destructor: CLSSEaaa

 */

