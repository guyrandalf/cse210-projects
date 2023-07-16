using System;

class Program
{
    static void Main(string[] args)
    {
        Running matt = new Running("13/07/2023", 40, "Running", 15.0f);
        Running james = new Running("14/07/2023", 50, "Running", 17.0f);

        Bicycle scott = new Bicycle("15/07/2023", 60, "Bicycling", 14.0f);
        Bicycle randalf = new Bicycle("13/07/2023", 54, "Bicycling", 12.0f);

        Swimming phillip = new Swimming("15/07/2023", 55, "Swimming", 14);
        Swimming sammy = new Swimming("14/07/2023", 47, "Swimming", 20);

        List<Activity> activities = new List<Activity>{matt, james, scott, randalf, phillip, sammy};

        foreach (Activity activity in activities)
        {
            activity.DisplaySummary();
        }
        
    }
}