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
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});
            
            Assert.IsTrue(_matricesWorkflow.GetMaximumValueFromMatrix(_matrix) == 9);
        }
        
        [Test]
        public void Test_GetMinimumValueFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});
            
            Assert.IsTrue(_matricesWorkflow.GetMinimumValueFromMatrix(_matrix) == 1);
        }
        
        [Test]
        public void Test_GetMatrixElementsSum_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});
            
            Assert.IsTrue(_matricesWorkflow.GetMatrixElementsSum(_matrix) == 45);
        }
        
        [Test]
        public void Test_GetMatrixElementsProduct_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {0, 8, 9}});
            
            Assert.IsTrue(_matricesWorkflow.GetMatrixElementsProduct(_matrix) == 0);
        }
        
        [Test]
        public void Test_GetMatrixElementsDifference_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{-1, -2, -3}, {-4, -5, -6}, {-7, -8, -9}});
            
            Assert.IsTrue(_matricesWorkflow.GetMatrixElementsDifference(_matrix) == 45);
        }
        
        [Test]
        public void Test_GetMatrixElementsDivision_()
        {
            _matrix.SetLineOfMatrix(2);
            _matrix.SetColumnOfMatrix(2);
            _matrix.SetMatrix(new [,]{{4, 3}, {2, 1}});
            
            Assert.IsTrue(_matricesWorkflow.GetMatrixElementsDivision(_matrix) == 0);
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
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});

            var expected = new int[] {1, 5, 9};
            
            Assert.AreEqual(_matricesWorkflow.GetMainDiagonalElementsFromMatrix(_matrix), expected);
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