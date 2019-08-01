using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bycicle
{
    class Program
    {
        static void Transformator(string a, out Boolean status)
        {
            string[] com = {"bycicle", "help", "xtml" };

            if (a.Equals(com))
            {
                status = true;
                if (a == "help")
                {
                    Console.WriteLine("List of commands:");

                    Console.WriteLine("1. 'help', to see this list");
                    Console.WriteLine("2. 'bycicle' to give someone a bike");
                    Console.WriteLine("3. 'xtml' to see the list of users");
                }
                if (a == "bycicle")
                {
                    
                }
                if(a == "xtml")
                {

                }
            }
            else
            {
                status = false;
            }
        }
        static void Main(string[] args)
        {
            List<List<int>> global = new List<List<int>>();
            Boolean stat = false;

            Console.WriteLine("Hello, Worker!");

            while(1!=2)
            {
                Console.WriteLine("Enter command or type 'help' to see the list of commands");
                string input = Console.ReadLine();
                if(input == "end")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                while (stat == false)
                {
                    Transformator(input, out Boolean status);
                    stat = status;
                    if (stat == false)
                    {
                        Console.WriteLine("Wrong Command");
                    }
                }

                Console.WriteLine("Job's done! Press any key, to continue!");
                Console.ReadKey();
                stat = false;
            }

            Console.ReadKey();
        }
    }
}
