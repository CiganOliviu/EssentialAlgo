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
        public void Test__()
        {
            Assert.Pass();
        }
    }
}