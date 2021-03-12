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
        
        [Test]
        public void Test_IsOdd_()
        {
            Assert.IsTrue(_numbersPropertiesVerifier.IsOdd(13));
            Assert.IsTrue(_numbersPropertiesVerifier.IsOdd(17));
            Assert.IsFalse(_numbersPropertiesVerifier.IsOdd(22));
            Assert.IsFalse(_numbersPropertiesVerifier.IsOdd(2));
            Assert.IsTrue(_numbersPropertiesVerifier.IsOdd(3));
        }
        
        [Test]
        public void Test_IsEven_()
        {
            Assert.IsTrue(_numbersPropertiesVerifier.IsOdd(13));
            Assert.IsTrue(_numbersPropertiesVerifier.IsOdd(17));
            Assert.IsFalse(_numbersPropertiesVerifier.IsOdd(22));
            Assert.IsFalse(_numbersPropertiesVerifier.IsOdd(2));
            Assert.IsTrue(_numbersPropertiesVerifier.IsOdd(3));
        }
        
        [Test]
        public void Test_IsPalindrome_()
        {
            Assert.IsTrue(_numbersPropertiesVerifier.IsPalindrome(131));
            Assert.IsFalse(_numbersPropertiesVerifier.IsPalindrome(123));
            Assert.IsFalse(_numbersPropertiesVerifier.IsPalindrome(1234));
            Assert.IsTrue(_numbersPropertiesVerifier.IsPalindrome(1));
            Assert.IsTrue(_numbersPropertiesVerifier.IsPalindrome(99));
        }
        
        [Test]
        public void Test_IsPerfectSquare_()
        {
            Assert.IsTrue(_numbersPropertiesVerifier.IsPerfectSquare(144));
            Assert.IsFalse(_numbersPropertiesVerifier.IsPerfectSquare(123));
            Assert.IsTrue(_numbersPropertiesVerifier.IsPerfectSquare(169));
            Assert.IsTrue(_numbersPropertiesVerifier.IsPerfectSquare(4));
            
        }
    }
}