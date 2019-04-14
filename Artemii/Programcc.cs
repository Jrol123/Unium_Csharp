using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Mainx(string[] args)
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
        static void Main1(string[] args)
        {
            int F1 = 0;
            int F2 = 1;
            int t = 0;

            Console.WriteLine("How many numbers u want to get?");
            int count = int.Parse(Console.ReadLine());
            count--;

            for (int i = 0; i <= count; i++)
            {
                t = F2 + F1;
                F1 = F2;
                F2 = t;

                Console.WriteLine(t);
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            string semp;
            string st = "";
            string nd = "";
            int exit = 0;
            int sts;
            int nds;
            int sump;
            Boolean and;
            Boolean bnd;
            Boolean simp;

            do
            {

                do
                {
                    Console.WriteLine("enter 1st");
                    st = Console.ReadLine();

                    and = int.TryParse(st, out sts);
                    if (and == false)
                    {
                        Console.WriteLine("ERROR!!!");
                    }
                    else
                    {

                    }

                } while (and != true);

                do
                {
                    Console.WriteLine("enter 2nd");
                    nd = Console.ReadLine();

                    bnd = int.TryParse(nd, out nds);
                    if(bnd == false)
                    {
                        Console.WriteLine("ERROR!!!");
                    }
                    else
                    {

                    }
                    
                  }while (bnd !=true);
                do
                {
                    Console.WriteLine("what?");
                    semp = Console.ReadLine();

                    simp = int.TryParse(semp, out sump);
                    if (semp == "0")
                    {
                        break;
                    }
                    else if (semp != "/" && semp != "*" && semp != "+" && semp != "-")
                    {
                        Console.WriteLine("ERROR!!!");
                    }
                    else
                    {
                        simp = true;
                    }
                } while (simp != true);

                if (sump == 0)
                {
                    Console.WriteLine("GoodBye!");
                }
                else
                {
                    if(semp == "/")
                    {
                        if(nds == 0 || sts == 0)
                        {
                            Console.WriteLine("ERROR!!!");
                        }
                        else
                        {
                            exit = sts / nds;
                            Console.WriteLine("result is: " + exit);
                        }
                    }
                    else if(semp =="*")
                    {
                        exit = sts * nds;
                        Console.WriteLine("result is: " + exit);
                    }
                    else if (semp == "+")
                    {
                        exit = sts + nds;
                        Console.WriteLine("result is: " + exit);
                    }
                    else
                    {
                        exit = sts - nds;
                        Console.WriteLine("result is: " + exit);
                    }
                }

                Console.ReadKey();
                Console.Clear();

            } while (semp != "0");
        }
    }
}