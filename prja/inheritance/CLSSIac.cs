using System;
/*
Example for Single inheritance with Constructor and Destructor features 
*/
  

namespace prja.inheritance
{
    class CLSSIaa
    {
        public CLSSIaa()
        {
            Console.WriteLine("Constructor: CLSSIaa");
        }
        ~CLSSIaa()
        {
            Console.WriteLine("Destructor: CLSSIaa");
        }
    }
    class CLSSIab:CLSSIaa
    {
        public CLSSIab()
        {
            Console.WriteLine("Constructor: CLSSIab");
        }
        ~CLSSIab()
        {
            Console.WriteLine("Destructor:CLSSIab"); 
        }
    }
    class CLSSIac
    {
        public static void Main()
        {
            new CLSSIab();
        }
    }
}
/*
 Output:
 
Constructor: CLSSIaa
Constructor: CLSSIab

Destructor:CLSSIab
Destructor: CLSSIaa
     
 */

