class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "SomeTown", "CA", "USA");
        Address address2 = new Address("555 W St", "Ontario", "Providence", "Canada");
        Address address3 = new Address("789 Elm St", "AnotherTown", "NY", "USA");

        Event reception = new Receptions("Reception Wedding", "We are meeting for a reception for the wedding of some people.", "12/31/2022", new TimeSpan(18, 0, 0), address1, "someone@gmail.com");
        Event lecture = new Lectures("Lecture about technology", "We will hear a lecture on the latest technology in the industry", "03/01/2022", new TimeSpan(14, 0, 0), address2, "Johnathan Doe", 100);
        Event outdoorGathering = new OutdoorGatherings("Outdoor Thing", "We are going to meet outside to do some cool stuff", "07/17/2002", new TimeSpan(12, 0, 0), address3, "Sunny");

        Console.WriteLine("Standard Reception Deatails:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\nFull Reception Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nReception Short Description:");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\n\nStandard Lecture Deatails:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\nFull Lecture Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nLecture Short Description:\n");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\n\nStandard Outdoor Gathering Deatails:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());  
        Console.WriteLine("\nFull Outdoor Gathering Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("\nOutdoor Gathering Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}