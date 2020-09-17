using System;
using System.IO;

namespace chapterThirteenProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null) throw new ArgumentNullException(nameof(args));

            string result;
            DirectoryInfo info = new DirectoryInfo("/home/matt");

            result = info.FullName + "\n\n File Names".PadRight(40) + "Size".PadLeft(20) + "\n";
            foreach (FileInfo file in info.GetFiles("*.*")) result += file.Name.PadRight(40) + file.Length.ToString("0#,0").PadLeft(20) + "\n";

            Console.WriteLine(result);
        }
    }
}
