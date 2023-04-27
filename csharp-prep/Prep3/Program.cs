using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your magic number? ");
        // int user_magic_number = int.Parse(Console.ReadLine());
        
        int user_guess = -1;

        // Stretch challenge
        int attempts = 0;

        Random randomGenerator = new Random();
        int user_magic_number = randomGenerator.Next(1, 11);

        while (user_magic_number != user_guess)
        {
            Console.Write("What is your guess? ");
            user_guess = int.Parse(Console.ReadLine());
            attempts += 1;            

            if (user_guess == user_magic_number)
            {
                Console.WriteLine("You guessed it!");
                Console.Write("You made a total attempt of " + attempts);
            }
            else if (user_guess < user_magic_number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }

    }
}