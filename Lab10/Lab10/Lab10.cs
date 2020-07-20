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
        private double mresult;

        public Rectangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public double GetPerimeter()
        {
            mresult = (Width + Height) * 2.0;
            return Round.GetFourthDecimalPointRounded(mresult);
        }

        public double GetArea()
        {
            mresult = Width * (double)Height;
            return Round.GetFourthDecimalPointRounded(mresult);
        }

    }

    public class RightTriangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }
        private double mresult;
        private double mthirdSide;

        public RightTriangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public double GetPerimeter()
        {
            mthirdSide = Math.Sqrt(Height * Height + (double)Width * Width);
            mresult = Width + Height + mthirdSide;
            return Round.GetFourthDecimalPointRounded(mresult);
        }

        public double GetArea()
        {
            mresult = Width * Height / 2.0;
            return Round.GetFourthDecimalPointRounded(mresult);
        }
    }

    public class Circle
    {
        public uint Radius { get; private set; }
        public uint Diameter { get; private set; }
        private double mresult;
        private const double PI = 3.141592;

        public Circle(uint radius)
        {
            Radius = radius;
            Diameter = radius * 2;
        }

        public double GetCircumference()
        {
            mresult = Diameter * PI;
            return Round.GetFourthDecimalPointRounded(mresult);
        }

        public double GetArea()
        {
            mresult = Radius * Radius * PI;
            return Round.GetFourthDecimalPointRounded(mresult);
        }
    }
}