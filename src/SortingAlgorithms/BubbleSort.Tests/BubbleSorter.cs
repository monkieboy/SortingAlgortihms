using System.Collections.Generic;

namespace BubbleSort.Tests
{
    public class BubbleSorter : ISorter
    {
        private int allPassed;

        public IEnumerable<int> Sort(int[] numberList)
        {
            var temp = numberList;
            var max = temp.Length;

            while (allPassed < max)
            {
                for (var current = 0; current < max - 1; current++)
                {
                    var next = current + 1;

                    if (next > max || temp[current] <= numberList[next]) continue;

                    ResetPassCount();
                    var first = temp[next];
                    var second = temp[current];
                    temp[current] = first;
                    temp[next] = second;
                }
                allPassed++;
            }
            return temp;
        }

        private void ResetPassCount()
        {
            allPassed = 0;
        }
    }
}