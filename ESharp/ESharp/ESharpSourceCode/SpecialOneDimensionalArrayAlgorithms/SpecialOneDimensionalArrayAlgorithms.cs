using ESharp.DataStructures.OneDimensionalArray;

namespace ESharp.ESharpSourceCode.SpecialOneDimensionalArrayAlgorithms
{
    public class SpecialOneDimensionalArrayAlgorithms : IAbstractSpecialOneDimensionalArrayAlgorithms
    {
        private static void SwapElements(ref int firstParameter, ref int secondParameter)
        {
            firstParameter += secondParameter;
            secondParameter = firstParameter - secondParameter;
            firstParameter -= secondParameter;
        }
        
        public void BubbleSort(IAbstractOneDimensionalArrayObject array)
        {
            for (var it = 0; it < array.GetLengthOfOneDimensionalArray() - 1; it++)
                for (var jit = 0; jit < array.GetLengthOfOneDimensionalArray() - it - 1; jit++)
                    if (array.GetOneDimensionalArray()[jit] > array.GetOneDimensionalArray()[jit + 1])
                        SwapElements(ref array.GetOneDimensionalArray()[jit],
                            ref array.GetOneDimensionalArray()[jit + 1]);
        }

        public void MinimumValueSort(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public void InsertionSort(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public void SelectionSort(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public void ShellSort(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public bool LinearSearchValue(IAbstractOneDimensionalArrayObject array, int valueToSearch)
        {
            throw new System.NotImplementedException();
        }

        public bool BinarySearchValue(IAbstractOneDimensionalArrayObject array, int valueToSearch)
        {
            throw new System.NotImplementedException();
        }
    }
}