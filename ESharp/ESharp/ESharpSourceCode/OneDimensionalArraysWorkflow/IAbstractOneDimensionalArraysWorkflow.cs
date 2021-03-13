using ESharp.DataStructures.OneDimensionalArray;

namespace ESharp.ESharpSourceCode.OneDimensionalArraysWorkflow
{
    public interface IAbstractOneDimensionalArraysWorkflow
    {
        int GetMinimumValueFromArray(IAbstractOneDimensionalArrayObject array);
        int GetMaximumValueFromArray(IAbstractOneDimensionalArrayObject array);
        int GetArrayElementsSum(IAbstractOneDimensionalArrayObject array);
        int GetArrayElementsProduct(IAbstractOneDimensionalArrayObject array);
        int GetArrayElementsDifference(IAbstractOneDimensionalArrayObject array);
        int GetArrayElementsDivision(IAbstractOneDimensionalArrayObject array);
        int GetArrayElementsMean(IAbstractOneDimensionalArrayObject array);
        bool IsArraySymmetric(IAbstractOneDimensionalArrayObject array);
        int AddValueInArray(IAbstractOneDimensionalArrayObject array);
        bool IsValueInArray(IAbstractOneDimensionalArrayObject array, int value);
        int[] ConvertNumberToArray(int number);
        int ConvertArrayToNumber(int[] array);
        int BoostUpArray(IAbstractOneDimensionalArrayObject array, int booster);
        int BoostDownArray(IAbstractOneDimensionalArrayObject array, int booster);
        IAbstractOneDimensionalArrayObject GetArraysSum(IAbstractOneDimensionalArrayObject arrayOne,
                                                        IAbstractOneDimensionalArrayObject arrayTwo);
        IAbstractOneDimensionalArrayObject GetArraysProduct(IAbstractOneDimensionalArrayObject arrayOne,
                                                            IAbstractOneDimensionalArrayObject arrayTwo);
        IAbstractOneDimensionalArrayObject GetArraysDifference(IAbstractOneDimensionalArrayObject arrayOne, 
                                                                IAbstractOneDimensionalArrayObject arrayTwo);
        IAbstractOneDimensionalArrayObject GetArraysDivision(IAbstractOneDimensionalArrayObject arrayOne,
                                                            IAbstractOneDimensionalArrayObject arrayTwo);
        bool AreArraysEqual(IAbstractOneDimensionalArrayObject arrayOne, IAbstractOneDimensionalArrayObject arrayTwo);
        void SortArray(IAbstractOneDimensionalArrayObject array);
    }
}