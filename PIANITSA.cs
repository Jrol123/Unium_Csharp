using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lolicon
{
    class Program7
    {
        static void GetCards(List<List<int>> players, List<int> cards, int f, Random randcs, int countMast, out List<List<int>> play, out Boolean statrat, out int counttMast)
        {
            Boolean statDeck = true;
            for (int hand = 0; hand < 36 / players.Count; hand++)
            {
                int LenCards = cards.Count;
                int rancards = randcs.Next(0, LenCards);

                players[f].Add(cards[rancards]);
                cards.Remove(cards[rancards]);

                if (LenCards == 0)
                {
                    statDeck = false;
                    break;
                }
            }
            play = players;
            statrat = statDeck;
            counttMast = countMast;

        }//добор карт
        //работает корректно !

        static void Main(string[] args)
        {
            List<List<int>> players = new List<List<int>>();
            List<int> cards = new List<int> { };

            Random randcs = new Random();

            //сколько рук?

            Console.Write("Count of player's: ");
            int playCount = int.Parse(Console.ReadLine());

            for (int f = 0; f < playCount; f++)//добавляем игроков
            {
                players.Add(new List<int>());
            }//добавляем игроков
            for (int al = 0; al < 4; al++)
            {
                for (int z = 6; z < 15; z++)
                {
                    int y = z - 6;
                    int alph = z * 10;
                    cards.Add(z);
                }//картишки в колоду!
            }

            //руки игрокам!
            Boolean status = true;
            int countMast = 3;

            for (int f = 0; f < playCount; f++)
            {
                if (status != false)
                {
                    GetCards(players, cards, f, randcs, countMast, out List<List<int>> play, out Boolean statDeck, out int cM);
                    players = play;
                    status = statDeck;
                    countMast = cM;
                }
                else
                {
                    break;
                }
            }//раздача колод игрокам

            Boolean winn = false;
            int winner = 0;

            Console.WriteLine("Skip?(0/1)");
            int skip = int.Parse(Console.ReadLine());

            while (winn != true)
            {
                Boolean endd = false;

                List<int> addon = new List<int> { };
                List<int> multi = new List<int> { };
                int bullet = 0;
                List<int> blocked = new List<int> { };

                int alp = 0;
                int count = 0;
                Console.Clear();
                for (int y = 0; y < players.Count; y++)
                {
                    string playstat;
                    if (players[y].Count == 0)
                    {
                        players[y].Add(0);
                        playstat = "out";
                    }
                    else if (players[y][0] == 0)
                    {
                        playstat = "out";
                    }
                    else if (players[y].Count == 0)
                    {
                        players[y].Add(0);
                        playstat = "out";
                    }
                    else
                    {
                        count++;
                        playstat = Convert.ToString(players[y].Count);
                    }
                    int f = y + 1;
                    if(skip == 1)
                    {
                        continue;
                    }
                    Console.WriteLine("Player {0}:{1}", f, playstat);
                }//блокируем игроков без карт + вывод
                if (skip == 0)
                {
                    Console.ReadKey();
                }

                bool stylus = true;

                while (endd != true)
                {
                    List<int> duel = new List<int> { };

                    for (int i = 0; i < players.Count; i++)
                    {
                        if (players[i].Count == 0)
                        {
                            foreach (int lol in duel)
                            {
                                players[i].Add(lol);
                            }
                            stylus = false;
                            break;
                        }//если человек отдал карту, а на второй тур у него больше нет, карты ему в руки
                        else if (i.Equals(blocked)||players[i][alp] == 0)
                        {
                            continue;
                        }//если эвквивалентно заблокированным
                        else
                        {
                            duel.Add(players[i][alp]);
                            addon.Add(players[i][alp]);
                            players[i].Remove(players[i][alp]);
                        }
                    }//добавляем карты к сражающимся!
                    int max = 0;

                    if (stylus == false)
                    {
                        break;
                    }
                    if(skip == 0)
                    {
                        Console.Title = Convert.ToString(addon.Count);
                    }

                    if(addon.Count != count && skip == 0)
                    {
                        Console.ReadKey();
                    }

                    for (int l = 0; l < count; l++)
                    {
                        if(duel[max] == 0 || duel[l] == 0)
                        {

                        }
                        else if (max != l)
                        {
                            if (multi.Count > 0)
                            {
                                if(bullet < duel[l])
                                {
                                    max = l;
                                    foreach (int rom in multi)
                                    {
                                        blocked.Add(rom);
                                    }
                                    multi.Clear();
                                }
                                if(bullet > duel[l])
                                {
                                    blocked.Add(l);
                                }
                                if(bullet == duel[l])
                                {
                                    multi.Add(l);
                                }
                            }//если "победителей" несолько
                            else if (duel[max] > duel[l])
                            {
                                blocked.Add(l);
                            }
                            else if (duel[l] > duel[max])
                            {
                                blocked.Add(max);
                                max = l;
                            }
                            else if (duel[l] == duel[max])
                            {
                                bullet = duel[l];
                                multi.Add(l);
                                multi.Add(max);
                            }
                        }
                    }//главное сравнение!!
                    if (multi.Count > 0)
                    {
                    }//если есть несколько победителей, с одинаковыми картами, то продолжаем игру!
                    else
                    {
                        foreach (int lol in addon)
                        {
                            players[max].Add(lol);
                        }//перечисление карт
                        endd = true;
                    }//если нет, то карты в руки

                }
                for (int z = 0; z < players.Count; z++)
                {
                    if (players[z].Count == 36)
                    {
                        winner = z;
                        winn = true;
                    }
                }// если у кого-то вся колода, то он - победитель по жизни ))
            }//ЖАРА!
            Console.Clear();
            Console.WriteLine("THE WINNER IS: {0}", winner + 1);//вывод победителя

            Console.WriteLine();
            Console.WriteLine();

            System.Threading.Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
