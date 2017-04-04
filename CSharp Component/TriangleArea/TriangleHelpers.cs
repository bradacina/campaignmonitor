using System;

namespace TriangleArea
{
    public class TriangleHelpers
    {
        // we assume we don't allow floating point numbers as inputs
        private const int MinimumAllowedSideSize = 1;

        /// <summary>
        /// Calculate the area of a triangle given its sides
        /// </summary>
        /// <param name="sideA">The size of side A</param>
        /// <param name="sideB">The size of side B</param>
        /// <param name="sideC">The size of side C</param>
        /// <returns>The area of the triangle</returns>
        public static double Area(int sideA, int sideB, int sideC)
        {
            if (sideA < MinimumAllowedSideSize 
                || sideB < MinimumAllowedSideSize
                || sideC < MinimumAllowedSideSize)
            {
                throw new InvalidTriangleException();
            }

            // the sum of any two sides must be greated than the third side
            if ((sideA + sideB) <= sideC
                || (sideB + sideC) <= sideA
                || (sideA + sideC) <= sideB)
            {
                throw new InvalidTriangleException();
            }

            // calculate area of triangle 
            // https://en.wikipedia.org/wiki/Triangle#Using_Heron.27s_formula

            var semiPerimeter = (double)(sideA + sideB + sideC)/2;

            return Math.Sqrt(semiPerimeter*(semiPerimeter - sideA)*(semiPerimeter - sideB)*(semiPerimeter - sideC));
        }
    }
}
