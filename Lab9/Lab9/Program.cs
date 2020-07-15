using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 1, 1, 5, 10 };
            List<int> list2 = new List<int> { 2, 4 };

            List<int> combinedList = Lab9.MergeLists(list1, list2);
            List<int> expectedList = new List<int> { 1, 1, 1, 2, 4, 5, 10 };

            Console.WriteLine($"[ {string.Join(", ", combinedList)} ]");

            for (int i = 0; i < expectedList.Count; i++)
            {
                Debug.Assert(expectedList[i] == combinedList[i]);
            }

            list1 = new List<int> { 1, 2, 5, 10 };
            list2 = new List<int> { 1, 3, 5, 10};

            combinedList = Lab9.MergeLists(list1, list2);
            expectedList = new List<int> { 1, 1, 2, 3, 5, 5, 10, 10 };

            Console.WriteLine($"[ {string.Join(", ", combinedList)} ]");

            for (int i = 0; i < expectedList.Count; i++)
            {
                Debug.Assert(expectedList[i] == combinedList[i]);
            }

            list1 = new List<int> { 1, 1, 1, 5, 10 };
            list2 = new List<int> { 1, 1, 1, 5, 8, 10 };

            combinedList = Lab9.MergeLists(list1, list2);
            expectedList = new List<int> { 1, 1, 1, 1, 1, 1, 5, 5, 8, 10, 10 };

            Console.WriteLine($"[ {string.Join(", ", combinedList)} ]");

            for (int i = 0; i < expectedList.Count; i++)
            {
                Debug.Assert(expectedList[i] == combinedList[i]);
            }


            list1 = new List<int> { 1, 1, 1};
            list2 = new List<int> { 2, 2, 2, };

            combinedList = Lab9.MergeLists(list1, list2);
            expectedList = new List<int> { 1, 1, 1, 2, 2, 2};

            Console.WriteLine($"[ {string.Join(", ", combinedList)} ]");

            for (int i = 0; i < expectedList.Count; i++)
            {
                Debug.Assert(expectedList[i] == combinedList[i]);
            }

            list1 = new List<int> {1, 2, 5, 10, 10, 10, 10};
            list2 = new List<int> { 10, 11, 12, 15};

            combinedList = Lab9.MergeLists(list1, list2);
            expectedList = new List<int> { 1, 2, 5, 10, 10, 10, 10, 10, 11, 12, 15};

            Console.WriteLine($"[ {string.Join(", ", combinedList)} ]");

            for (int i = 0; i < expectedList.Count; i++)
            {
                Debug.Assert(expectedList[i] == combinedList[i]);
            }
        }

        private static void printDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[ ");

            foreach (var keyvaluepair in dict)
            {
                sb.Append($"{{ {keyvaluepair.Key}, {keyvaluepair.Value} }}, ");
            }

            string s = sb.ToString().Trim().Trim(',');
            Console.WriteLine($"{s} ]");
        }
    }
}
