using System.Diagnostics;

namespace Lab6
{
    public static class Lab6
    {
        public enum EMode
        {
            HorizontalMirror,
            VerticalMirror,
            DiagonalShift
        }

        public static int[,] Rotate90Degrees(int[,] data)
        {
            int i;
            int j;
            int Row_Length = data.GetLength(0);         // static 으로 바꾸면 좋을 듯 
            int Column_Length = data.GetLength(1);
            int[,] dataRotated = new int[Column_Length, Row_Length];
            for (i = 0; i < Row_Length; i++)
            {
                for (j = 0; j < Column_Length; j++)
                {
                    dataRotated[j, Row_Length - 1 - i] = data[i, j];
                }
            }
            return dataRotated;
        }

        public static void TransformArray(int[,] data, EMode eMode)     //no need ref 
        {
            int i;
            int j;
            int Row_Length = data.GetLength(0);         // static 으로 바꾸면 좋을 듯 
            int Column_Length = data.GetLength(1);
            int[,] dataCopied = new int[Row_Length, Column_Length];

            // 배열 복사
            for (i = 0; i < Row_Length; i++)
            {
                for (j = 0; j < Column_Length; j++)
                {
                    dataCopied[i, j] = data[i, j];
                }
            }

            switch (eMode)
            {
                case EMode.HorizontalMirror:
                    for (i = 0; i < Row_Length; i++)
                    {
                        for (j = 0; j < Column_Length; j++)
                        {
                            data[i, Column_Length - 1 - j] = dataCopied[i, j];
                        }
                    }
                    break;
                case EMode.VerticalMirror:
                    for (i = 0; i < Row_Length; i++)
                    {
                        for (j = 0; j < Column_Length; j++)
                        {
                            data[Row_Length - 1 - i, j] = dataCopied[i, j];
                        }
                    }
                    break;
                case EMode.DiagonalShift:
                    for (i = 0; i < Row_Length; i++)
                    {
                        for (j = 0; j < Column_Length; j++)
                        {
                            data[(i + 1) % Row_Length, (j + 1) % Column_Length] = dataCopied[i, j];
                        }
                    }
                    break;
                defualt:
                    Debug.Assert(false);
                    break;
            }

        }
    }
}
