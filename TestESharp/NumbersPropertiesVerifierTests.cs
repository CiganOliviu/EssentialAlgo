using System;
using ESharp.ESharpSourceCode.NumbersAlgorithms;
using ESharp.ESharpSourceCode.NumbersPropertiesVerifier;
using NUnit.Framework;

namespace TestESharp
{
    public class NumbersPropertiesVerifierTests
    {
        private IAbstractNumbersPropertiesVerifier _numbersPropertiesVerifier;

        [SetUp]
        public void Setup()
        {
            _numbersPropertiesVerifier = NumbersPropertiesVerifierFactoryObject.GetNumbersPropertiesVerifier();
        }

        [Test]
        public void Test_IsPrime_()
        {
            Assert.IsTrue(_numbersPropertiesVerifier.IsPrime(13));
            Assert.IsFalse(_numbersPropertiesVerifier.IsPrime(16));
            Assert.IsTrue(_numbersPropertiesVerifier.IsPrime(31));
            Assert.IsFalse(_numbersPropertiesVerifier.IsPrime(6));
            Assert.IsFalse(_numbersPropertiesVerifier.IsPrime(21));
        }
    }
}