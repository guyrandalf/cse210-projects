// I exceeded requirements by including an authentication (sort of :) ) when a user tries to load a saved journal file.
// The program can save in .csv too and opens in excel

using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.ProgramEntry();
    }
}