using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Statistics
    {
        /// <summary>
        /// Calculate the mode of an array of integers
        /// </summary>
        /// <param name="items">The array of integers for which to calculate the mode</param>
        /// <returns>The mode of the array</returns>
        public static int[] Mode(int[] items)
        {
            if (items == null || items.Length == 0)
            {
                throw new ArgumentException("Items is empty");
            }

            var counts = new Dictionary<int,int>();
            var rollingMaximum = 1;

            foreach (var item in items)
            {
                if (counts.ContainsKey(item))
                {
                    ++counts[item];
                    
                    if (counts[item] > rollingMaximum)
                    {
                        rollingMaximum = counts[item];
                    }
                }
                else
                {
                    counts.Add(item, 1);
                }
            }

            var result = new List<int>();

            foreach (var kv in counts)
            {
                if (kv.Value == rollingMaximum)
                {
                    result.Add(kv.Key);
                }
            }

            return result.ToArray();
        }
    }
}
