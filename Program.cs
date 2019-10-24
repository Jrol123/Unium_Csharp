using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 - exit");
            Console.WriteLine("1 - give");
            Console.WriteLine("2 - take");
            Console.WriteLine("3 - add");
            Console.WriteLine("4 - count");
            Console.WriteLine("5 - statist of book");
            Console.WriteLine("6 - add a whole new book");

            List<Book> books = new List<Book>();
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                switch (a)
                {
                    case 1:
                        foreach()
                        books[0].Give();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        books.Add(new Book());
                        break;


                }
            }
        }
    }
}//Доделать методы + Доделать ввыдачу + доделать мелочь
