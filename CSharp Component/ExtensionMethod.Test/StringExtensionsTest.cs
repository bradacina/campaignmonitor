using Shouldly;
using Xunit;

namespace ExtensionMethod.Test
{
    public class StringExtensionsTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsNullOrEmpty_WhenStringIsEmpty_ReturnsTrue(string value)
        {
            value.IsNullOrEmpty().ShouldBeTrue();
        }

        [Theory]
        [InlineData("null")]
        [InlineData(" ")]
        [InlineData("  ")]
        [InlineData(" hello ")]
        [InlineData("hello")]
        public void IsNullOrEmpty_WhenStringIsNotEmpty_ReturnsTrue(string value)
        {
            value.IsNullOrEmpty().ShouldBeFalse();
        }
    }
}
