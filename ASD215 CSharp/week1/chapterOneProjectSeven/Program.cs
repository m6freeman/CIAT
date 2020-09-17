using System;

namespace chapterOneProjectSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("******************************************\n");
            Console.Write("*|\tName: Matthew Freeman\\\t\t *\n");
            Console.Write("* \tHometown: Thousand Oaks\\\t *\n");
            Console.Write("* \tMajor: CS\\\t\t\t *\n");
            Console.Write("* \tHobby: Programming\\\t\t *\n");
            Console.Write("* \tFavorite Activity: Programming\\\t|*\n");
            Console.Write("******************************************\n");

        }
    }
}
