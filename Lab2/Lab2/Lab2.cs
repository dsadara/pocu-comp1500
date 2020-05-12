using System;
using System.Diagnostics;

namespace Lab2
{
    class Lab2
    {
        public static int GetSum(int num1, int num2, int num3, int num4)
        {
            int sum;
            sum = num1 + num2 + num3 + num4;
            return sum;
        }

        public static double GetAverage(int num1, int num2, int num3, int num4)
        {
            int sum = GetSum(num1, num2, num3, num4);
            return (double)sum / 4.0;
        }

        public static int Multiply(int num1, int num2)
        {
            int product = num1 * num2;
            return product;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static string CombineStrings(string s1, string s2)
        {
            string result = s1 + s2;
            return result;
        }

        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 5;
            int num3 = 2;
            int num4 = 6;

            int sum = GetSum(num1, num2, num3, num4);
            Debug.Assert(sum == 17);

            double average = GetAverage(num1, num2, num3, num4);
            Debug.Assert(average == 4.25);

            int product = Multiply(num1, num2);
            Debug.Assert(product == 20);

            int difference = Subtract(num1, num2);
            Debug.Assert(difference == -1);

            string s1 = "First string";
            string s2 = " Second string";
            string combinedString = CombineStrings(s1, s2);
            Debug.Assert(combinedString == "First string Second string");
        }

    }
}

