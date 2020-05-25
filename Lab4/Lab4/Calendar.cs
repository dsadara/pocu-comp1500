namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            if (year > 9999)
            {
                return -1;
            }

            if (month == 1)
            {
                return 31;
            }
            if (month == 2)
            {
                if (IsLeapYear(year))
                {
                    return 29;
                }
                return 28;
            }
            if (month == 3)
            {
                return 31;
            }
            if (month == 4)
            {
                return 30;
            }
            if (month == 5)
            {
                return 31;
            }
            if (month == 6)
            {
                return 30;
            }
            if (month == 7)
            {
                return 31;
            }
            if (month == 8)
            {
                return 31;
            }
            if (month == 9)
            {
                return 30;
            }
            if (month == 10)
            {
                return 31;
            }
            if (month == 11)
            {
                return 30;
            }
            if (month == 12)
            {
                return 31;
            }
            return -1;
        }
    }
}