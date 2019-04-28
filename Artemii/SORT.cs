using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Full pls");
            int full = int.Parse(Console.ReadLine());
            int[] mass = full.ToString().ToCharArray().Select(x => x - '0').ToArray();//дробим в массив

            Console.WriteLine("up/down?");
            string stat = Console.ReadLine();
            if (stat == "up")
            {
                Array.Sort(mass);
            }
            else
            {
                Array.Sort(mass, (x, y) => -x.CompareTo(y));
            }
            foreach (int i in mass)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
