using System;
using System.Collections.Generic;

namespace guitarAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = guitarSlot(20, 24, 17.817);
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Item1}:{item.Item2}");
            }
        }

        public static List<(int, double)> guitarSlot(double length, int count, double fret)
        {
            List<(int, double)> results = new List<(int, double)>();

            calculatingFret(results, length, count, fret);

            return results;
        }

        public static List<(int, double)> calculatingFret(List<(int, double)> results, double length, int count, double fret)
        {
            if (count > 1)
            {
                count--;
                double slot = length - (length / fret);
                slot = Math.Round(slot,2);
                results.Add((count,slot));
                calculatingFret(results, slot, count, fret);
            }

            return results;
        }
    }
}
