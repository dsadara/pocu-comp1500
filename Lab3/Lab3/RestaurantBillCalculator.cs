using System;
using System.IO;

namespace Lab3
{
    public static class RestaurantBillCalculator
    {
        public static double CalculateTotalCost(StreamReader input)
        {
            double tax;
            double tip;
            double foodTotalCost = 0;
            double tempTotal;
            double foodCost1 = double.Parse(input.ReadLine());
            double foodCost2 = double.Parse(input.ReadLine());
            double foodCost3 = double.Parse(input.ReadLine());
            double foodCost4 = double.Parse(input.ReadLine());
            double foodCost5 = double.Parse(input.ReadLine());
            double tipPercent = double.Parse(input.ReadLine());

            tax = foodCost1 * 0.05;
            tip = (foodCost1 + tax) * tipPercent / 100;
            tempTotal = foodCost1 + tax + tip;
            foodTotalCost += tempTotal;

            tax = foodCost2 * 0.05;
            tip = (foodCost2 + tax) * tipPercent / 100;
            tempTotal = foodCost2 + tax + tip;
            foodTotalCost += tempTotal;

            tax = foodCost3 * 0.05;
            tip = (foodCost3 + tax) * tipPercent / 100;
            tempTotal = foodCost3 + tax + tip;
            foodTotalCost += tempTotal;

            tax = foodCost4 * 0.05;
            tip = (foodCost4 + tax) * tipPercent / 100;
            tempTotal = foodCost4 + tax + tip;
            foodTotalCost += tempTotal;

            tax = foodCost5 * 0.05;
            tip = (foodCost5 + tax) * tipPercent / 100;
            tempTotal = foodCost5 + tax + tip;
            foodTotalCost += tempTotal;
            
            foodTotalCost = Math.Round(foodTotalCost, 2);
                
            return foodTotalCost;
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            double costPerPeople;
            double people = double.Parse(input.ReadLine());

            costPerPeople = totalCost / People;
            costPerPeople = Math.Round(costPerPeople, 2);

            return costPerPeople;
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            uint payerCount;
            double costPerPayer = double.Parse(input.ReadLine());

            PayerCount = (uint)Math.Ceiling(totalCost / costPerPayer);
            return PayerCount;
        }
    }
}
