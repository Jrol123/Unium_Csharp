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
            int a=summ % 10;
            int b=summ % 100;
            if(b>=11&&b<20)
            {
                Console.WriteLine(summ + "рублей");
            }
            else
            {
                if(a==1)
                {
                    Console.WriteLine(summ + "рубль");
                }
                else if(a>=2 && a<=4)
                {
                    Console.WriteLine(summ + "рубля");
                }
                else
                {
                    Console.WriteLine(summ + "рублей");
                    
                }
            }
            
            Console.ReadKey();
        }
    }
}
