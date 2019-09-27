using System;
using System.Collections.Generic;
using System.Text;

namespace caloriestracker
{
    /// <summary>
    /// this is a tracker where user can enter the type
    /// of food and calories intake daily
    /// </summary>
    class Tracker
    {
        #region Properties
        /// <summary>
        /// Name of the user
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// days of the week
        /// </summary>
        public string dayOfWeek { get; set; }
        /// <summary>
        /// Calories amount user enter 
        /// </summary>
        public decimal CaloriesAmount { get; set; }
        /// <summary>
        /// User can enter the type of food they eat
        /// </summary>
        public string TypeofFood { get; set; }
        /// <summary>
        /// Total calories amount user enter for the day
        /// </summary>
        public decimal TotalCalories { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Add calories amount to the tracker
        /// </summary>
        /// <param name="amount">Amount to add</param>
        public void Addition(decimal amount)
        {
            TotalCalories = CaloriesAmount + CaloriesAmount;
        }

        #endregion
    }
}

