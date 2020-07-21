using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var entries = new List<Entry>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "" && entries.Count >= 2) break;

                var temperature = float.Parse(input);

                if (temperature < 30 || temperature > 41) continue;

                var day = (byte)(entries.Count + 1);
                var entry = new Entry(temperature, day);

                entries.Add(entry);
            }

            var statistics = new Statistics(entries);

            var min = statistics.Min;
            var max = statistics.Max;
            var average = statistics.Average;

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(average);
        }
    }
}
