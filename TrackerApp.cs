using System;
using System.Collections.Generic;
using System.Text;

namespace caloriestracker
{
    static class TrackerApp
    {
        private static List<Tracker> Trackers = new List<Tracker> ();
        private static object trackers;

        public static Tracker Createtracker(string Username, 
            TypeofMeal Meal,decimal CaloriesAmount)
        {
            var Tracker = new Tracker
            {
                Username = Username,
                TypeofMeal = Meal,
          

            };
            if(CaloriesAmount > 0)
            {
                Tracker.Addition(CaloriesAmount);
            }
            Trackers.Add(Tracker);
            return Tracker;
        }

        public static IEnumerable<Tracker> 
            GetTrackersbyusername(string username)
        {
            return trackers.Where(a => a.username == username);
        }
        internal static object Createtracker(string v)
        {
            throw new NotImplementedException();
        }
    }
}
