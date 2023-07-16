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
            "Web Development",
            "Join us on an exciting journey exploring the components of frontend web development",
            "14 Jul 2023",
            "12:00",
            address1,
            "Lecture",
            "Randalf Ehigiator",
            250
        );

        Lecture lecture2 = new Lecture(
            "The Esemble",
            "Come and learn why you should be involved in your ward choir",
            "13 Jul 2023",
            "16:00",
            address1,
            "Lecture",
            "Marc Wilberg",
            350
        );

        Lecture lecture3 = new Lecture(
            "Organ 101 - Sweels and Greats",
            "Let us dive into the organ and know the difference between it and the Piano",
            "23 Jul 2023",
            "14:00",
            address2,
            "Lecture",
            "Clay Christensen",
            500
        );

        Reception reception1 = new Reception(
            "J n J",
            "Join us on this special event!",
            "14 Jul 2023",
            "12:00",
            address2,
            "Reception",
            "janejohn23@gmail.com"
        );

        Reception reception2 = new Reception(
            "A Baby's Day",
            "All new garage ward members are invited to our baby's dedication party",
            "22 Jul 2023",
            "16:00",
            address2,
            "Reception",
            "randalf@gmail.com"
        );

        Outdoor outdoor1 = new Outdoor(
            "Swimming and Food",
            "Join us for this family swimming and food fun day",
            "16 Aug 2023",
            "18:00",
            address1,
            "Outdoor",
            "cloudy"
        );

        lecturesList.Add(lecture1);
        lecturesList.Add(lecture2);
        lecturesList.Add(lecture3);
        receptionsList.Add(reception1);
        receptionsList.Add(reception2);
        outdoorsList.Add(outdoor1);

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
