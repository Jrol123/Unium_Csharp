﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlaySomeCards
{
    class Program
    {
        static void Mast(int a, out char mast)
        {
            a %= 10;
            mast = '◘';
            switch (a)
            {
                case 1:
                    mast = '♥';
                    break;
                case 2:
                    mast = '♦';
                    break;
                case 3:
                    mast = '♣';
                    break;
                case 4:
                    mast = '♠';
                    break;
            }
        }//какие масти?

        static void OutCards(List<List<int>> players, int hand, int z)
        {
            for (int y = 0; y < hand; y++)
            {
                int i = players[z][y];
                int delete = i / 10;
                string up10 = " ";
                if (delete > 10)
                {
                    switch (delete)
                    {
                        case 11:
                            up10 = "В";
                            break;
                        case 12:
                            up10 = "Д";
                            break;
                        case 13:
                            up10 = "К";
                            break;
                        case 14:
                            up10 = "Т";
                            break;
                    }
                    Console.Write(up10);
                }
                else
                {
                    Console.Write(delete);
                }
                Mast(i, out char alp);
                Console.Write("{0}, ", alp);
            }
            Console.WriteLine();
        }//какие карты?

        static void GetCards(List<List<int>> players, List<List<int>> cards, int f, int hand, Random randcs, int countMast, out List<List<int>> play, out Boolean statrat, out int counttMast)
        {
            Boolean statDeck = true;
            for (; hand < 6; hand++)
            {

                int ranmast = randcs.Next(0, countMast);
                int LenCards = cards[ranmast].Count;
                int rancards = randcs.Next(0, LenCards);

                players[f].Add(cards[ranmast][rancards]);
                cards[ranmast].Remove(cards[ranmast][rancards]);

                int fullDeck = (cards[0].Count + cards[1].Count + cards[2].Count + cards[3].Count);

                if(fullDeck == 0)
                {
                    statDeck = false;
                    break;
                }
                if (LenCards == 0)//удаление ненужного
                {
                    cards.RemoveAt(ranmast);
                    countMast--;
                }
            }
            play = players;
            hand = 0;
            statrat = statDeck;
            counttMast = countMast;

        }//добор карт
        //работает корректно только на 2х игроков!
        static void Main(string[] args)
        {
            List<List<int>> players = new List<List<int>>();
            List<List<int>> cards = new List<List<int>>();

            int[] mast = { 1, 2, 3, 4 };

            Random randcs = new Random();
            /*
            int cfs = 0;
            int cnd = 0;
            
            Boolean stat = false;
            */
            int win = randcs.Next(0, 3);
            int swin = win++;
            swin += 10;

            //сколько рук?

            Console.WriteLine("Count of player's");
            int playCount = int.Parse(Console.ReadLine());

            for (int f = 0; f < playCount; f++)//добавляем игроков
            {
                players.Add(new List<int>());
            }
            int hand = 0;

            for (int f = 0; f < 4; f++)//картишки в колоду!
            {
                cards.Add(new List<int>());
                int ff = f + 1;
                for (int z = 6; z < 15; z++)
                {
                    int y = z - 6;
                    int alph = z * 10;
                    cards[f].Add(alph + ff);
                }
            }

            //руки игрокам!
            Boolean status = true;
            int countMast = 3;

            if (status != false)
            {
                for (int f = 0; f < playCount; f++)
                {
                    if (status != false)
                    {
                        GetCards(players, cards, f, hand, randcs, countMast, out List<List<int>> play, out Boolean statDeck,out int cM);
                        players = play;
                        status = statDeck;
                        countMast = cM;
                    }
                    else
                    {
                        break;
                    }
                }
                hand = 6;
            }

            //какие руки, на вывод
            for (int f = 0; f < playCount; f++)
            {
                int ff = f + 1;
                Console.Write("{0}'st player hand = ", ff);
                OutCards(players, hand, f);
            }

            Console.WriteLine();
            Console.WriteLine();

            Mast(swin, out char lol);
            char lel = lol;
            Console.WriteLine("The mast of winner is:" +  lel);

            swin /= 10;
            Console.ReadKey();



            //НАЧАЛО ИГРЫ!
            Boolean winner = false;

            while(winner != true)
            {
                Boolean stati = false;
                int f = 0;
                int playEnd = playCount--;

                if(f == playCount)
                {
                    f = 0;
                }

                int ff = f++;

                if (f == playEnd)
                {
                    ff = 0;
                }

                List<int> attack = players[f];
                List<int> defend = players[ff];

                List<int> CardGG = new List<int> { };
                List<int> SecondGG = new List<int> { };
                List<int> MastGG = new List<int> { };
                List<int> deletedCards = new List<int> { };

                Boolean getEver = true;

                attack.Sort();
                defend.Sort();

                while (stati != true)//пока нет победителя
                {
                    CardGG.Clear();
                    MastGG.Clear();
                    SecondGG.Clear();

                    int attackCard = attack[0];

                    for (int pl = 0; pl < defend.Count; pl++)//сравниваем наименьшую карту атакующего, с картами защищающегося
                    {

                        if(attackCard % 10 == defend[pl] % 10)//если масти одинаковы
                        {
                            int time = attackCard / 10;
                            CardGG.Add(time);
                            SecondGG.Add(time);

                            time = defend[pl] / 10;
                            CardGG.Add(time);


                            time = players[f][0] % 10;
                            MastGG.Add(time);

                            deletedCards.Add(attackCard);
                            deletedCards.Add(defend[pl]);

                            players[f].Remove(attackCard);
                            players[ff].Remove(defend[pl]);
                            getEver = false;


                        }
                    }
                }

                if (getEver == true)
                {
                    foreach(int i in SecondGG)
                    {
                        players[ff].Add(i);
                    }
                }//если второй игрок не смог отбиться
                else
                {
                    players[ff] = deletedCards;
                }//если всё-же смог отбиться
                if (status != false)
                {
                    for (int x = 0; x < playCount; x++)
                    {
                        if (status != false)
                        {
                            GetCards(players, cards, x, hand, randcs, countMast, out List<List<int>> play, out Boolean statDeck, out int cM);
                            players = play;
                            status = statDeck;
                            countMast = cM;
                        }
                        else
                        {
                            break;
                        }
                    }
                    hand = 6;
                }//добор карт (рабочий!)
            }
            /*
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
           /*
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
           */
           /*
                        else if(attackCard / 10 == defend[pl] / 10)
                        {
                            if (attackCard % 10 == win)
                            {
                                stati = true;
                            }
                            else if (defend[pl] % 10 == win)
                            {
                                stati = false;
                                break;
                            }
                         }
           */
            Console.ReadKey();
        }
    }
}