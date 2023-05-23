using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("Psalm", 23, 1, 3);
        var scriptureText = "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters. He restoreth my soul: he leadeth me in the paths of righteousness for his name's sake.";
        var scripture = new Scripture(reference, scriptureText);

        scripture.SetDifficultyLevel();
        var _input = "";
        while (true)
        {
            Console.WriteLine(scripture.GetText());
            _input = Menu.GetInput();
            if (_input == "Q" || _input == "q") break;
            if (scripture.IsCompletelyHidden()) break;

            scripture.HideWords();
        }
    }
}