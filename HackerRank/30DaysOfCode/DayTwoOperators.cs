using System;
namespace HackerRank.DaysOfCode
{
    public class DayTwoOperators
    {
        public DayTwoOperators()
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());
            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());
            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("meal_cost {0}, tip_percent {1}, tax_percent {2}", meal_cost, tip_percent, tax_percent);

            double tip = (meal_cost * tip_percent)/100;
            double tax = (meal_cost * tax_percent)/100;

            Console.WriteLine("tip {0}, tax {1}, total {2}", tip, tax, Math.Round(tip + tax + meal_cost));
        }
    }
}
