using System;
using System.Collections.Generic;

namespace Divisors
{
    public class Divisors
    {
        private const int MinimumAllowedInput = 1;
        /// <summary>
        /// Returns an IEnumerable of divisors for a given number. Note: number should be a positive integer greater than 0
        /// </summary>
        /// <param name="number">The number for which to calculate divisors</param>
        /// <returns>An IEnumerable of divisors</returns>
        public static IEnumerable<int> GetDivisors(int number)
        {
            if (number < MinimumAllowedInput)
            {
                throw new ArgumentException("Number must be greate than 0");
            }

            var result = new List<int> { 1 };

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
