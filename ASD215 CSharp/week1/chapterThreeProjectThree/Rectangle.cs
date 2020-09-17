using System;

namespace chapterThreeProjectThree
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Unit { get; set; }
        public Rectangle(int height, int width, string unit = "cm")
        {
            Height = height;
            Width = width;
            Unit = unit;
            Console.WriteLine("Height\t\t" + Height);
            Console.WriteLine("Width\t\t" + Width);
            Console.WriteLine("Area\t\t" + CalculateArea() + " " + Unit + " squared");
            Console.WriteLine("Perimeter\t" + CalculatePerimeter() + " " + Unit);
        }

        private string CalculateArea() => (Height * Width).ToString("n1");

        private string CalculatePerimeter() => ((Height * 2) + (Width * 2)).ToString("n1");
    }
}
