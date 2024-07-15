using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Lecture lectureEvent = new Lecture("Lecture by Davy Crocket",
        "Davy Crocket will share his life story, things he learned, and what he wishes he would have done differently.",
        new DateTime(2024, 9, 1),
        new DateTime(2024, 9, 1, 18, 0, 0),
        "1402 CR 653 Devine, Texas 78016",
        "Davy Crocket",
        100);

        Reception receptionEvent = new Reception("Garden Reception",
        "Join us for a beautiful indoor reception in honor of Judge Judy",
        new DateTime(2024, 8, 15),
        new DateTime(2024, 8, 15, 14, 0, 0),
        "Sandy Oaks Ranch, 1480 I-35, Devine, TX 78016",
        "sandyOaksevents@gmail.com");

        OutdoorGathering outdoorGatheringEvent = new OutdoorGathering("OutdoorGathering Gathering in the Beautiful San Antonio Japanese tea Garden",
        "Join us in the Japanese Tea Garden to enjoy what nature has so beautifullay given us",
        new DateTime(),
        new DateTime(),
        " Japanese Tea Garden, 3853 N St Mary's St, San Antonio, TX 78212",
        "Sunny and 85");


        Console.WriteLine("\nLecture Event Details:");
        lectureEvent.PrintFullDetails();
        Console.WriteLine();


        Console.WriteLine("\nReception Event Details:");
        receptionEvent.PrintFullDetails();
        Console.WriteLine();


        Console.WriteLine("\nOutdoor Gathering Event Details:");
        outdoorGatheringEvent.PrintFullDetails();
        Console.WriteLine();


    }
}

