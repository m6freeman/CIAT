using System;

namespace chapterThreeProjectThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height of a rectangle: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the width of a rectangle: ");
            int w = Convert.ToInt32(Console.ReadLine());

            Rectangle r = new Rectangle(h, w);
        }
    }
}
