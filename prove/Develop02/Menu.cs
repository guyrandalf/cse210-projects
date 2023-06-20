using System;
using System.Collections.Generic;


public class Menu
{
    string fileName;
    public string _choice;

    public void GreetUser()
    {
        Console.WriteLine("Welcome to my journal software");
    }
    public void GetChoice()
    {
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine();
        Console.WriteLine("Enter your choice: ");
        _choice = Console.ReadLine();
    }

    public void ProgramEntry()
    {
        Login login = new Login();
        Prompt prompts = new Prompt();
        Journal journals = new Journal();

        GreetUser();

        while (true)
        {
            GetChoice();

            if (_choice == "1")
            {
                prompts._prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What brought you joy today?", "What was your greatest fear, and how did you conquer it?", "Today, I am grateful for?" };
                string prompt = prompts.GetRandomPrompt();
                prompts.Display();
                string answer = Console.ReadLine();

                Entry entry = new Entry(prompt, answer);
                journals.SaveEntry(entry);
            }
            
            else if (_choice == "2")
            {
                journals.DisplayEntries();
            }

            else if (_choice == "3")
            {
                Console.Write("Please enter the file name: ");
                fileName = Console.ReadLine();
                login.VerifyUserPIN();
                if (login._auth == true)
                {
                    journals.LoadEntriesFromFile(fileName);
                }
                else
                {
                    Console.WriteLine("Wrong PIN! Please try again...");
                    _choice = "3";
                };
            }

            else if (_choice == "4")
            {
                Console.WriteLine("Type journal filename to save: ");
                fileName = Console.ReadLine();
                journals.SaveInFile(fileName);
                Console.WriteLine("Saved successfully");
            }
            else if (_choice == "5")
            {
                Console.WriteLine("Goodbye");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}