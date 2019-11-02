using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caloriestracker
{
    static class TrackerApp
    {
        private static List<Tracker> Trackers = new List<Tracker>();
        private static object trackers;

        public static Tracker Createtracker(string Username,
            TypeofMeal Meal, decimal CaloriesAmount)
        {
            var Tracker = new Tracker
            {
                Username = Username,
                TypeofMeal = Meal,


            };
            if (CaloriesAmount > 0)
            {
                Tracker.Addition(CaloriesAmount);
            }
            Trackers.Add(Tracker);
            return Tracker;
        }

        public static IEnumerable<Tracker>
            GetTrackersbyusername(string username)
        {
            return Trackers.Where(a => a.username == username);
        }
        public static void Addition(int username, decimal amount);

        {
           private var tracker = trackers.SingleorDefault(a => a.username == username);

           if (Tracker == null)
        
        {
            //Throw exception
            return;
        }
            Tracker.addition(amount);

       
        
    }
}
