using System;
/*
 Example for Electricity Bill (EB)
 */ 
namespace prja
{
    enum ConsumerCategory
    {
        Agriculture, Domestic, commercial
    }
    class EBaa
    {
        public static void Main()
        {
            int cid = 0;
            Console.Write("\nConsumer ID: ");
            int.TryParse(Console.ReadLine(), out cid);

            int pread = 0;
            Console.Write("\nConsume Previous reading: ");
            int.TryParse(Console.ReadLine(), out pread);

            int cread = 0;
            Console.Write("\nConsume Current Reading: ");
            int.TryParse(Console.ReadLine(), out cread);
            
            if(cread<pread)
            {
                Console.WriteLine("\nInvalid Reading...");
                return;
            }
            ConsumerCategory cc = ConsumerCategory.commercial;
            Console.Write("\nConsumer Category");
            Console.Write("\n0. Agriculture");
            Console.Write("\n1. Domestic");
            Console.Write("\n2. Commercial");
            Console.Write("\n[0,1 or 2]: ");

            int i = 2;
            int.TryParse(Console.ReadLine(), out i);

            if(Enum.IsDefined(typeof(ConsumerCategory),i)==false)
            {
                Console.WriteLine("Invalid: Consumer Category");
                return;
            }
            int nread = cread - pread;
            if(nread<0)
            {
                Console.WriteLine("Invalid: Net Reading");
                return;
            }
            int cuu100 = 0, cuu200 = 0, cuu400 = 0, cua400 = 0;
            if(nread>400)
            {
                cuu100 = 100;
                cuu200 = 100;
                cuu400 = 200;
                cua400 = nread - 400;

            }
            else if(nread>200)
            {
                cuu100 = 100;
                cuu200 = 100;
                cuu400 = nread - 200;

            }
            else if(nread>100)
            {
                cuu100 = 100;
                cuu200 = nread - 200;
            }
            else if(nread>0)
            {
                cuu100 = nread;
            }
            double puau100 = 0, puau200 = 0, puau400 = 0, puaa400 = 0;
            double cuau100 = 0, cuau200 = 0, cuau400 = 0, cuaa400 = 0;
            double mc = -0, taxp = 0, taxa = 0, npay = 0;
            cc = (ConsumerCategory)i;

            if(cc==ConsumerCategory.Agriculture)
            {
                puau100 = 0.25;
                puau200 = 0.50;
                puau400 = 1.50;
                puaa400 = 2.00;
                mc = 12.50;
                taxp = 2.5;
            }
            else if(cc==ConsumerCategory.Domestic)
            {
                puau100 = 0.50;
                puau200 = 1.00;
                puau400 = 3.00;
                puaa400 = 6.00;
                mc = 25.00;
                taxp = 5.0;
            }
            else if(cc==ConsumerCategory.commercial)
            {
                puau100 = 1.00;
                puau200 = 2.00;
                puau400 = 6.00;
                puaa400 = 10.00;
                mc = 200.00;
                taxp = 7.5;
            }
            cuau100 = puau100 * cuu100;
            cuau200 = puau200 * cuu200;
            cuau400 = puau400 * cuu400;
            cuaa400 = puaa400 * cua400;

            taxa = (taxp / 100) * cuaa400;
            npay = cuau100 + cuau200 + cuau400 + cuaa400 + taxa + mc;

            Console.WriteLine("Consumer Net Reading: " + nread);

            if(cuau100>0)
            {
                Console.WriteLine("Per unit amount up to 100: " + puau100);
                Console.WriteLine("Consume unit up to 100: " + cuu100);
                Console.WriteLine("Consume unit amount up to 100: " + cuau100);
            }
            if(cuau200>0)
            {
                Console.WriteLine("Per unit amount up to 200: " + puau200);
                Console.WriteLine("Consume unit up to 200: " + cuu200);
                Console.WriteLine("Consume unit amount up to 200: " + cuau200);
            }
            if(cuau400>0)
            {
                Console.WriteLine("Per unit amount up to 400: " + puau400);
                Console.WriteLine("Consume unit up to 400: " + cuu400);
                Console.WriteLine("Consume unit amount up to 400: " + cuau400);
            }
            if(cuaa400>0)
            {
                Console.WriteLine("Per unit amount above 400: " + puaa400);
                Console.WriteLine("Consume unit above 400: " + cua400);
                Console.WriteLine("Consume unit amount above 400: " + cuaa400);

                Console.WriteLine("Tax amount: " + taxa);
            }

            Console.WriteLine("Meter Charge: " + mc);
            Console.WriteLine("Net pay: " + npay);
        }
    }
}
/*
 Output:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 50

Consumer Category 
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 0
Consumer Net Reading: 50
Per unit amount up to 100: 0.25
Consume unit up to 100: 50
Consume unit amount up to 100: 12.5
Meter Charge: 12.5
Net pay: 25

Output-2:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 150

Consumer Category
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 0
Consumer Net Reading: 150
Per unit amount up to 100: 0.25
Consume unit up to 100: 100
Consume unit amount up to 100: 25
Meter Charge: 12.5
Net pay: 12.5 

Output-3:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 350

Consumer Category
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 0
Consumer Net Reading: 350
Per unit amount up to 100: 0.25
Consume unit up to 100: 100
Consume unit amount up to 100: 25
Per unit amount up to 200: 0.5
Consume unit up to 200: 100
Consume unit amount up to 200: 50
Per unit amount up to 400: 1.5
Consume unit up to 400: 150
Consume unit amount up to 400: 225
Meter Charge: 12.5
Net pay: 312.5

Output-4:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 550

Consumer Category
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 0
Consumer Net Reading: 550
Per unit amount up to 100: 0.25
Consume unit up to 100: 100
Consume unit amount up to 100: 25
Per unit amount up to 200: 0.5
Consume unit up to 200: 100
Consume unit amount up to 200: 50
Per unit amount up to 400: 1.5
Consume unit up to 400: 200
Consume unit amount up to 400: 300
Per unit amount above 400: 2
Consume unit above 400: 150
Consume unit amount above 400: 300
Tax amount: 7.5
Meter Charge: 12.5
Net pay: 695

    Output-5:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 50

Consumer Category
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 1
Consumer Net Reading: 50
Per unit amount up to 100: 0.5
Consume unit up to 100: 50
Consume unit amount up to 100: 25
Meter Charge: 25
Net pay: 50

Output-6:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 150

Consumer Category
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 1
Consumer Net Reading: 150
Per unit amount up to 100: 0.5
Consume unit up to 100: 100
Consume unit amount up to 100: 50
Meter Charge: 25
Net pay: 25

Output-7:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 350

Consumer Category
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 1
Consumer Net Reading: 350
Per unit amount up to 100: 0.5
Consume unit up to 100: 100
Consume unit amount up to 100: 50
Per unit amount up to 200: 1
Consume unit up to 200: 100
Consume unit amount up to 200: 100
Per unit amount up to 400: 3
Consume unit up to 400: 150
Consume unit amount up to 400: 450
Meter Charge: 25
Net pay: 625

Output-8:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 550

Consumer Category
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 1
Consumer Net Reading: 550
Per unit amount up to 100: 0.5
Consume unit up to 100: 100
Consume unit amount up to 100: 50
Per unit amount up to 200: 1
Consume unit up to 200: 100
Consume unit amount up to 200: 100
Per unit amount up to 400: 3
Consume unit up to 400: 200
Consume unit amount up to 400: 600
Per unit amount above 400: 6
Consume unit above 400: 150
Consume unit amount above 400: 900
Tax amount: 45
Meter Charge: 25
Net pay: 1720

Output-9:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 50

Consumer Category
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 2
Consumer Net Reading: 50
Per unit amount up to 100: 1
Consume unit up to 100: 50
Consume unit amount up to 100: 50
Meter Charge: 200
Net pay: 250

Output-10:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 150

Consumer Category
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 2
Consumer Net Reading: 150
Per unit amount up to 100: 1
Consume unit up to 100: 100
Consume unit amount up to 100: 100
Meter Charge: 200
Net pay: 200

Output-11:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 350

Consumer Category
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 2
Consumer Net Reading: 350
Per unit amount up to 100: 1
Consume unit up to 100: 100
Consume unit amount up to 100: 100
Per unit amount up to 200: 2
Consume unit up to 200: 100
Consume unit amount up to 200: 200
Per unit amount up to 400: 6
Consume unit up to 400: 150
Consume unit amount up to 400: 900
Meter Charge: 200
Net pay: 1400

Output-12:

Consumer ID: 1001

Consume Previous reading: 0

Consume Current Reading: 550

Consumer Category
0. Agriculture
1. Domestic
2. Commercial
[0,1 or 2]: 2
Consumer Net Reading: 550
Per unit amount up to 100: 1
Consume unit up to 100: 100
Consume unit amount up to 100: 100
Per unit amount up to 200: 2
Consume unit up to 200: 100
Consume unit amount up to 200: 200
Per unit amount up to 400: 6
Consume unit up to 400: 200
Consume unit amount up to 400: 1200
Per unit amount above 400: 10
Consume unit above 400: 150
Consume unit amount above 400: 1500
Tax amount: 112.5
Meter Charge: 200
Net pay: 3312.5
*/
