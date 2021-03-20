using ESharp.DataStructures.Matrix;

namespace ESharp.ESharpSourceCode.MatricesWorkflow
{
    public class MatricesWorkflow : IAbstractMatricesWorkflow
    {
        public int GetMaximumValueFromMatrix(IAbstractMatrix matrix)
        {
            var result = matrix.GetMatrix()[0, 0];
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 1; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (result < matrix.GetMatrix()[it, jit])
                        result = matrix.GetMatrix()[it, jit];

            return result;
        }

        public int GetMinimumValueFromMatrix(IAbstractMatrix matrix)
        {
            var result = matrix.GetMatrix()[0, 0];
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 1; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (result > matrix.GetMatrix()[it, jit])
                        result = matrix.GetMatrix()[it, jit];

            return result;
        }

        public int GetMatrixElementsSum(IAbstractMatrix matrix)
        {
            var result = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    result += matrix.GetMatrix()[it, jit];

            return result;
        }

        public int GetMatrixElementsProduct(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public int GetMatrixElementsDifference(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public int GetMatrixElementsDivision(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public IAbstractMatrix BoostUpMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public IAbstractMatrix BoostDownMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public IAbstractMatrix GetMatricesSum(IAbstractMatrix matrixOne, IAbstractMatrix matrixTwo)
        {
            throw new System.NotImplementedException();
        }

        public IAbstractMatrix GetMatricesDifference(IAbstractMatrix matrixOne, IAbstractMatrix matrixTwo)
        {
            throw new System.NotImplementedException();
        }

        public IAbstractMatrix GetMatricesProduct(IAbstractMatrix matrixOne, IAbstractMatrix matrixTwo)
        {
            throw new System.NotImplementedException();
        }

        public int[] GetMainDiagonalElementsFromMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public int[] GetElementsAboveMainDiagonalFromMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public int[] GetElementsUnderMainDiagonalFromMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public int[] GetSecondaryDiagonalElementsFromMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public int[] GetElementsAboveSecondaryDiagonalFromMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public int[] GetElementsUnderSecondaryDiagonalFromMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public int[] GetNorthElementsFromMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public int[] GetSouthElementsFromMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public int[] GetEastElementsFromMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public int[] GetWestElementsFromMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }
    }
}