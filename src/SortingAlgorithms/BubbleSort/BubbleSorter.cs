using System.Collections.Generic;
using System.Linq;
using Sort;

namespace BubbleSort
{
    public class BubbleSorter : ISorter
    {
        public IEnumerable<int> IntegerSort(int[] numberList)
        {
            var temp = numberList;
            var max = temp.Length;

            while (!CheckIfAllAreSorted(temp))
            {
                for (var current = 0; current < max - 1; current++)
                {
                    var next = current + 1;

                    if (next > max || temp[current] <= numberList[next]) continue;

                    var first = temp[next];
                    var second = temp[current];
                    temp[current] = first;
                    temp[next] = second;
                    if (CheckIfAllAreSorted(temp)) break;
                }
            }
            return temp;
        }

        private bool CheckIfAllAreSorted(IList<int> sequence)
        {
            for (var i = 0; i < sequence.Count-1; i++)
                if (sequence[i] > sequence[i + 1])
                    return false;

            return true;
        }
    }
}