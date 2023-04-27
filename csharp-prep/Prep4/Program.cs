using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int user_number = -1;

        while (user_number != 0)
        {
            Console.Write("Enter a number, 0 to quit: ");
            user_number = int.Parse(Console.ReadLine());

            if (user_number != 0)
            {
                numbers.Add(user_number);
            }

        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sume is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        // stretch challenge
        int min = 9999999;

        foreach (int number in numbers)
        {
            if (number < min && number > 0) {
                min = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {min}");


//         #SMALLEST
// for number in numbers:

//     if number < smallest and number > 0:
//         smallest = number
// print(f"The smallest positive number is: {smallest}")

// #SORT
// numbers.sort()
// print(f"Your sorted list is: {numbers}")
    }
}