using System;

class Program
{
    static void Main(string[] args)
    {
// Creating instances of each activity
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 30); // 30 seconds
        ReflectingActivity reflectionActivity = new ReflectingActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 60); // 60 seconds
        ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 45); // 45 seconds

        // Running each activity
        // breathingActivity.RunActivity();

        reflectionActivity.RunActivity();

        // listingActivity.RunActivity();

    }
}