using System;
using System.IO;

public class Journal{

    public string _selectedJournal;


    public void GetJournalName(){        
        _selectedJournal = Console.ReadLine();
    }

    public void GetEntries(){
        string fileName = _selectedJournal;
        string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(line);
        }
         
    }
    public void SaveEntry(List<string> _tempEntries, string journal){
        using(StreamWriter outputFile = new StreamWriter(journal))
        foreach(string line in _tempEntries){
            {
            outputFile.WriteLine(line);
        }
        }
    }
}