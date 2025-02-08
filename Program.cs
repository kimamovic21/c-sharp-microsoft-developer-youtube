using System;

namespace SimpleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            string reversedFirstName = ReverseString(firstName);
            string reversedLastName = ReverseString(lastName);

            DisplayResult(reversedFirstName, reversedLastName);

            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            return new string(messageArray);
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName)
        {
            Console.WriteLine($"Reversed Name: {reversedFirstName} {reversedLastName}");
        }
    }
}