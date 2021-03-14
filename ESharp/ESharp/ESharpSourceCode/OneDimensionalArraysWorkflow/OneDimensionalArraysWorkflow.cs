using System;
using ESharp.DataStructures.OneDimensionalArray;

namespace ESharp.ESharpSourceCode.OneDimensionalArraysWorkflow
{
    public class OneDimensionalArraysWorkflow : IAbstractOneDimensionalArraysWorkflow
    {
        public int GetMinimumValueFromArray(IAbstractOneDimensionalArrayObject array)
        {
            var min = array.GetOneDimensionalArray()[0];
            
            for (var it = 1; it < array.GetLengthOfOneDimensionalArray(); it++)
                if (min > array.GetOneDimensionalArray()[it])
                    min = array.GetOneDimensionalArray()[it];

            return min;
        }

        public int GetMaximumValueFromArray(IAbstractOneDimensionalArrayObject array)
        {
            var max = array.GetOneDimensionalArray()[0];
            
            for (var it = 1; it < array.GetLengthOfOneDimensionalArray(); it++)
                if (max < array.GetOneDimensionalArray()[it])
                    max = array.GetOneDimensionalArray()[it];

            return max;
        }

        public int GetArrayElementsSum(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public int GetArrayElementsProduct(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public int GetArrayElementsDifference(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public int GetArrayElementsDivision(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public int GetArrayElementsMean(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public bool IsArraySymmetric(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public int AddValueInArray(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public bool IsValueInArray(IAbstractOneDimensionalArrayObject array, int value)
        {
            throw new System.NotImplementedException();
        }

        public int[] ConvertNumberToArray(int number)
        {
            throw new System.NotImplementedException();
        }

        public int ConvertArrayToNumber(int[] array)
        {
            throw new System.NotImplementedException();
        }

        public int BoostUpArray(IAbstractOneDimensionalArrayObject array, int booster)
        {
            throw new System.NotImplementedException();
        }

        public int BoostDownArray(IAbstractOneDimensionalArrayObject array, int booster)
        {
            throw new System.NotImplementedException();
        }

        public IAbstractOneDimensionalArrayObject GetArraysSum(IAbstractOneDimensionalArrayObject arrayOne,
            IAbstractOneDimensionalArrayObject arrayTwo)
        {
            throw new System.NotImplementedException();
        }

        public IAbstractOneDimensionalArrayObject GetArraysProduct(IAbstractOneDimensionalArrayObject arrayOne,
            IAbstractOneDimensionalArrayObject arrayTwo)
        {
            throw new System.NotImplementedException();
        }

        public IAbstractOneDimensionalArrayObject GetArraysDifference(IAbstractOneDimensionalArrayObject arrayOne,
            IAbstractOneDimensionalArrayObject arrayTwo)
        {
            throw new System.NotImplementedException();
        }

        public IAbstractOneDimensionalArrayObject GetArraysDivision(IAbstractOneDimensionalArrayObject arrayOne,
            IAbstractOneDimensionalArrayObject arrayTwo)
        {
            throw new System.NotImplementedException();
        }

        public bool AreArraysEqual(IAbstractOneDimensionalArrayObject arrayOne, IAbstractOneDimensionalArrayObject arrayTwo)
        {
            throw new System.NotImplementedException();
        }

        public void SortArray(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }
    }
}