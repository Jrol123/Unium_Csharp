using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treppit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dechipher or unchipher?(dech/unch)");
            string ans = Console.ReadLine();

            string alpha = " АБВГДЕЖЗИКЛМНОПРСТУФХЦШЩЧЪЬЫЮЯ";
            string ended = "";
            int x = 0;

            if (ans == "unch")
            {
                Console.WriteLine("Enter ur uncripted message");
                string message = Console.ReadLine();

                for (int i = 0; i < message.Length; i++)
                {
                    while (message[i] != alpha[x])
                    {
                        x++;
                    }
                    if (alpha[x] == ' ')
                    {
                        ended = ended + "Я";
                    }
                    else
                    {
                        ended = ended + alpha[--x];
                    }
                    x = 0;
                }
            }
            else
            {
                Console.WriteLine("Enter ur normal message");
                string message = Console.ReadLine();

                for (int i = 0; i < message.Length; i++)
                {
                    while (message[i] != alpha[x])
                    {
                        x++;
                    }
                    if (alpha[x] == 'Я')
                    {
                        ended = ended + " ";
                    }
                    else
                    {
                        ended = ended + alpha[++x];
                    }
                    x = 0;
                }
            }
            Console.WriteLine(ended);
            Console.ReadKey();
        }
    }
}
