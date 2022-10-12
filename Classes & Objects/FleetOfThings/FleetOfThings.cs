using System;

namespace FleetOfThings
{
    class FleetOfThings
    {
        static void Main(string[] args)
        {
            var fleet = new Fleet();

            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main()` method
            // - Download those, use those
            // - In the Main() method create a fleet

            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also



            Thing task1 = new Thing("Get milk");
            Thing task2 = new Thing("Remove the obstacles");
            Thing task3 = new Thing("Stand up");
            task3.Complete();
            Thing task4 = new Thing("Eat lunch");
            task4.Complete();

            fleet.Add(task1);
            fleet.Add(task2);
            fleet.Add(task3);
            fleet.Add(task4);

            fleet.Print();

        }
    }
}

