using Shouldly;
using Xunit;

namespace ArraySubstringCount
{
    public class SortingTests
    {
        [Theory]
        [InlineData(new[] { 1, 4, 1, 4, 2, 1, 3, 5, 6, 2, 3, 7 }, 4)]
        //[InlineData(new[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 }, 3)]
        //[InlineData(new[] { 2, 7, 1, 8, 2, 8, 1 }, 2)]
        //[InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10)]
        //[InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 }, 9)]
        public void RunSubSequenceCounter(int[] array, int expectedOutput)
        {
            SubSequenceHelper.SubSequenceCounter(array).ShouldBe(expectedOutput);
        }
    }
}