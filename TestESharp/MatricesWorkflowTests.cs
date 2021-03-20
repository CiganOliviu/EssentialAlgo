﻿using ESharp.DataStructures.Matrix;
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
            Assert.Fail();
        }
        
        [Test]
        public void Test_BoostDownMatrix_()
        {
            Assert.Fail();
        }
        
        [Test]
        public void Test_GetMatricesSum_()
        {
            Assert.Fail();
        }
        
        [Test]
        public void Test_GetMatricesDifference_()
        {
            Assert.Fail();
        }
        
        [Test]
        public void Test_GetMatricesProduct_()
        {
            Assert.Fail();
        }
        
        [Test]
        public void Test_GetMainDiagonalElementsFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});

            var expected = new [] {1, 5, 9};
            
            Assert.AreEqual(_matricesWorkflow.GetMainDiagonalElementsFromMatrix(_matrix), expected);
        }
        
        [Test]
        public void Test_GetElementsAboveMainDiagonalFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});

            var expected = new [] {4, 7, 8};
            
            Assert.AreEqual(_matricesWorkflow.GetElementsAboveMainDiagonalFromMatrix(_matrix), expected);
        }
        
        [Test]
        public void Test_GetElementsUnderMainDiagonalFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});

            var expected = new [] {2, 3, 6};
            
            Assert.AreEqual(_matricesWorkflow.GetElementsUnderMainDiagonalFromMatrix(_matrix), expected);
        }

        [Test]
        public void Test_GetSecondaryDiagonalElementsFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});

            var expected = new [] {3, 5, 7};
            
            Assert.AreEqual(_matricesWorkflow.GetSecondaryDiagonalElementsFromMatrix(_matrix), expected);
        }
        
        [Test]
        public void Test_GetElementsAboveSecondaryDiagonalFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});

            var expected = new [] {6, 8, 9};
            
            Assert.AreEqual(_matricesWorkflow.GetElementsAboveSecondaryDiagonalFromMatrix(_matrix), expected);
        }
        
        [Test]
        public void Test_GetElementsUnderSecondaryDiagonalFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});

            var expected = new [] {1, 2, 4};
            
            Assert.AreEqual(_matricesWorkflow.GetElementsUnderSecondaryDiagonalFromMatrix(_matrix), expected);
        }
        
        [Test]
        public void Test_GetNorthElementsFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});

            var expected = new [] {2};
            
            Assert.AreEqual(_matricesWorkflow.GetNorthElementsFromMatrix(_matrix), expected);
        }
        
        [Test]
        public void Test_GetSouthElementsFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});

            var expected = new [] {8};
            
            Assert.AreEqual(_matricesWorkflow.GetSouthElementsFromMatrix(_matrix), expected);

        }

        [Test]
        public void Test_GetEastElementsFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});

            var expected = new [] {6};
            
            Assert.AreEqual(_matricesWorkflow.GetEastElementsFromMatrix(_matrix), expected);

        }
        
        [Test]
        public void Test_GetWestElementsFromMatrix_()
        {
            _matrix.SetLineOfMatrix(3);
            _matrix.SetColumnOfMatrix(3);
            _matrix.SetMatrix(new [,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});

            var expected = new [] {4};
            
            Assert.AreEqual(_matricesWorkflow.GetWestElementsFromMatrix(_matrix), expected);

        }
    }
}