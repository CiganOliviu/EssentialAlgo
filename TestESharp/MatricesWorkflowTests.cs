using ESharp.DataStructures.Matrix;
using ESharp.ESharpSourceCode.MatricesWorkflow;
using NUnit.Framework;

namespace TestESharp
{
    public class MatricesWorkflowTests
    {
        private IAbstractMatricesWorkflow _matricesWorkflow;
        private IAbstractMatrix _matrix;
        [SetUp]
        public void Setup()
        {
            _matricesWorkflow = MatricesWorkflowFactoryObject.GetMatricesWorkflowObject();
            _matrix = MatrixFactoryObject.GetMatrixObject();
        }

        [Test]
        public void Test_GetMaximumValueFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new int[,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});
            
            Assert.IsTrue(_matricesWorkflow.GetMaximumValueFromMatrix(_matrix) == 9);
        }
        
        [Test]
        public void Test_GetMinimumValueFromMatrix_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetMatrixElementsSum_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetMatrixElementsProduct_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetMatrixElementsDifference_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetMatrixElementsDivision_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_BoostUpMatrix_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_BoostDownMatrix_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetMatricesSum_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetMatricesDifference_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetMatricesProduct_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetMainDiagonalElementsFromMatrix_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetElementsAboveMainDiagonalFromMatrix_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetElementsUnderMainDiagonalFromMatrix_()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_GetSecondaryDiagonalElementsFromMatrix_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetElementsAboveSecondaryDiagonalFromMatrix_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetElementsUnderSecondaryDiagonalFromMatrix_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetNorthElementsFromMatrix_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetSouthElementsFromMatrix_()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_GetEastElementsFromMatrix_()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test_GetWestElementsFromMatrix_()
        {
            Assert.Pass();
        }
    }
}