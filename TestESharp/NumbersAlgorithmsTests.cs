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
        
    }
}