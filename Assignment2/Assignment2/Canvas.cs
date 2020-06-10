using System.Diagnostics;
using System.IO.Compression;

namespace Assignment2
{
    public static class Canvas
    {
        public enum EShape
        {
            Rectangle,
            IsoscelesRightTriangle,
            IsoscelesTriangle,
            Circle
        }

        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            int i;
            int j;
            uint canvasWidth = width + 4;
            uint canvasHeight = height + 4;
            char[,] canvasArray = new char[canvasHeight, canvasWidth];

            if (width == 0 || height == 0)
            {
                char[,] zeroLengthArray = new char[0, 0];
                return zeroLengthArray;
            }
            else
            {
                switch (shape)
                {
                    case EShape.Rectangle:
                        for (i = 0; i < canvasHeight; i++)
                        {
                            for (j = 0; j < canvasWidth; j++)
                            {
                                if (i == 0 || i == canvasHeight - 1)
                                {
                                    canvasArray[i, j] = '-';
                                }
                                else if (j == 0 || j == canvasWidth - 1)
                                {
                                    canvasArray[i, j] = '|';
                                }
                                else if (i == 1 || i == canvasHeight - 2 || j == 1 || j == canvasWidth - 2)
                                {
                                    canvasArray[i, j] = ' ';
                                }
                                else
                                {
                                    canvasArray[i, j] = '*';
                                }
                            }
                        }
                        break;
                    case EShape.IsoscelesRightTriangle:
                        if (width != height)
                        {
                            char[,] zeroLengthArray = new char[0, 0];
                            return zeroLengthArray;
                        }
                        for (i = 0; i < canvasHeight; i++)
                        {
                            for (j = 0;  j < canvasWidth; j++)
                            {
                                if (i == 0 || i == canvasHeight - 1)
                                {
                                    canvasArray[i, j] = '-';
                                }
                                else if (j == 0 || j == canvasWidth - 1)
                                {
                                    canvasArray[i, j] = '|';
                                }
                                else if (i == 1 || i == canvasHeight - 2 || j == 1 || j == canvasWidth - 2)
                                {
                                    canvasArray[i, j] = ' ';
                                }
                                else if (j <= i)
                                {
                                    canvasArray[i, j] = '*';
                                }
                                else
                                {
                                    canvasArray[i, j] = ' ';
                                }
                            }
                        }
                        break;
                    case EShape.IsoscelesTriangle:
                        if (width != height * 2 -1 )
                        {
                            char[,] zeroLengthArray = new char[0, 0];
                            return zeroLengthArray;
                        }
                        for (i = 0; i < canvasHeight; i++)
                        {
                            for (j = 0; j < canvasWidth; j++)
                            {
                                if (i == 0 || i == canvasHeight - 1)
                                {
                                    canvasArray[i, j] = '-';
                                }
                                else if (j == 0 || j == canvasWidth - 1)
                                {
                                    canvasArray[i, j] = '|';
                                }
                                else if (i == 1 || i == canvasHeight - 2 || j == 1 || j == canvasWidth - 2)
                                {
                                    canvasArray[i, j] = ' ';
                                }
                                else if (canvasWidth/2 - (i-2) <= j && j <= canvasWidth/2 + (i-2))
                                {
                                    canvasArray[i, j] = '*';
                                }
                                else
                                {
                                    canvasArray[i, j] = ' ';
                                }
                            }
                        }
                        break;
                    case EShape.Circle:
                        {
                            int x;
                            int y;
                            int xCentre = (int)canvasWidth / 2;
                            int yCentre = (int)canvasHeight / 2;
                            int r = (int) width / 2; // 변수 이름 바꾸기 
                            // 소수점 이하 버리는 코드 
                            if (width % 2 == 0 || width != height)
                            {
                                char[,] zeroLengthArray = new char[0, 0];
                                return zeroLengthArray;
                            }
                            for (i = 0; i < canvasHeight; i++)
                            {
                                for (j = 0; j < canvasWidth; j++)
                                {
                                    x = xCentre - j;
                                    y = yCentre - i;
                                    if (i == 0 || i == canvasHeight - 1)
                                    {
                                        canvasArray[i, j] = '-';
                                    }
                                    else if (j == 0 || j == canvasWidth - 1)
                                    {
                                        canvasArray[i, j] = '|';
                                    }
                                    else if (i == 1 || i == canvasHeight - 2 || j == 1 || j == canvasWidth - 2)
                                    {
                                        canvasArray[i, j] = ' ';
                                    }
                                    else if (x*x + y*y <= r*r)
                                    {
                                        canvasArray[i, j] = '*';
                                    }
                                    else
                                    {
                                        canvasArray[i, j] = ' ';
                                    }
                                }
                            }
                            break;
                        }
                    default:
                        Debug.Assert(false);
                        break;
                }
            }

            return canvasArray;

        }
    }
}