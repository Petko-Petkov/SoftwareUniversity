namespace DynamicList.Test
{
    using System;

    using CustomLinkedList;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CustomLinkedListTests
    {
        [TestMethod]
        public void CreateEmptyLinkedListWithNoElements()
        {
            var listOfNumbers = new DynamicList<int>();

            Assert.AreEqual(0, listOfNumbers.Count, "The count of the elements in the list is not equal to zero");
        }

        [TestMethod]
        public void CreateLinkedListWithExactlyOneElement()
        {
            var listOfNumbers = new DynamicList<int>();

            listOfNumbers.Add(1);

            Assert.AreEqual(1, listOfNumbers.Count, "The count of the linked should be exactly one (1).");
        }

        [TestMethod]
        public void CreateLinkedListWithMoreThanOneElement()
        {
            var listOfNumbers = new DynamicList<int>();

            listOfNumbers.Add(1);
            listOfNumbers.Add(int.MaxValue);
            listOfNumbers.Add(int.MinValue);

            Assert.AreEqual(3, listOfNumbers.Count, "The count of elements is not correct.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIfTheIndexIsMoreThenTheCountOfTheCollection()
        {
            var listOfNumber = new DynamicList<int>();

            listOfNumber.Add(2);

            var index = listOfNumber[2];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIfTheIndexIsLessThenZero()
        {
            var listOfNumber = new DynamicList<int>();

            listOfNumber.Add(2);

            var index = listOfNumber[-1];
        }

        [TestMethod]
        public void FindingValueOfElementAtSpecifiedIndexPosition()
        {
            var listOfNumbers = new DynamicList<int>();

            listOfNumbers.Add(1);
            listOfNumbers.Add(11);
            listOfNumbers.Add(111);

            var index = listOfNumbers.IndexOf(111);

            Assert.AreEqual(111, listOfNumbers[2], "Selected value is not as expected.");
        }

        [TestMethod]
        public void RemovingElementFromItsPositionShouldDecreaseTheCollectionCount()
        {
            var listOfNumbers = new DynamicList<int>();

            listOfNumbers.Add(1);
            listOfNumbers.Add(11);
            listOfNumbers.Add(111);

            listOfNumbers.Remove(1);

            Assert.AreEqual(2, listOfNumbers.Count, "The count of the collection is not correct.");
        }

        [TestMethod]
        public void RemovingElementByItsValueShouldHoldTheElementIndexBeingRemovedAt()
        {
            var listOfNumbers = new DynamicList<int>();

            listOfNumbers.Add(1);
            listOfNumbers.Add(11);
            listOfNumbers.Add(111);

            var index = listOfNumbers.Remove(11);

            Assert.AreEqual(1, index, "The index of the element is not correct.");
        }

        [TestMethod]
        public void RemovingElementAtGivenIndexShouldDecreaseTheCountOfTheCollection()
        {
            var listOfNumbers = new DynamicList<int>();

            listOfNumbers.Add(4);
            listOfNumbers.Add(22);

            listOfNumbers.RemoveAt(0);

            Assert.AreEqual(1, listOfNumbers.Count, "The count of the collection is not as expected.");
        }

        [TestMethod]
        public void RemovingElementAtGivenIndexShouldReturnTheElementValue()
        {
            var listOfNumbers = new DynamicList<int>();

            listOfNumbers.Add(4);
            listOfNumbers.Add(22);

            var number = listOfNumbers.RemoveAt(0);

            Assert.AreEqual(4, number, "The returned value is not as expected.");
        }
    }
}
