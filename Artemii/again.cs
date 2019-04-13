using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] x = { 0, 1, 2, 3, 4 };
            int count = x.Length - 1;
            Console.Write("x  = ");
            int i;
            int y1 = 0;
            int y2 = 0;
            for (i = 0; i !=count; i++)
            {
                Console.Write(x[i] + ", ");

            }

            Console.WriteLine();

            Console.Write("y1 = ");
            for (i = 0; i != count; i++)
            {
                y1 = 2*x[i]+1;
                Console.Write(y1 + ", ");

            }

            Console.WriteLine();

            Console.Write("y2 = ");
            for (i = 0; i != count; i++)
            {
                y2 = x[i] * x[i];
                Console.Write(y2 + ", ");

            }

            Console.ReadKey();
            */
            int i = 0;
            Console.WriteLine("   Mon,   Thue,   Wensd,  Thur,   Frid.");
            for (i = 1; i !=8;i++)
            {
                Console.WriteLine(i + " _____   _____   _____   _____   _____");
            }


            Console.ReadKey();
        }
    }
}
