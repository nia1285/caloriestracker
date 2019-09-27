using System;

namespace caloriestracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of a tracker == Object
            var Tracker = new Tracker
            {
                Username = "Nia12",
                dayOfWeek = "Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday",
                TypeofFood = "abcd",
                CaloriesAmount = 12345,
                
            };

            Tracker.Addition(12345);

            Console.WriteLine($"CT: {Tracker.Username}, $day: {Tracker.dayOfWeek}," +
                $" $food: {Tracker.TypeofFood},$CA: {Tracker.CaloriesAmount}");
        }
    }
}
