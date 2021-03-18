using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your age?");
            string age = Console.ReadLine();
            int userAge = int.Parse(age);

            Console.WriteLine("are you male or female?");
            string userGender = Console.ReadLine();

            Console.WriteLine("enter a random number between 1-10!");
            string userNum1 = Console.ReadLine();
            int number1 = int.Parse(userNum1);

            Console.WriteLine("enter another random number between 1-10!");
            string userNum2 = Console.ReadLine();
            int number2 = int.Parse(userNum2);

            if (userAge > 17)
            {
                Console.WriteLine("Legally adult age");
                if (userGender == "male")
                {
                    Console.WriteLine("Male is an adult");
                }

                if (userGender == "female")
                {
                    Console.WriteLine("Female is an adult");
                }
            }
            else
            {
                Console.WriteLine("Legally not adult age");
                if (userGender == "male")
                {
                    Console.WriteLine("Male is not an adult");
                }

                if (userGender == "female")
                {
                    Console.WriteLine("Female is not an adult");
                }
            }

            if (number2 + number1 > 10)
            {
                Console.WriteLine("Sum of numbers is greater than 10");
            }
            else

            if (number2 + number1 < 10)
            {
                Console.WriteLine("Sum of numbers is less than 10");
            }
















        }
    }
}
