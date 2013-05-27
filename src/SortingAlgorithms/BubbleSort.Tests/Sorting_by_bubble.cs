using FluentAssertions;
using NUnit.Framework;

namespace BubbleSort.Tests
{
    [TestFixture]
    public class Sorting_by_bubble
    {
        private ISorter sorter;

        [SetUp]
        public void SetUp()
        {
            sorter = new BubbleSorter();
        }

        [Test]
        public void Should_return_1_when_list_contains_only_1_number_which_is_number_1()
        {
            var numberList = new[] { 1 };

            sorter.Sort(numberList).Should().ContainInOrder(1);
        }

        [Test]
        public void Should_return_12_when_given_21()
        {
            var numberList = new[] { 2, 1 };

            sorter.Sort(numberList).Should().ContainInOrder(1, 2);
        }

        [Test]
        public void Should_return_123_when_given_213()
        {
            var numberList = new[] { 2, 1, 3 };

            sorter.Sort(numberList).Should().ContainInOrder(1, 2, 3);
        }

        [Test]
        public void Should_return_1234_when_given_4321()
        {
            var numberList = new[] { 4, 3, 2, 1 };

            sorter.Sort(numberList).Should().ContainInOrder(1, 2, 3, 4);
        }

        [Test]
        public void Should_return_123456789_when_given_432198765()
        {
            var numberList = new[] { 4, 3, 2, 1, 9, 8, 7, 6, 5 };

            sorter.Sort(numberList).Should().ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9);
        }

        [Test]
        public void Should_return_1345789_when_given_4319875()
        {
            var numberList = new[] { 4, 3, 1, 9, 8, 7, 5 };

            sorter.Sort(numberList).Should().ContainInOrder(1, 3, 4, 5, 7, 8, 9);
        }

        [Test]
        public void Should_return_01345789_when_given_43109875()
        {
            var numberList = new[] { 4, 3, 1, 0, 9, 8, 7, 5 };

            sorter.Sort(numberList).Should().ContainInOrder(0, 1, 3, 4, 5, 7, 8, 9);
        }
    }
}