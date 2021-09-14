using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //console asks user to enter his favorite color
            // if its red you are romantic
            // if its blue you are hard working 
            // if its green you are friend of the nature
            // if its anything besides it you are one of a kind

            Console.WriteLine("Enter your favorite color to find out what personality are you!");

            string userColor = Console.ReadLine();

            if (userColor == "red")

            {
                Console.WriteLine("You are romantic");
            }
            else if (userColor == "blue")
            {
                Console.WriteLine("You are hardworking");
            }
            else if (userColor == "green")
            { 
                Console.WriteLine("You are friend of nature"); 
            }            
            else
            {
                Console.WriteLine("You are one of a kind");
            }
        }
    }
  
}
