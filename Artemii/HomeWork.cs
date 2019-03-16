using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procents_branchess
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("How much is the total purchase?");
             double summ = double.Parse(Console.ReadLine());
             Console.WriteLine(" ");
             Console.WriteLine("What is the percentage discount?");
             double discount = double.Parse(Console.ReadLine());
             Console.WriteLine(" ");
             Console.Write("Total puchase with discount:");
             double total = summ-((summ / 100) * discount);
              Math.Round(total);//Doesn't work!
             Console.WriteLine(total);
             Console.ReadKey();
             */

            Console.Write("enter 3 numbers to sort: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int b = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int c = int.Parse(Console.ReadLine());
            if (a > b && c < b)
            {
                Console.Write("Numbers in ascending order: ");

                Console.Write(a);
                Console.Write(" ");
                Console.Write(b);
                Console.Write(" ");
                Console.Write(c);

            }

             else if (a > b && b < c)
            {
                Console.Write("Numbers in ascending order: ");

                Console.Write(a);
                Console.Write(" ");
                Console.Write(c);
                Console.Write(" ");
                Console.Write(b);
             }

             else if(b>a && a<c)
             {
                Console.Write("Numbers in ascending order: ");

                Console.Write(b);
                Console.Write(" ");
                Console.Write(c);
                Console.Write(" ");
                Console.Write(a);
             }

             else if (b > a && c < a)
             {
                Console.Write("Numbers in ascending order: ");

                Console.Write(b);
                Console.Write(" ");
                Console.Write(a);
                Console.Write(" ");
                Console.Write(c);
             }

             else if (c > b && a < b)
            {
                 Console.Write("Numbers in ascending order: ");

                Console.Write(c);
                Console.Write(" ");
                Console.Write(b);
                Console.Write(" ");
                Console.Write(a);
             }

             else if (c > b && b < a)
             {
                Console.Write("Numbers in ascending order: ");

                Console.Write(c);
                Console.Write(" ");
                Console.Write(a);
                Console.Write(" ");
                Console.Write(b);
             }

            Console.ReadKey();
        }
    }
}
