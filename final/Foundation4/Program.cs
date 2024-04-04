class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Adding sample activities
        activities.Add(new Running(DateTime.Now, 30, 3.0));
        activities.Add(new StationaryBikes("Put Date Here", 40, 25.0));
        activities.Add(new Swimming("Put Date Here", 45, 20));

        // Displaying summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}