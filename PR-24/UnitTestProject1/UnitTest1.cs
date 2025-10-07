using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Zadanie1()
        {
            int[] numbers = { 1, -2, 3, 4, -5, 6 };

            int result = TaskSolutions.CountPositiveNumbers(numbers);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Zadanie2()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            TaskSolutions.AddMaxEvenToOdds(array);

            Assert.AreEqual(5, array[0]);
            Assert.AreEqual(2, array[1]);
            Assert.AreEqual(7, array[2]);
            Assert.AreEqual(4, array[3]);
            Assert.AreEqual(9, array[4]);
        }

        [TestMethod]
        public void Zadanie3()
        {
            int[] array = { 5, 2, 3, 1, 6 };

            int result = TaskSolutions.CountBeforeMin(array);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Zadanie4()
        {
            int number = 12345;
            int position = 3;

            int result = TaskSolutions.DigitN(number, position);

            Assert.AreEqual(3, result);
        }
    }
}
