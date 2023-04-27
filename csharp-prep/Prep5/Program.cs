using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int square = SquareUserNumber(number);

        DisplayResult(name, square);
    }

        // Sample output of the program could look as follows:


        // Welcome to the program!
        // Please enter your name: Brother Burton
        // Please enter your favorite number: 42
        // Brother Burton, the square of your number is 1764

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            return username;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int fav_number = int.Parse(Console.ReadLine());
            return fav_number;
        }
        static int SquareUserNumber(int fav_number)
        {            
            int square_number = fav_number * fav_number;
            return square_number;
        }
        static void DisplayResult(string username, int square_number)
        {
            Console.WriteLine($"{username}, the square of your number is {square_number} ");
        }
    }