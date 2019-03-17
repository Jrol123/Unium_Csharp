using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of month: ");
            int month = int.Parse(Console.ReadLine());
            switch(month)
            {
                case 1:
                    Console.WriteLine("Winter");
                    break;
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                    Console.WriteLine("Spring");
                    break;
                case 4:
                    Console.WriteLine("Spring");
                    break;
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                    Console.WriteLine("Summer");
                    break;
                case 7:
                    Console.WriteLine("Summer");
                    break;
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                    Console.WriteLine("Autumn");
                    break;
                case 10:
                    Console.WriteLine("Autumn");
                    break;
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                case 12:
                    Console.WriteLine("Winter");
                    break;
                default:
                    Console.WriteLine("WTF??? It isn't number of month!!!!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
