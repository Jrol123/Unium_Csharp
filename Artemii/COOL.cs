using System;
using System.Linq;

namespace ConsoleApp24
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("enter full number");
            long full = long.Parse(Console.ReadLine());

            int[] mass = full.ToString().ToCharArray().Select(x => x - '0').ToArray();//дробим в массив
            int count = mass.Length;//длина
            int unzero = 0;

            for(int i = 0; i<count; i++)
            {
                if(mass[i] == 0)
                {

                }
                else
                {
                    unzero++;
                }     
            }
            Console.WriteLine("antizero = " + unzero);
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            Boolean stat = false;
            int count = 0;
            int[] mass;
            int f = 0;
            do
            {
                Console.WriteLine("enter full number");
                long full = long.Parse(Console.ReadLine());

                mass = full.ToString().ToCharArray().Select(x => x - '0').ToArray();//дробим в массив
                count = mass.Length;//длина

                for (int i = 0; i < count; i++)
                {
                    if (mass[i] == 0)
                    {
                        Console.WriteLine("ERROR");
                        Console.ReadKey();
                        stat = false;
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        stat = true;
                    }
                }
            } while (stat != true);

            do
            {
                for(int i = 1; i < count; i++)
                {
                    if (mass[f] < mass[i])
                    {
                        stat = false;
                        f++;
                        break;
                    }
                    else
                    {
                        stat = true;
                    }
                }
            } while (stat!=true);

            Console.WriteLine("The most powerfull is: " + mass[f]);

            Console.ReadKey();
            
            
        }
        static void Main3(string[] args)
        {
            Console.WriteLine("enter full number");
            long full = long.Parse(Console.ReadLine());

            Console.WriteLine("how many???");
            int user = int.Parse(Console.ReadLine());

            int damn = 0;
            int[] mass = full.ToString().ToCharArray().Select(x => x - '0').ToArray();//дробим в массив
            int unzero = 0;

            for (int i = 0; i < user; i++)
            {
                if (mass[i] == 0)
                {

                }
                else
                {
                    damn+=mass[i];
                    unzero++;
                }
            }
            Console.WriteLine("rdy: " + damn/unzero);
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            int[] mass = {3,6,8,1,0};

            Console.WriteLine("enter");
            int user = int.Parse(Console.ReadLine());

            Boolean stat = false;

            for (int i = 0; i <mass.Length;i++)
            {
                if(user == mass[i])
                {
                    stat = true;
                }
                else
                {

                }
            }
            if(stat == true)
            {
                Console.WriteLine("yup, it does");
            }
            else
            {
                Console.WriteLine("nop, it doesn't");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter full number");
            long full = long.Parse(Console.ReadLine());

            int[] mass = full.ToString().ToCharArray().Select(x => x - '0').ToArray();//дробим в массив
            int count = mass.Length;//длина
            int d = 0;
            int f1 = 0;
            int i = 1;
            int f = mass[i] - mass[d];
            Boolean stat = false;
            d++;
            i++;
            for(; i < count;i++)
            {
                d = i-1;
                f1 = mass[i]-mass[d];
                if (f != f1)
                {
                    stat = false;
                    break;
                }
                else
                {
                    stat = true;
                }
            }
            if(stat == true)
            {
                Console.WriteLine("GJ");
            }
            else
            {
                Console.WriteLine("BJ");
            }
            Console.ReadKey();
        }
    }
}
