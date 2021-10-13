using System;
using Xunit;

namespace AlgoPatternsCore.Test
{
    public class SlidingWindowTest
    {
        [Fact]
        public void StandardComplexWay()
        {
            int[] valuesArray = {1, 4, 2, 10, 2, 3, 1, 0, 20};
            int sum = SolvingStandard.MaxSum(valuesArray, valuesArray.Length, 4);
            
            Assert.Equal(24, sum);
        }
        
        [Fact]
        public void SlidingWindowPatternWay()
        {
            int[] valuesArray = {1, 4, 2, 10, 2, 3, 1, 0, 20};
            int sum = SlidingWindow.MaxSum(valuesArray, valuesArray.Length, 4);
            
            Assert.Equal(24, sum);
        }
    }
}