using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string userColor = Console.ReadLine();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romanitline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled hardworking");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sober");
                    break;
                default:
                    Console.WriteLine("Sa oled üksik");
                    break;


            }
        }
    }
}
