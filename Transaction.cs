    using System;
using System.Collections.Generic;
using System.Text;

namespace caloriestracker
{
    class Transactions
    {
        enum TypeofMeal
        { Breakfast, Lunch, Dinner }
        public string Username { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }

        public TypeofMeal Meal { get; set; }
        public decimal TotalCaloriesAmount { get; set; }
    }

}