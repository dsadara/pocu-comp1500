using System;
using System.Collections.Generic;

namespace Lab9
{
    public static class Lab9
    {
        public static List<int> MergeLists(List<int> sortedList1, List<int> sortedList2)
        {
            List<int> mergedList = new List<int>();
            if (sortedList1.Count == 0 && sortedList2.Count == 0)
            {
                return mergedList;
            }
            else if (sortedList1.Count == 0)
            {
                return sortedList2;
            }
            else if (sortedList2.Count == 0)
            {
                return sortedList1;
            }

            int i = 0;
            int j = 0;
            while (true)
            {
                //end condition
                if (i > sortedList1.Count - 1)
                {
                    for (; j < sortedList2.Count; j++)
                    {
                        mergedList.Add(sortedList2[j]);
                    }
                    break;
                }
                else if (j > sortedList2.Count - 1)
                {
                    for (; i < sortedList2.Count; i++)
                    {
                        mergedList.Add(sortedList1[i]);
                    }
                    break;
                }

                if (sortedList1[i] > sortedList2[j])
                {
                    mergedList.Add(sortedList2[j++]);
                }
                else
                {
                    mergedList.Add(sortedList1[i++]);
                }
            }
            return mergedList;
        }

        public static Dictionary<string, int> CombineListsToDictionary(List<string> keys, List<int> values)
        {
            Dictionary<string, int> combinedDictionary = new Dictionary<string, int>();
            int shorterLength = (keys.Count > values.Count) ? values.Count : keys.Count;
            for (int i = 0; i < shorterLength; i++)
            {
                combinedDictionary.TryAdd(keys[i], values[i]);
            }
            return combinedDictionary;
        }

        public static Dictionary<string, decimal> MergeDictionaries(Dictionary<string, int> numerators, Dictionary<string, int> denominators)
        {
            Dictionary<string, decimal> mergedDictionary = new Dictionary<string, decimal>();
            List<string> denominatorsToRemove = new List<string>();
            decimal quotient;
            foreach (var numerator in numerators)
            {
                foreach (var denominator in denominators)
                {
                    if (numerator.Key == denominator.Key && denominator.Value != 0)
                    {
                        quotient = (decimal)numerator.Value / (decimal)denominator.Value;
                        quotient = Math.Abs(quotient);
                        mergedDictionary.Add(numerator.Key, quotient);
                    }
                }
            }
            return mergedDictionary;
        }
    }
}
