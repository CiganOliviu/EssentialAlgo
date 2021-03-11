using System;
using ESharp.ESharpSourceCode.NumbersAlgorithms;
using NUnit.Framework;

namespace TestESharp
{
    public class NumbersAlgorithmsTests
    {

        private IAbstractNumbersAlgorithms _numbersAlgorithms;
        
        [SetUp]
        public void Setup()
        {
            _numbersAlgorithms = NumbersAlgorithmsFactoryObject.GetNumbersAlgorithmsObject();
        }

        [Test]
        public void Test_GetTheLargestCommonDivisor_()
        {
            Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisor(8, 12) == 4);
            Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisor(1, 2) == 1);
            Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisor(36, 69) == 3);
            Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisor(100, 50) == 50);
        }
        
        [Test]
        public void Test_GetTheLargestCommonDivisorRecursive_()
        {
            Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisorRecursive(8, 12) == 4);
            Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisorRecursive(1, 2) == 1);
            Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisorRecursive(36, 69) == 3);
            Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisorRecursive(100, 50) == 50);
        }
     
        [Test]
        public void Test_GetTheLeastCommonMultiple_()
        {
            Assert.IsTrue(_numbersAlgorithms.GetTheLeastCommonMultiple(8, 12) == 24);
            Assert.IsTrue(_numbersAlgorithms.GetTheLeastCommonMultiple(1, 2) == 2);
            Assert.IsTrue(_numbersAlgorithms.GetTheLeastCommonMultiple(200, 324) == 16200);
            Assert.IsTrue(_numbersAlgorithms.GetTheLeastCommonMultiple(100, 50) == 100);
        }
        
        [Test]
        public void Test_GetValueIfPrime_()
        {
            Assert.IsTrue(_numbersAlgorithms.GetValueIfPrime(12) == 0);
            Assert.IsTrue(_numbersAlgorithms.GetValueIfPrime(25) == 0);
            Assert.IsTrue(_numbersAlgorithms.GetValueIfPrime(13) == 13);
            Assert.IsTrue(_numbersAlgorithms.GetValueIfPrime(23) == 23);
        }
        
        [Test]
        public void Test_ReverseNumber_()
        {
            Assert.IsTrue(_numbersAlgorithms.ReverseNumber(12) == 21);
            Assert.IsTrue(_numbersAlgorithms.ReverseNumber(25) == 52);
            Assert.IsTrue(_numbersAlgorithms.ReverseNumber(1369895) == 5989631);
            Assert.IsTrue(_numbersAlgorithms.ReverseNumber(333) == 333);
        }
    }
}