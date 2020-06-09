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
            int rowLength = data.GetLength(0);         
            int columnLength = data.GetLength(1);
            int[,] dataRotated = new int[columnLength, rowLength];
            for (i = 0; i < rowLength; i++)
            {
                for (j = 0; j < columnLength; j++)
                {
                    dataRotated[j, rowLength - 1 - i] = data[i, j];
                }
            }
            return dataRotated;
        }

        public static void TransformArray(int[,] data, EMode eMode)
        {
            int i;
            int j;
            int rowLength = data.GetLength(0);        
            int columnLength = data.GetLength(1);
            int[,] dataCopied = new int[rowLength, columnLength];

            // 배열 복사
            for (i = 0; i < rowLength; i++)
            {
                for (j = 0; j < columnLength; j++)
                {
                    dataCopied[i, j] = data[i, j];
                }
            }

            switch (eMode)
            {
                case EMode.HorizontalMirror:
                    for (i = 0; i < rowLength; i++)
                    {
                        for (j = 0; j < columnLength; j++)
                        {
                            data[i, columnLength - 1 - j] = dataCopied[i, j];
                        }
                    }
                    break;
                case EMode.VerticalMirror:
                    for (i = 0; i < rowLength; i++)
                    {
                        for (j = 0; j < columnLength; j++)
                        {
                            data[rowLength - 1 - i, j] = dataCopied[i, j];
                        }
                    }
                    break;
                case EMode.DiagonalShift:
                    for (i = 0; i < rowLength; i++)
                    {
                        for (j = 0; j < columnLength; j++)
                        {
                            data[(i + 1) % rowLength, (j + 1) % columnLength] = dataCopied[i, j];
                        }
                    }
                    break;
                default:
                    Debug.Assert(false);
                    break;
            }

        }
    }
}
