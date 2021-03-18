using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {    
            string appUsername = "dionfinnerty";
            string appPassword = "speaker";

            Console.WriteLine("please enter username");
            string username = Console.ReadLine();

            Console.WriteLine("please enter your password!");
            string userPassword = Console.ReadLine();
            
            if (username == appUsername )
            {
                if (userPassword == appPassword)
                {
                    Console.WriteLine("login successful");
                }
                else 
                {
                    Console.WriteLine("login unsuccessful");
                }

            }
            else 
            {
            Console.WriteLine("login unsuccessful");
            }
            
        }
    }
}
