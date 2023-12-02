using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Elm St", "Othertown", "NY", "67890");
        Address address3 = new Address("789 Maple St", "Somewhere", "FL", "54321");

        Lecture lecture = new Lecture("Lecture on Self Confidence", "A lecture on how to gain self confidence", new DateTime(2023, 11, 5), new TimeSpan(7, 0, 0), address2, "Dr. John Doe", 50);
        Reception reception = new Reception("Networking Reception", "A networking reception for professionals", new DateTime(2023, 3, 7), new TimeSpan(5, 0, 0), address3, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic in the Park", "A picnic in the park", new DateTime(2023, 12, 25), new TimeSpan(11, 0, 0), address1, "Sunny");

        Console.WriteLine("Standard Details");
        Console.WriteLine($"{lecture.GetStandardDetails()}\n\n");
        Console.WriteLine("Full Details");
        Console.WriteLine($"{lecture.GetFullDetails()}\n\n");
        Console.WriteLine("Short Description");
        Console.WriteLine($"{lecture.GetShortDescription()}\n\n");

        Console.WriteLine("Standard Details");
        Console.WriteLine($"{reception.GetStandardDetails()}\n\n");
        Console.WriteLine("Full Details");
        Console.WriteLine($"{reception.GetFullDetails()}\n\n");
        Console.WriteLine("Short Details");
        Console.WriteLine($"{reception.GetShortDescription()}\n\n");

        Console.WriteLine("Standard Details");
        Console.WriteLine($"{outdoorGathering.GetStandardDetails()}\n\n");
        Console.WriteLine("Full Details");
        Console.WriteLine($"{outdoorGathering.GetFullDetails()}\n\n");
        Console.WriteLine("Short Details");
        Console.WriteLine($"{outdoorGathering.GetShortDescription()}\n\n");
    }
}

