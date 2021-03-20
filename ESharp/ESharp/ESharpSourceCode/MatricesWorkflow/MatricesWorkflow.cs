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
            var result = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    result *= matrix.GetMatrix()[it, jit];

            return result;
        }

        public int GetMatrixElementsDifference(IAbstractMatrix matrix)
        {
            var result = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    result -= matrix.GetMatrix()[it, jit];

            return result;
        }

        public int GetMatrixElementsDivision(IAbstractMatrix matrix)
        {
            var result = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++) 
                    result /= matrix.GetMatrix()[it, jit];

            return result;
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

        private static int AddValueInArray(IAbstractMatrix matrix, int[] result, int index, int it, int jit)
        {
            result[index] = matrix.GetMatrix()[it, jit];
            index += 1;
            
            return index;
        }
        
        public int[] GetMainDiagonalElementsFromMatrix(IAbstractMatrix matrix)
        {
            var result = new int[matrix.GetLineOfMatrix()];
            var index = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (it == jit)
                        index = AddValueInArray(matrix, result, index, it, jit);
                    

            return result;
        }

        public int[] GetElementsAboveMainDiagonalFromMatrix(IAbstractMatrix matrix)
        {
            var result = new int[matrix.GetLineOfMatrix()];
            var index = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (it > jit)
                        index = AddValueInArray(matrix, result, index, it, jit);

            return result;
        }

        public int[] GetElementsUnderMainDiagonalFromMatrix(IAbstractMatrix matrix)
        {
            var result = new int[matrix.GetLineOfMatrix()];
            var index = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (it < jit)
                        index = AddValueInArray(matrix, result, index, it, jit);

            return result;
        }

        public int[] GetSecondaryDiagonalElementsFromMatrix(IAbstractMatrix matrix)
        {
            var result = new int[matrix.GetLineOfMatrix()];
            var index = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (it + jit == matrix.GetLineOfMatrix() - 1) 
                        index = AddValueInArray(matrix, result, index, it, jit);

            return result;
        }

        public int[] GetElementsAboveSecondaryDiagonalFromMatrix(IAbstractMatrix matrix)
        {
            var result = new int[matrix.GetLineOfMatrix()];
            var index = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (it + jit > matrix.GetLineOfMatrix() - 1) 
                        index = AddValueInArray(matrix, result, index, it, jit);

            return result;
        }

        public int[] GetElementsUnderSecondaryDiagonalFromMatrix(IAbstractMatrix matrix)
        {
            var result = new int[matrix.GetLineOfMatrix()];
            var index = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (it + jit < matrix.GetLineOfMatrix() - 1) 
                        index = AddValueInArray(matrix, result, index, it, jit);

            return result;
        }

        public int[] GetNorthElementsFromMatrix(IAbstractMatrix matrix)
        {
            var result = new int[matrix.GetLineOfMatrix() - 2];
            var index = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (it < jit && it + jit < matrix.GetLineOfMatrix() - 1) 
                        index = AddValueInArray(matrix, result, index, it, jit);

            return result;
        }

        public int[] GetSouthElementsFromMatrix(IAbstractMatrix matrix)
        {
            var result = new int[matrix.GetLineOfMatrix() - 2];
            var index = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (it > jit && it + jit > matrix.GetLineOfMatrix() - 1) 
                        index = AddValueInArray(matrix, result, index, it, jit);

            return result;
        }

        public int[] GetEastElementsFromMatrix(IAbstractMatrix matrix)
        {
            var result = new int[matrix.GetLineOfMatrix() - 2];
            var index = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (it < jit && it + jit > matrix.GetLineOfMatrix() - 1) 
                        index = AddValueInArray(matrix, result, index, it, jit);

            return result;
        }

        public int[] GetWestElementsFromMatrix(IAbstractMatrix matrix)
        {
            var result = new int[matrix.GetLineOfMatrix() - 2];
            var index = 0;
            
            for (var it = 0; it < matrix.GetLineOfMatrix(); it++)
                for (var jit = 0; jit < matrix.GetColumnOfMatrix(); jit++)
                    if (it > jit && it + jit < matrix.GetLineOfMatrix() - 1) 
                        index = AddValueInArray(matrix, result, index, it, jit);

            return result;
        }
    }
}