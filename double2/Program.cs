using System;

namespace double2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a password.");

            string password = Console.ReadLine();

            Console.ReadLine();

            Console.WriteLine("Please, re-enter your password");

            string passwordTwo = Console.ReadLine();

            Console.ReadLine();

            if (password.Contains(passwordTwo))
            {
                Console.WriteLine("Congratulations, you successfully entered your password");
            }
        }
    }
}
