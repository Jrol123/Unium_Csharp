using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter amount: (1-999)");
            int summ = int.Parse(Console.ReadLine());
            int a=summ % 100;
            if (summ==1 || summ>=21 && a==1&& summ<=101)
            {
                Console.Write(summ + " " + "рубль");
            }
            else if (summ > 999)
            {
                Console.WriteLine("WWTTFF");
            }
            
            if(summ>=5 && summ<=20 || summ>=22 && a>=5 &&a <=20 || summ >= 111 && a == 1)
            {
                Console.Write(summ + " " + "рублей");
            }
            if(summ >= 2&& summ<=4 || summ>= 22 && a>2 && a<4)
            {
                Console.Write(summ + " " + "рубля");
            }
            
            Console.ReadKey();
        }
    }
}
