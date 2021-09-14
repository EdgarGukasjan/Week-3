using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinna sa said?");
            
            string userColor = Console.ReadLine();
            if (userColor == "5")

            {
                Console.WriteLine("Suurepäarane!");
            }
            else if (userColor == "4")
            {
                Console.WriteLine("Väga head!");
            }
            else if (userColor == "3")
            {
                Console.WriteLine("Hea");
            }
            else if (userColor == "2")
            {
                Console.WriteLine("Rahuldav!");
            }
            else  if (userColor == "1")
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("Puudulik");
            }
        }
    }
}
