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

        public static void ReachZeroRecursive(uint[] array, uint[] indexPassed, uint playerLocation, ref bool bPass, ref uint callCount)
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

            uint[] nextLocation = new uint[array[playerLocation] + 1];
            int temp;
            for (int i = 0; i < array[playerLocation] + 1; i++)
            {
                
                temp = (int)playerLocation + (i) - ((int)array[playerLocation] - i);
                if (temp <= 0 || temp > array.Length - 1)
                {
                    continue;
                }
                if (array[temp] == 0)
                {
                    bPass = true;
                    return; 
                }
                nextLocation[i] = (uint)temp;
            }

            // 점프할 수 있는 방법의 수 만큼 반복 
            // 예) 2번 점프는 3가지 경우의 수 (오,오) (왼,오) (왼,왼)
            for (uint i = 0; i < array[playerLocation] + 1; i++)
            {
                ReachZeroRecursive(array, indexPassed, nextLocation[i], ref bPass, ref callCount);
            }
            /*
            for (uint i = 0; i < array[playerLocation] + 1; i++)
            {
                nextLocation = (int)playerLocation + (i) - ((int)array[playerLocation] - i);

                if (nextLocation <= 0 || nextLocation > array.Length - 1)
                {
                    continue;
                }
                ReachZeroRecursive(array, indexPassed, nextLocation, ref bPass, ref callCount);
            } 
            */
            return;
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

            uint nextLocation;

            for (uint i = 0; i < array[playerLocation] + 1; i++)
            {
                nextLocation = playerLocation + (i) - (array[playerLocation] - i);

                if (nextLocation <= 0 || nextLocation > array.Length - 1)
                {
                    continue;
                }
                ReachZeroRecursive(array, indexPassed, nextLocation, ref bPass, ref callCount);
            } 
            return;
        }
    }
}
