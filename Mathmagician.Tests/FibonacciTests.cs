using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciEnsureICanCreateInstance()
        {
            Fibonacci my_Fibonaccis = new Fibonacci();
            Assert.IsNotNull(my_Fibonaccis);
        }

        [TestMethod]
        public void FibonacciEnsureICanGetFirst()
        {
            // Arrange
            Fibonacci my_Fibonaccis = new Fibonacci();

            // Act
            int actual = my_Fibonaccis.GetFirst();
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciEnsureICanGetNext()
        {
            // Arrange
            Fibonacci my_Fibonaccis = new Fibonacci();

            // Act
            int actual = my_Fibonaccis.GetNext(8);
            int expected = 13;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciIntegerEnsureICanCreateASequenceOfTen()
        {
            // Arrange
            Fibonacci my_Fibonaccis = new Fibonacci();

            // Act
            int[] actual = my_Fibonaccis.GetSequence(10);
            int[] expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciCalc10thFibonacciNumber()
        {
            // Arrange
            Fibonacci my_Fibonaccis = new Fibonacci();

            // Act
            int actual = my_Fibonaccis.GetNth(10);
            int expected = 55;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciCalc2ndFibonacciNumber()
        {
            // Arrange
            Fibonacci my_Fibonaccis = new Fibonacci();

            // Act
            int actual = my_Fibonaccis.GetNth(2);
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FibonacciEnsureValidNs()
        {
            // Arrange 
            Fibonacci my_fibo = new Fibonacci();

            // Act
            my_fibo.GetNth(-2);
        }

        [TestMethod]
        public void FibonacciCalc8thFiboWithCache()
        {
            // Arrange
            Fibonacci my_fibo = new Fibonacci();

            // Act
            int actual = my_fibo.GetNthCached(8);
            int expected = 21;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArraysAreTheItemsThere()
        {
            int[] elements = new int[10];
            elements[0] = 2;
            elements[1] = 4;

            int actual = elements[2];
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void ArrayHowDoIUseFindIndex()
        {
            int[] my_sequence = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            int actual_index = Array.FindIndex(my_sequence, value => 8 == value);
            int expected_index = 5;
        }
        
        private static bool GetIt(int value)
        {
            if (value == 8)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
