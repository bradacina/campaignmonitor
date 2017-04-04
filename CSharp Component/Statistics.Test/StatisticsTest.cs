using System;
using Shouldly;
using Xunit;

namespace Statistics.Test
{
    public class StatisticsTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void ArrayMode_InvalidArgument_ThrowsException(int[] items)
        {
            ShouldThrowExtensions.ShouldThrow<ArgumentException>(() => Statistics.Mode(items));
        }

        [Theory]
        [InlineData(new [] {1,2,3,4,5}, new [] { 1,2,3,4,5})]
        [InlineData(new[] { 1, 2, 3, 1, 5 }, new[] { 1 })]
        [InlineData(new[] { 1, 2, 3, 1, 5, 2 }, new[] { 1, 2 })]
        [InlineData(new[] { 1 }, new[] { 1 })]
        [InlineData(new[] { 1, -2}, new[] { 1, -2 })]
        [InlineData(new[] { 1, 2, 3, 1, 5, 1, 2, 3 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 1, 5 , 1, 2, 3, 1}, new[] { 1 })]
        [InlineData(new[] { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 }, new[] { 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 1, 6, 7 }, new[] {1})]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7 })]
        public void ArrayMode_InvalidArgument_ThrowsException(int[] items, int[] result)
        {
            Statistics.Mode(items).ShouldBeSubsetOf(result);
        }
    }
}
