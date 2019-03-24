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
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("momos");
            int K = int.Parse(Console.ReadLine());
            int tri = N / 3;
            int count = tri - K;
            if (count <= 0)
            {
                Console.WriteLine("u need no momos");
            }
            else if (count > 0)
            {
                Console.WriteLine("u need " + count + "momos");
            }
            Console.ReadKey();

        }
    }
}
