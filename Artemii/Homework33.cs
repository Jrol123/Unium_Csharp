using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main1(string[] args)
        {
            int summ = 0;
            int multip = 1;

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            int[] mass = num.ToString().ToCharArray().Select(x => x - '0').ToArray();//дробим в массив
            int count = mass.Length - 1;//кол-во цифр в числе

            for (int i = 0; i <= count; i++)//сумма && умножение
            {
                summ += mass[i];
                multip *= mass[i];
            }

            Console.WriteLine("summ = " + summ);
            Console.WriteLine("multipl. = " + multip);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int[] fibon = {0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181,6765,10946,17711};

            Console.WriteLine("How many numbers u want to get?");
            int count = int.Parse(Console.ReadLine());
            count --;

            for (int i = 0;i <= count; i++)
            {
                Console.WriteLine(fibon[i]);
            }

            Console.ReadKey();
        }
    }
}
