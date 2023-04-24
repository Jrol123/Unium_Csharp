using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additional_pylons
{
    class Program
    {
        static void Main(string[] args)
        {
            Random roll = new Random();//Создание переменной для random чисел;
            int x = roll.Next(1,15);//Next - за рандомизацию (от,до);
            int alph;

            List<long> nums = new List<long>();//динамический массив  List <тип> название = new List<тип>();

            List<long> impp = new List<long>();
            List<long> impm = new List<long>();

            for (int i = 0; i < x; i++)
            {
                alph = roll.Next(-9,9);
                nums.Add(alph);
            }

            Console.WriteLine("Basic is:");
            foreach(int i in nums)
            {
                Console.Write("," + i);
            }

            for(int i = 0; i < x; i++)
            {
                if(nums[i]>0)
                {
                    impp.Add(nums[i]);
                }
                else if (nums[i] < 0)
                {
                    impm.Add(nums[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Plus is:");
            foreach (int i in impp)
            {
                Console.Write("," + i);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Minus is:");
            foreach (int i in impm)
            {
                Console.Write("," + i);
            }

            Console.ReadKey();
        }
    }
}
