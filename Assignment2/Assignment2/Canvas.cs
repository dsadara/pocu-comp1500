using System;
using System.Diagnostics;
using System.IO.Compression;

namespace Assignment2
{
    public static class Canvas
    {
        public static Boolean IsShape(char[,] canvas, EShape shape)
        {
            uint i;
            uint j;
            uint canvasHeight = (uint)canvas.GetLength(0);
            uint canvasWidth = (uint)canvas.GetLength(1);
            uint height = canvasHeight - 4;
            uint width = canvasWidth - 4;
            char[,] canvasCompared = new char[canvasHeight, canvasWidth];

            if (canvasHeight == 0 || canvasWidth == 0)
            {
                return false;
            }
            canvasCompared = Draw(width, height, shape);
            if (canvasCompared.GetLength(0) == 0 || canvasCompared.GetLength(1) == 0)
            {
                return false;
            }
            for (i = 0; i < canvasHeight; i++)
            {
                for (j = 0; j < canvasWidth; j++)
                {
                    if (canvas[i, j] != canvasCompared[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            uint i;
            uint j;
            uint canvasWidth = width + 4;
            uint canvasHeight = height + 4;
            char[,] canvasArray;

            if (width == 0 || height == 0)
            {
                canvasArray = new char[0, 0];
                return canvasArray;
            }
            else
            {
                canvasArray = new char[canvasHeight, canvasWidth];
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
                            canvasArray = new char[0, 0];
                            return canvasArray;
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
                        if (width != height * 2 - 1)
                        {
                            canvasArray = new char[0, 0];
                            return canvasArray;
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
                                else if (canvasWidth / 2 - (i - 2) <= j && j <= canvasWidth / 2 + (i - 2))
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
                            int xDistanceFromCenter;
                            int yDistanceFromCenter;
                            uint xOfCircleCenter = canvasWidth / 2;
                            uint yOfCircleCenter = canvasHeight / 2;
                            uint radius = width / 2;  
                            if (width % 2 == 0 || width != height)
                            {
                                canvasArray = new char[0, 0];
                                return canvasArray;
                            }
                            for (i = 0; i < canvasHeight; i++)
                            {
                                for (j = 0; j < canvasWidth; j++)
                                {
                                    xDistanceFromCenter = (int)xOfCircleCenter - (int)j;
                                    yDistanceFromCenter = (int)yOfCircleCenter - (int)i;
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
                                    else if (xDistanceFromCenter * xDistanceFromCenter + yDistanceFromCenter * yDistanceFromCenter <= radius * radius)
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