using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> lecturesList = new List<Event>();
        List<Event> receptionsList = new List<Event>();
        List<Event> outdoorsList = new List<Event>();

        Address address1 = new Address("IDC Area", "Ibadan", "Oyo", "Nigeria");
        Address address2 = new Address("Eheneden", "Benin", "Edo", "NG");

        Lecture lecture1 = new Lecture(
            "The universe",
            "Join us on an exciting adventure exploring the stars",
            "25-03-2023",
            "18:00pm",
            address1,
            "Lecture",
            "Carl Sagan",
            250
        );

        Lecture lecture2 = new Lecture(
            "The inmune system",
            "Come and learn why you should be amazed and thankful to the system that keeps you alive",
            "30-04-2023",
            "18:00pm",
            address1,
            "Lecture",
            "Kurzgestag - In a Nutshell",
            350
        );

        Lecture lecture3 = new Lecture(
            "The animation through the eras",
            "The recognized director and fim writer will be giving a lecture on the importance of animation as a form of art",
            "27-10-2023",
            "5:00pm",
            address2,
            "Lecture",
            "Guillermo del Toro",
            500
        );

        Reception reception1 = new Reception(
            "Camille and Justin's Wedding",
            "Join us in this special day!",
            "15-06-2023",
            "20:00pm",
            address2,
            "Reception",
            "Cami&J@confirmation.com"
        );

        Reception reception2 = new Reception(
            "New employee's Party",
            "All new employees invited to their welcome party",
            "10-08-2023",
            "19:00pm",
            address2,
            "Reception",
            "Newbies@eaton.com"
        );

        Outdoor outdoor1 = new Outdoor(
            "Rock'N.D Park",
            "Join us for this charity show!",
            "29-08-2023",
            "7:00pm",
            address1,
            "Outdoor",
            "clear"
        );

        Outdoor outdoor2 = new Outdoor(
            "Natalia Lafourcade and Los Macorinos",
            "The wonderful Natalia will be giving a concert to present her new album",
            "11-11-2023",
            "6:00pm",
            address2,
            "Outdoor",
            "cloudy"
        );

        lecturesList.Add(lecture1);
        lecturesList.Add(lecture2);
        lecturesList.Add(lecture3);
        receptionsList.Add(reception1);
        receptionsList.Add(reception2);
        outdoorsList.Add(outdoor1);
        outdoorsList.Add(outdoor2);

        foreach (Lecture lecture in lecturesList)
        {
            Console.WriteLine("--------------");
            lecture.DisplayStandardDetails();
            Console.WriteLine("--------------");
            lecture.DisplayShortDescription();
            Console.WriteLine("--------------");
            lecture.DisplayFullDetails();
        }

        foreach (Reception reception in receptionsList)
        {
            Console.WriteLine("--------------");
            reception.DisplayStandardDetails();
            Console.WriteLine("--------------");
            reception.DisplayShortDescription();
            Console.WriteLine("--------------");
            reception.DisplayFullDetails();
        }

        foreach (Outdoor outdoor in outdoorsList)
        {
            Console.WriteLine("--------------");
            outdoor.DisplayStandardDetails();
            Console.WriteLine("--------------");
            outdoor.DisplayShortDescription();
            Console.WriteLine("--------------");
            outdoor.DisplayFullDetails();
        }
    }
}
