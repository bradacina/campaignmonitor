
using System;
using System.Collections.Generic;
using Shouldly;
using Xunit;

namespace Divisors.Test
{
    public class DivisorsTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-3)]
        public void GetDivisors_InputIsInvalid_ThrowsException(int number)
        {
            ShouldThrowExtensions.ShouldThrow<ArgumentException>(() => Divisors.GetDivisors(number));
        }


        [Fact]
        public void GetDivisors_InputIsValid_ReturnsDivisors()
        {
            Divisors.GetDivisors(1).ShouldBeSubsetOf(new List<int> {1});
            Divisors.GetDivisors(2).ShouldBeSubsetOf(new List<int> { 1,2 });
            Divisors.GetDivisors(3).ShouldBeSubsetOf(new List<int> { 1, 2, 3 });
            Divisors.GetDivisors(4).ShouldBeSubsetOf(new List<int> { 1, 2, 4 });
            Divisors.GetDivisors(5).ShouldBeSubsetOf(new List<int> { 1, 5 });
            Divisors.GetDivisors(9).ShouldBeSubsetOf(new List<int> { 1, 3, 9 });
            Divisors.GetDivisors(10).ShouldBeSubsetOf(new List<int> { 1, 2, 5, 10 });
            Divisors.GetDivisors(11).ShouldBeSubsetOf(new List<int> {1, 11});
            Divisors.GetDivisors(13).ShouldBeSubsetOf(new List<int> { 1, 13 });
            Divisors.GetDivisors(20).ShouldBeSubsetOf(new List<int> { 1, 2, 4, 5, 10, 20 });
        }
    }
}
