using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            while(a < 300)
            {
                ++a;
                if (a % 3 == 0 && a % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (0 == a % 3 && 0 != a % 5)
                {
                    Console.Write("Fizz ");
                }
                else if (0 != a % 3 && 0 == a % 5)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(a + " " );
                }
                
            }
            Console.ReadKey();
        }
    }
}
