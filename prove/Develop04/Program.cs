using System;
// Defined unused question and prompt property to certain classes to avoid repitition during a single session. This is how I believe have core requirements.

class Program
{
    static void Main(string[] args)
    {
        var breathingActivity = new BreathingActivity();
        var ReflectionActivity = new ReflectionActivity();
        var listingActivity = new ListingActivity();
        var quit = false;
        while (!quit)
        {
            var input = Menu.GetInput();
            switch (input)
            {
                case "1":
                    breathingActivity.RunActivity();
                    break;
                case "2":
                    ReflectionActivity.RunActivity();
                    break;
                case "3":
                    listingActivity.RunActivity();
                    break;
                case "4":
                    quit = true;
                    break;
                default:
                    break;
            }
        }
    }
}
