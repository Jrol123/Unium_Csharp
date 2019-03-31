using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("all peple");
            double all = double.Parse(Console.ReadLine());
            Console.WriteLine("momos");

            double moms = double.Parse(Console.ReadLine());
            double last = all / 3;
            double moms2 = moms;
            Console.WriteLine();
            while(last != moms2)
            {
                all++;
                moms2++;
                last = all / 3;
                Math.Ceiling(last);
            }

            double less = moms2 - moms;

            if(less == 0)
            {
                Console.WriteLine("already 1/3 soviet is momos");
            }
            else
            {
                Console.WriteLine("U need to add "+ less +" momos");
            }
            
                Console.ReadKey();

        }
    }
}