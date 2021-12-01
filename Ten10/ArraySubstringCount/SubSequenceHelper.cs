using System;
using System.Collections.Generic;

namespace ArraySubstringCount
{
    public static class SubSequenceHelper
    {
        public static int SubSequenceCounter(IReadOnlyList<int> array)
        {
            // the result of the function
            var result = 0;

            // current position
            var current = 0;

            // where the position in the array is 0, when the position is less than the length of the array increment the position 
            for (var position = 0; position < array.Count; position++)
            {
                // if the position in the array is greater than 0 AND value of the current position is less than or equal to current position then minus 1
                if (position > 0 && array[position] <= array[position - 1])

                    // then reset the current position
                    current = 0;

                // if the above is not true increment the current position by 1
                current++;

                // set the result to the value of whichever variable is higher between the result and the current position
                result = Math.Max(result, current);
            }

            // return the result
            return result;
        }
    }
}