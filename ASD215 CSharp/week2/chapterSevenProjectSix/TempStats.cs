using System.Linq;

namespace chapterSevenProjectSix
{
    class TempStats
    {
        public int[] Temps { get; set; }
        public TempStats(int[] temps) => Temps = temps;

        public int GetHighest() => Temps.Max();

        public double GetAverage() => Temps.Take(Temps.Length).Average();

        public double GetAverageExcludingLowest() => Temps.OrderByDescending(temp => temp).Take(Temps.Length - 1).Average();

        public int GetLowest() => Temps.Min();

        public override string ToString()
        {
            string toString = "Values in Temperature Array";
            Temps.Select((v, i) => new {Value = v, Index = i}).ToList().ForEach(temp =>
            {
                toString += (temp.Index % 3 == 0) ? "\n" + temp.Value : "\t" + temp.Value;
            });
            toString += $"\nTemperatures ranged from {GetLowest()} and {GetHighest()}";
            return toString;
        }

        public int GetNumberOfTempsLowerThan(int tempToCompare) => Temps.Select(temp => temp).Where(temp => temp < tempToCompare).ToArray().Count();

    }
}
