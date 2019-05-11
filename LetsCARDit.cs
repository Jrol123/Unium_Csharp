using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlaySomeCards
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] cards = {{ 61, 71, 81, 191, 101 ,111 ,121 ,131 ,141 },{ 62, 72, 82, 92, 102, 112, 122, 132, 142 },{ 63, 73, 83, 93, 103, 113, 123, 133, 143 },{ 64, 74, 84, 94, 104, 114, 124, 134, 144 } };
            int[,] less = { {0,0,0,0,0,0,0,0,0}, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
            int[] mast = {1,2,3,4};

            int[] firstplay = new int [6];
            int[] secondplay = new int[6];

            Random randcs = new Random();
            int ranmast;
            int rancards;
            int cfs = 0;
            int cnd = 0;
            Boolean stat = false;
            int win = randcs.Next(0,3);
            int swin = win++;

            //руки игрокам!

            for(int i = 0;i < 6;i++)
            {
                ranmast = randcs.Next(0, 3);
                rancards = randcs.Next(0, 8);
                if (cards[ranmast, rancards] == less[ranmast, rancards])
                {
                    i--;
                    continue;
                }
                else
                {
                    less[ranmast, rancards] = cards[ranmast, rancards];
                }
                firstplay[i] = cards[ranmast,rancards];
            }
            for (int i = 0; i < 6; i++)
            {
                ranmast = randcs.Next(0, 3);
                rancards = randcs.Next(0, 8);
                if (cards[ranmast, rancards] == less[ranmast, rancards])
                {
                    i--;
                    continue;
                }
                else
                {
                    less[ranmast, rancards] = cards[ranmast, rancards];
                }
                secondplay[i] = cards[ranmast, rancards];
            }

            //какие руки, на вывод

            Console.Write("firstplayer's hand = ");
            foreach(int i in firstplay)
            {
                Console.Write("{0},",i);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("secondplayer's hand = ");
            foreach (int i in secondplay)
            {
                Console.Write("{0},", i);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The mast of winner is: {0}",swin);

            Console.ReadKey();

            //подсчет победителя!

            for (int y = 0; y < 6; y++)
            {
                int fst = firstplay[y];

                for (int i = 0; i < 6; i++)
                {
                    int scd = secondplay[i];
                    if (fst % 10 == scd % 10)
                    {
                        if (scd > fst)
                        {
                            stat = false;
                            break;
                        }
                        else
                        {
                            stat = true;
                        }

                    }
                    else if(fst % 10 == win)
                    {
                        stat = true;
                    }
                    else if (scd % 10 == win)
                    {
                        stat = false;
                        break;
                    }

                }
                if (stat == false)
                {
                    cnd++;
                }
                else
                {
                    cfs++;
                }
            }

            //кто победил, на вывод
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("score of first player is: {0}", cfs);
            Console.WriteLine("score of second player is: {0}", cnd);
            if(cfs > cnd)
            {
                Console.WriteLine("First player wins!");
            }
            else if (cfs < cnd)
            {
                Console.WriteLine("Second player wins!");
            }
            else
            {
                Console.WriteLine("Everybody loose!");
            }
            Console.ReadKey();
        }
    }
}
