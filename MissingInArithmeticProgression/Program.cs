using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingInArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>{1, 4, 7, 13, 16, 19};
            
            Console.WriteLine(GetMissingNumber(list));
        }

        private static int GetMissingNumber(List<int> list)
        {
            var increaments = new List<int>();
            
            var range = list.Count > 4 ? list.GetRange(0, 4) : list.GetRange(0, list.Count);
            for (int i = 0; i < range.Count - 1; i++)
            {
                increaments.Add(range[i + 1] - range[i]);
            }

            var increament = increaments.OrderBy(i => i).First();

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            
            return list.Where((t, i) => t + increament != list[i + 1]).Select(t => t + increament).FirstOrDefault();
            
            // Non linq
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] + increament != list[i + 1])
                {
                    return list[i] + increament;
                }
            }
            return 0;
        }
    }
}