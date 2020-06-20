using System.Diagnostics;

namespace Lab6
{
    public static class Lab6Edited
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
            int temp;
            int temp1;
            int temp2;

            switch (eMode)
            {
                case EMode.HorizontalMirror:
                    for (i = 0; i < rowLength; i++)
                    {
                        for (j = 0; j < columnLength / 2; j++)
                        {
                            temp = data[i, j];
                            data[i, j] = data[i, columnLength - 1 - j];
                            data[i, columnLength - 1 - j] = temp;                            
                        }
                    }
                    break;
                case EMode.VerticalMirror:
                    for (j = 0; j < columnLength; j++)
                    {
                        for (i = 0; i < rowLength/2; i++)
                        {
                            temp = data[i, j];
                            data[i, j] = data[rowLength - 1 - i, j];
                            data[rowLength - 1 - i, j] = temp;                            
                        }
                    }
                    break;
                case EMode.DiagonalShift:
                    for (i = 0; i < rowLength; i++)
                    {
                        temp1 = data[i, columnLength - 1];
                        for (j = 0; j < columnLength; j++)
                        {
                            temp2 = data[i, j];
                            data[i, j] = temp1;
                            temp1 = temp2;                                                                     
                        }
                    }
                    for (j = 0; j < columnLength; j++)
                    {
                        temp1 = data[rowLength - 1, j];
                        for (i = 0; i < rowLength; i++)
                        {
                            temp2 = data[i, j];
                            data[i, j] = temp1;
                            temp1 = temp2;
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
