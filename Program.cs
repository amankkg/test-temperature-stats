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

                var temperature = float.Parse(input);

                if (temperature < 30 || temperature > 41) continue;

                var day = (byte)(entries.Count + 1);
                var entry = new Entry(temperature, day);

                entries.Add(entry);
            }
        }
    }
}
