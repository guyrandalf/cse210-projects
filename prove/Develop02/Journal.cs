using System;
using System.IO;

public class Journal{

    public string selectedJournal;


    public void GetJournalName(){        
        selectedJournal = Console.ReadLine();
    }

    public void GetEntries(){
        string fileName = selectedJournal;
        string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(line);
        }
         
    }
    public void SaveEntry(List<string> tempEntries, string journal){
        using(StreamWriter outputFile = new StreamWriter(journal))
        foreach(string line in tempEntries){
            {
            outputFile.WriteLine(line);
        }
        }
    }
}