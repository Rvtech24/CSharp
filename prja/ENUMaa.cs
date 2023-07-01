using System;
/*
 Example for user-defined datatype (enum)
 */ 
namespace prja
{
    class ENUMaa
    {
        enum CCName
        {
            agriculture, domestic, commercial
        }
        public static void Main()
        {
            CCName ccn;
            ccn = CCName.agriculture;
            Console.WriteLine(ccn + "-" + ccn.GetType());

            Console.WriteLine((int)CCName.agriculture);
            Console.WriteLine((int)CCName.domestic);
            Console.WriteLine((int)CCName.commercial);

            Console.WriteLine((CCName)0);
            Console.WriteLine((CCName)1);
            Console.WriteLine((CCName)2);
        }

    }

}
/*
 Output:

agriculture-prja.ENUMaa+CCName
0
1
2
agriculture
domestic
commercial

 */
