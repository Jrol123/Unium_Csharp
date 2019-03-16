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
            Console.WriteLine("How much is the total purchase?");
            double summ = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("What is the percentage discount?");
            double discount = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Total puchase with discount:");
            double total = summ-((summ / 100) * discount);
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
