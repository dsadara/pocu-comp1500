using System.Collections.Generic;

namespace Assignment3
{
    public static class TowerOfHanoi
    {

        public static int GetNumberOfSteps(int numDiscs)
        {
            if (numDiscs < 1)
            {
                return -1;
            }
            List<List<int>[]> snapshots = new List<List<int>[]>();
            snapshots = SolveTowerOfHanoi(numDiscs);
            return snapshots.Count - 1;
        }

        public static void TowerOfHanoiRecursive(int discs, int from, int tmp, int to, List<int>[] snapshot, List<List<int>[]> snapshots)
        {
            if (discs == 1)
            {
                snapshot[to].Add(discs);
                //snapshot[from].RemoveAt(snapshot[from].Count - 1);
                snapshot[from].Remove(discs);
                snapshots.Add(new List<int>[3] { new List<int>(snapshot[0]), new List<int>(snapshot[1]) , new List<int>(snapshot[2]) });
            }
            else
            {
                TowerOfHanoiRecursive(discs - 1, from, to, tmp, snapshot, snapshots);
                snapshot[to].Add(discs);
                snapshot[from].Remove(discs);
                snapshots.Add(new List<int>[3] { new List<int>(snapshot[0]), new List<int>(snapshot[1]), new List<int>(snapshot[2]) });
                TowerOfHanoiRecursive(discs - 1, tmp, from, to, snapshot, snapshots);
            }
        }

        public static List<List<int>[]> SolveTowerOfHanoi(int numDiscs)
        {
            if (numDiscs < 1)
            {
                return null;
            }
            List<List<int>[]> snapshots = new List<List<int>[]>();
            List<int> firstPole = new List<int>(); 
            for (int i = numDiscs; i > 0; i--)
            {
                firstPole.Add(i);
            }
            List<int>[] snapshot = new List<int>[3] {firstPole, new List<int>(), new List<int>()};
            snapshots.Add(new List<int>[3] { new List<int>(snapshot[0]), new List<int>(snapshot[1]), new List<int>(snapshot[2]) });
            TowerOfHanoiRecursive(numDiscs, 0, 1, 2, snapshot, snapshots);
            return snapshots;
        }
    }
}
