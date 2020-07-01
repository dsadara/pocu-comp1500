namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            bool bPass = false;
            uint[] indexPassed = new uint[20];
            uint callCount = 0;

            // 유효하지 않은 배열 검증
            if (array.Length == 0 || array.Length == 1)
            {
                return bPass;
            }
            if (array[0] <= 0 || array[0] > array.Length - 1)
            {
                return bPass;
            }

            ReachZeroRecursive2(array, indexPassed, array[0], ref bPass, ref callCount);

            return bPass;
        }

        public static bool IsPassedIndex(uint playerLocation, uint[] indexPassed, uint callCount)
        {
            for (int i = 0; i <= callCount; i++)
            {
                if (playerLocation == indexPassed[i])
                {
                    return true;
                }
            }
            return false;
        }

        public static void ReachZeroRecursive2(uint[] array, uint[] indexPassed, uint playerLocation, ref bool bPass, ref uint callCount)
        {
            // end conditions
            if (bPass == true)
            {
                return;
            }
            if (array[playerLocation] == 0)
            {
                bPass = true;
                return;
            }
            if (IsPassedIndex(playerLocation, indexPassed, callCount))
            {
                return;
            }


            indexPassed[callCount] = playerLocation;
            callCount++;

            uint nextLocationRightShift = playerLocation + array[playerLocation];
            uint nextLocationLeftShift = playerLocation - array[playerLocation];
            if (0 <= nextLocationRightShift && nextLocationRightShift <= array.Length - 1)
            {
                ReachZeroRecursive2(array, indexPassed, nextLocationRightShift, ref bPass, ref callCount);
            }
            if (0 <= nextLocationLeftShift && nextLocationLeftShift <= array.Length - 1)
            {
                ReachZeroRecursive2(array, indexPassed, nextLocationLeftShift, ref bPass, ref callCount);
            }
            return;
        }
    }
}
