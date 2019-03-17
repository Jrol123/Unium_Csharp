using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("enter your strange thing");
            int a = int.Parse(Console.ReadLine());
            switch(a)//переменная, все дела, если равна тому-то,то то-то!
            {
                case 3:
                    a++;
                    Console.WriteLine(a);

                    break;
                case 33:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("SECRET HAS BEEN FOUND");
                    break;
                case 666:
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("WELCOME TO THE HELL!!!");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("#JUSTAUSER");
                    break;

            }
            Console.ReadKey();
        }
    }
}
