using ESharp.DataStructures.OneDimensionalArray;
using ESharp.ESharpSourceCode.SpecialOneDimensionalArrayAlgorithms;
using NUnit.Framework;

namespace TestESharp
{
    public class SpecialOneDimensionalArrayAlgorithmsTests
    {
        private IAbstractSpecialOneDimensionalArrayAlgorithms _specialOneDimensionalArrayAlgorithms;
        private IAbstractOneDimensionalArrayObject _array;

        [SetUp]
        public void Setup()
        {
            _specialOneDimensionalArrayAlgorithms = SpecialOneDimensionalArrayAlgorithmsFactoryObject
                .GetSpecialOneDimensionalArrayAlgorithms();

            _array = OneDimensionalArrayFactoryObject.GetOneDimensionalArrayObject();
        }

        [Test]
        public void Test_BubbleSort_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_MinimumValueSort_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_InsertionSort_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_SelectionSort_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_ShellSort_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_LinearSearch_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_BinarySearchValue_()
        {
            Assert.Pass();
        }
    }
}