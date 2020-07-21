using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Statistics
    {
        private readonly IEnumerable<Entry> _entries;

        public float Min { get; }
        public float Max { get; }
        public float Average { get; }

        public Statistics(IEnumerable<Entry> entries)
        {
            _entries = entries;

            Min = GetMin();
            Max = GetMax();
            Average = GetAverage();
        }

        float GetMin()
        {
            return _entries.Aggregate(
                41f,
                (min, entry) => Math.Min(min, entry.Temperature));
        }

        float GetMax()
        {
            return _entries.Aggregate(
                30f,
                (max, entry) => Math.Max(max, entry.Temperature));
        }

        float GetAverage()
        {
            var sum = _entries.Aggregate((float)0, (sum, entry) => sum + entry.Temperature);
            var count = _entries.Count();
            var result = sum / count;

            return result;
        }
    }
}
