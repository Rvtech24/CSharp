using System;
/*
 Example for Multilevel inheritance with Constructor and Destructor feature
 */ 
namespace prja.inheritance
{
    class CLSMLIaa
    {
        public CLSMLIaa()
        {
            Console.WriteLine("Constructor: CLSMLIaa");
        }
        ~CLSMLIaa()
        {
            Console.WriteLine("Destructor: CLSMLIaa");
        }

    }
    class  CLSMLIab:CLSMLIaa
        {
         public CLSMLIab()
        {
            Console.WriteLine("Constructor: CLSMLIab");
        }
        ~CLSMLIab()
        {
            Console.WriteLine("Destructor: CLSMLIab");
        }
        }
    class CLSMLIac:CLSMLIab
    {
        public CLSMLIac()
        {
            Console.WriteLine("Constructor: CLSMLIac");
        }
        ~CLSMLIac()
        {
            Console.WriteLine("Destructor: CLSMLIac");
        }
    }
    class CLSMLIad
    {
        public static void Main()
        {
            new CLSMLIac();
        }
    }
}
/*
 Output:
  
Constructor: CLSMLIaa
Constructor: CLSMLIab
Constructor: CLSMLIac

Destructor: CLSMLIac
Destructor: CLSMLIab
Destructor: CLSMLIaa
 
*/
