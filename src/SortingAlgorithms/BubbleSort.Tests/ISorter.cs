using System.Collections.Generic;

namespace BubbleSort.Tests
{
    public interface ISorter
    {
        IEnumerable<int> Sort(int[] numberList);
    }
}