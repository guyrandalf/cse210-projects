using System;

public class Menu
{

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
        Entry entry1 = new Entry();
        Journal journals = new Journal();
        entry1._temporalEntries = new List<string> { };

        GreetUser();


        do
        {
            GetChoice();
            entry1._input = "";
            prompts._selectedPrompt = "";
            journals._selectedJournal = "";

            if (_choice == "1")
            {
                prompts._prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What brought you joy today?", "What was your greatest fear, and how did you conquer it?", "Today, I am grateful for?" };
                prompts.GetRandomPrompt();
                prompts.Display();

                entry1.GetInput();
                entry1.SaveEntry(prompts._selectedPrompt);

                entry1._temporalEntries.Add(entry1._input);
            }

            else if (_choice == "2")
            {
                foreach (string line in entry1._temporalEntries)
                {
                    Console.WriteLine(line);
                    Console.WriteLine("");
                }
            }

            else if (_choice == "3")
            {
                Console.Write("Please enter the file name: ");
                journals.GetJournalName();
                login.VerifyUserPIN();
                if (login._auth == true)
                {
                    journals.GetEntries();
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
                journals.GetJournalName();
                journals.SaveEntry(entry1._temporalEntries, journals._selectedJournal);
            }

        } while (_choice != "5");
    }
}