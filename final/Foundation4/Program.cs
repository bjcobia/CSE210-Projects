class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("01/22/2023", 30, 3.0));
        activities.Add(new StationaryBikes("02/03/2023", 40, 25.0));
        activities.Add(new Swimming("02/05/2023", 45, 20));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}