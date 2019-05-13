using System;

namespace PracticeInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string thing = "painter";

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("Who is your favorite " + thing + "? ");
            string favoriteThing = Console.ReadLine();

            Console.Write(" My name is " + name + " and my favorite " + thing + " is " + favoriteThing + ". ");
        }
    }
}
