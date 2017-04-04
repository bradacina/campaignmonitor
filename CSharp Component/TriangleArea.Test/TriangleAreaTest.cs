
using System;
using Shouldly;
using Xunit;

namespace TriangleArea.Test
{
    public class TriangleAreaTest
    {
        private const double Delta = 0.000001;
        private const int DecimalNumbers = 5;

        [Theory]
        [InlineData(-1, 3, 5)]
        [InlineData(0, 3, 5)]
        [InlineData(1, 3, 0)]
        [InlineData(-1, -3, -5)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 2, 3)]
        [InlineData(2, 4, 2)]
        public void TriangleArea_InvalidArguments_ThrowsException(int sideA, int sideB, int sideC)
        {
            ShouldThrowExtensions.ShouldThrow<InvalidTriangleException>(() => TriangleHelpers.Area(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(2, 2, 3, 1.98431)]
        [InlineData(2, 2, 2, 1.73205)]
        public void TriangleArea_ValidArguments_ReturnsResult(int sideA, int sideB, int sideC, double result)
        {
            Math.Round(TriangleHelpers.Area(sideA, sideB, sideC), DecimalNumbers). ShouldBeInRange(result - Delta, result + Delta);
        }
    }
}
