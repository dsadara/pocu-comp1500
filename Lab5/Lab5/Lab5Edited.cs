using System;
using System.Diagnostics;

namespace Lab5
{
    public static class Lab5Edited
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {
            double fixedRevenuePerDay = 0;
            bool bRevenueFixed = false;
            int i;
            if (usersPerDay.Length != revenuePerDay.Length)
            {
                return false;
            }
            for (i = 0; i < usersPerDay.Length; ++i)
            {
                if (usersPerDay[i] < 0)
                {
                    Debug.Assert(false);
                }
                else if (usersPerDay[i] <= 10)
                {
                    fixedRevenuePerDay = usersPerDay[i] / (double)2;
                }
                else if (usersPerDay[i] <= 100)
                {
                    fixedRevenuePerDay = 16 * (double)usersPerDay[i] / 5 - 27;
                }
                else if (usersPerDay[i] <= 1000)
                {
                    fixedRevenuePerDay = usersPerDay[i] * (double)usersPerDay[i] / 4 - 2 * (double)usersPerDay[i] - 2007;
                }
                else
                {
                    fixedRevenuePerDay = 245743 + usersPerDay[i] / (double)4;
                }       
                fixedRevenuePerDay = (int)(fixedRevenuePerDay * 100 + 0.5) / 100.0; // 소수 둘째자리까지 반올림
                if (fixedRevenuePerDay != revenuePerDay[i])
                {
                    bRevenueFixed = true;
                    revenuePerDay[i] = fixedRevenuePerDay;
                }
            }
            return bRevenueFixed;
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            int wrongElementNum = 0;
            double fixedRevenuePerDay;
            if (usersPerDay.Length == revenuePerDay.Length)
            {
                for (int i = 0; i < usersPerDay.Length; ++i)
                {
                    if (0 <= usersPerDay[i] && usersPerDay[i] <= 10)
                    {
                        fixedRevenuePerDay = usersPerDay[i] / (double)2;
                    }
                    else if (10 < usersPerDay[i] && usersPerDay[i] <= 100)
                    {
                        fixedRevenuePerDay = 16 * (double)usersPerDay[i] / 5 - 27;
                    }
                    else if (100 < usersPerDay[i] && usersPerDay[i] <= 1000)
                    {
                        fixedRevenuePerDay = usersPerDay[i] * (double)usersPerDay[i] / 4 - 2 * (double)usersPerDay[i] - 2007;
                    }
                    else
                    {
                        fixedRevenuePerDay = 245743 + usersPerDay[i] / (double)4;
                    }
                    fixedRevenuePerDay = Math.Round(fixedRevenuePerDay, 2);
                    if (fixedRevenuePerDay != revenuePerDay[i])
                    {
                        ++wrongElementNum;
                    }
                }
                return wrongElementNum;
            }
            return -1;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            int arrayLength = revenuePerDay.Length;
            double totalRevenuePerDay = 0;
            if (arrayLength != 0 && (0 <= start && start < arrayLength) && (0 <= end && end < arrayLength) && start <= end)
            {
                for (uint i = start; i <= end; ++i)
                {
                    totalRevenuePerDay += revenuePerDay[i];
                }
                return totalRevenuePerDay;
            }
            return -1;
        }
    }
}
