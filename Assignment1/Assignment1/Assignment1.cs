using System;
using System.IO;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class Assignment1
    {
        public static void PrintIntegers(StreamReader input, StreamWriter output, int width)
        {
            uint num1 = uint.Parse(input.ReadLine());   
            uint num2 = uint.Parse(input.ReadLine());
            uint num3 = uint.Parse(input.ReadLine());
            uint num4 = uint.Parse(input.ReadLine());
            uint num5 = uint.Parse(input.ReadLine());

            if (width < 10)
            {
                output.WriteLine("{0, 10} {1, 10} {2, 10}", "oct", "dec", "hex");
                output.WriteLine("---------- ---------- ----------");
                output.WriteLine("{0,10} {1, 10} {2, 10}", Convert.ToString(num1, 8), num1, Convert.ToString(num1, 16));
                output.WriteLine("{0,10} {1, 10} {2, 10}", Convert.ToString(num2, 8), num2, Convert.ToString(num2, 16));
                output.WriteLine("{0,10} {1, 10} {2, 10}", Convert.ToString(num3, 8), num3, Convert.ToString(num3, 16));
                output.WriteLine("{0,10} {1, 10} {2, 10}", Convert.ToString(num4, 8), num4, Convert.ToString(num4, 16));
                output.WriteLine("{0,10} {1, 10} {2, 10}", Convert.ToString(num5, 8), num5, Convert.ToString(num5, 16));
            }
            else
            {
                output.WriteLine("{0,10} {1, 10} {2, 10}", "oct", "dec", "hex");
                output.WriteLine("---------- ---------- ----------");
                output.WriteLine("{0, 10} {1, 10} {2, 10}", Convert.ToString(num1, 8), num1, Convert.ToString(num1, 16));
                output.WriteLine("{0, 10} {1, 10} {2, 10}", Convert.ToString(num2, 8), num2, Convert.ToString(num2, 16));
                output.WriteLine("{0, 10} {1, 10} {2, 10}", Convert.ToString(num3, 8), num3, Convert.ToString(num3, 16));
                output.WriteLine("{0, 10} {1, 10} {2, 10}", Convert.ToString(num4, 8), num4, Convert.ToString(num4, 16));
                output.WriteLine("{0, 10} {1, 10} {2, 10}", Convert.ToString(num5, 8), num5, Convert.ToString(num5, 16));
            }
        }

        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            double min;
            double max;
            double sum;
            double average;
            double floatNum1 = double.Parse(input.ReadLine());
            double floatNum2 = double.Parse(input.ReadLine());
            double floatNum3 = double.Parse(input.ReadLine());
            double floatNum4 = double.Parse(input.ReadLine());
            double floatNum5 = double.Parse(input.ReadLine());

            // doulbe값들의 min max average 를 구하는 코드
            min = floatNum1;
            if (min > floatNum2)
                min = floatNum2;
            if (min > floatNum3)
                min = floatNum3;
            if (min > floatNum4)
                min = floatNum4;
            if (min > floatNum5)
                min = floatNum5;

            max = floatNum1;
            if (max < floatNum2)
                max = floatNum2;
            if (max < floatNum3)
                max = floatNum3;
            if (max < floatNum4)
                max = floatNum4;
            if (max < floatNum5)
                max = floatNum5;

            sum = floatNum1 + floatNum2 + floatNum3 + floatNum4 + floatNum5;

            average = sum / 5;


            output.WriteLine($"{floatNum1,25:f3}");
            output.WriteLine($"{floatNum2,25:f3}");
            output.WriteLine($"{floatNum3,25:f3}");
            output.WriteLine($"{floatNum4,25:f3}");
            output.WriteLine($"{floatNum5,25:f3}");
            output.WriteLine($"Min{min,22:f3}");
            output.WriteLine($"Max{max,22:f3}");
            output.WriteLine($"Sum{sum,22:f3}");
            output.WriteLine($"Average{average,18:f3}");
        }
    }
}