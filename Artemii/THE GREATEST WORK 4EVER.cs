using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class WORK
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter full number");
            int full = int.Parse(Console.ReadLine());

            int[] mass = full.ToString().ToCharArray().Select(x => x - '0').ToArray();//дробим в массив
            int count = mass.Length;

            int y = count % 2;

            int alpha = 1;
            int z = 1;
            double first;
            double last;
            bool stat;
            int a = 0;
            int b = count - 1;

            if (y == 0) //если четное
            {
                stat = true;
                first = (count /2) - 1; //конец 1ой части выражения
                last = first+1; //начало 2ой части выражения
            }
            else //если нечетное
            {
                stat = false;
                z = (count - 1) / 2;// середина
                first = z+1;
                last = z-1;
            }
            /*for (int i = 0; i < count-1; i++)
            {
                alpha *= 10;
            }*/
            if (stat == true)
            {
                do
                {
                    
                    int less = mass[a] - mass[b];
                    if (mass[a] == mass[b])
                    {
                    }
                    else
                    {
                        if (a == first && b == last)
                        {
                            if (mass[a] > mass[b])
                            {
                                full = full + alpha * (mass[a] - mass[b]);
                            }
                            else if (mass[a] < mass[b])
                            {
                                full = full + 10*alpha * (mass[b] - mass[a]);
                            }


                        }
                        else if (less < 0)
                        {
                            full = full + (alpha*(10 + less));
                        }

                        else if (less > 0)
                        {
                            full = full + (alpha*(mass[b]+(mass[a]-mass[b])));
                        }
                    }
                    mass = full.ToString().ToCharArray().Select(x => x - '0').ToArray();//повтор для точности!
                    alpha *= 10;
                    a++;
                    b--;
                } while (a != first+1 && b != last-1);
            }
            else
            {
                do
                {

                    int less = mass[a] - mass[b];
                    if (mass[a] == mass[b])
                    {
                    }
                    else
                    {
                        if (less < 0)
                        {
                            full = full + (alpha * (10 + less));
                        }

                        else if (less > 0)
                        {
                            full = full + (alpha * (mass[b] + (mass[a] - mass[b])));
                        }
                    }
                    mass = full.ToString().ToCharArray().Select(x => x - '0').ToArray();//повтор для точности!
                    alpha *= 10;
                    a++;
                    b--;
                } while (a != z && b != z);
            }
            Console.WriteLine(full);

            Console.ReadKey();
        }
    }
}
