﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlaySomeCards
{
    class Program
    {
        public void Mast(int a, char b)
        {
            a /= 10;
            b = '◘';
            switch(a)
            {
                case 1:
                    char b = '♥';
                    break;
                case 2:
                    char b = '♦';
                    break;
                case 3:
                    char b = '♣';
                    break;
                case 4:
                    char b = '♠';
                    break;
            }
        }
        static void OutCards(char mast, int[,]players)
        {
            for(int z = 0; z < 6; z++)
            {
                char b = '♣';
                foreach (int i in players)
                {
                    int delete = i / 10;
                    string up10 = " ";
                    if(i > 10)
                    {
                        switch (delete)
                        {
                            case 11:

                                break;
                            case 12:

                                break;
                            case 13:

                                break;
                            case 14:

                                break;
                        }
                        Console.Write(up10);
                    }
                    else
                    {
                        Console.Write(i);
                    }
                    char alp = Mast(i, b);
                    Console.WriteLine("{0}, ",alp);
                }
            }
        }
        static void GetCards(int[,]players, int[,]cards, int[,]less, int f, int hand, Random randcs)
        {
            for (; hand < 6; hand++)
            {
                int ranmast = randcs.Next(0, 3);
                int rancards = randcs.Next(0, 8);
                if (cards[ranmast, rancards] == less[ranmast, rancards])
                {
                    hand--;
                    continue;
                }
                else
                {
                    less[ranmast, rancards] = cards[ranmast, rancards];
                }
                players[f,hand] = cards[ranmast, rancards];
            }
        }
        static void Main(string[] args)
        {
            int[,] cards = {{ 61, 71, 81, 191, 101 ,111 ,121 ,131 ,141 },{ 62, 72, 82, 92, 102, 112, 122, 132, 142 },{ 63, 73, 83, 93, 103, 113, 123, 133, 143 },{ 64, 74, 84, 94, 104, 114, 124, 134, 144 } };
            int[,] less = { {0,0,0,0,0,0,0,0,0}, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
            int[] mast = {1,2,3,4};

            int[,] players = { };

            Random randcs = new Random();
            /*
            int cfs = 0;
            int cnd = 0;
            
            Boolean stat = false;
            */
            int win = randcs.Next(0,3);
            int swin = win++;

            //сколько рук?
            Console.WriteLine("Count of player's");
            int playCount = int.Parse(Console.ReadLine());
            int hand = 0;
            //руки игрокам!
            for(int f = 0; f < playCount; f++)
            {
                GetCards(players, cards, less, f, hand, randcs);
            }

            //какие руки, на вывод
            for(int f = 1; f < playCount; f++)
            {
                Console.Write("{0}'s player hand = ", f);
            }       

            Console.WriteLine();
            Console.WriteLine();
            char lol = '◘';
            Mast(swin, lol);
            Console.WriteLine("The mast of winner is: {0}",lol);

            Console.ReadKey();

            /*//подсчет победителя!

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
            }*/
            Console.ReadKey();
        }
    }
}
