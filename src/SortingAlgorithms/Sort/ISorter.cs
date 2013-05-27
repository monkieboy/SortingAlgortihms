using System.Collections.Generic;

namespace Sort
{
    public interface ISorter
    {
        IEnumerable<int> IntegerSort(int[] numberList);
    }
}