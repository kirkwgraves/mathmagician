﻿using System;
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
            int actual = 1;
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciCalc4thFibonacciNumber()
        {
            // Arrange
            Fibonacci my_Fibonaccis = new Fibonacci();

            // Act
            int actual = my_Fibonaccis.GetNth(10);
            int expected = 89;

            // Assert
            Assert.AreEqual(actual, expected);
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
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void FibonacciEnsureICanGetNext()
        {
            // Arrange
            Fibonacci my_Fibonaccis = new Fibonacci();

            // Act
            int actual = my_Fibonaccis.GetNext(7);
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
            int[] expected = new int[] { 1, 1, 3, 5, 8, 13, 21, 34, 55, 89 };

            // Assert
            CollectionAssert.AreEqual(expected, actual);
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
    }
}
