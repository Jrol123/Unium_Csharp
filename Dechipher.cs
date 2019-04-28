using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De / un ?");
            string deun= Console.ReadLine();
            string hi = "Hello world";
            int f = 0;
            Console.WriteLine(hi[f]);

            char [] alph = {' ','А','Б','В','Г','Д','Е','Ж','З','И','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ш','Ч','Ъ','Ь','Ы','Ю','Я', } ;
            if(deun == "De")
            {
                Console.WriteLine("enter ur encrypted message");
                string message = Console.ReadLine();
                for (int i = 0; i < message.Length; i++)
                {
                    if(message[i] == alph[29])
                    {

                    }
                    else
                    {

                    }
                }   
            }
            else
            {

            }
            Console.ReadKey();
        }
    }
}
