using System;

namespace Lab10
{
    public static class Round
    {
        public static double GetFourthDecimalPointRounded(double result)
        {
            return (int)(result * 1000 + 0.5) / 1000.0;
        }
    }
    public class Rectangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }
        private double mResult;

        public Rectangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public double GetPerimeter()
        {
            mResult = (Width + Height) * 2.0;
            return Round.GetFourthDecimalPointRounded(mResult);
        }

        public double GetArea()
        {
            mResult = Width * (double)Height;
            return Round.GetFourthDecimalPointRounded(mResult);
        }

    }

    public class RightTriangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }
        private double mResult;
        private double mThirdSide;

        public RightTriangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public double GetPerimeter()
        {
            mThirdSide = Math.Sqrt(Height * Height + (double)Width * Width);
            mResult = Width + Height + mThirdSide;
            return Round.GetFourthDecimalPointRounded(mResult);
        }

        public double GetArea()
        {
            mResult = Width * Height / 2.0;
            return Round.GetFourthDecimalPointRounded(mResult);
        }
    }

    public class Circle
    {
        public uint Radius { get; private set; }
        public uint Diameter { get; private set; }
        private double mResult;
        // private const double PI = 3.141592;

        public Circle(uint radius)
        {
            Radius = radius;
            Diameter = radius * 2;
        }

        public double GetCircumference()
        {
            mResult = Diameter * Math.PI;
            return Round.GetFourthDecimalPointRounded(mResult);
        }

        public double GetArea()
        {
            mResult = Radius * Radius * Math.PI;
            return Round.GetFourthDecimalPointRounded(mResult);
        }
    }
}