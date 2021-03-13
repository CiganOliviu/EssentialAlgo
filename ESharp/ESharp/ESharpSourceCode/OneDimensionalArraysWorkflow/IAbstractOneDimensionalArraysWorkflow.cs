namespace ESharp.ESharpSourceCode.OneDimensionalArraysWorkflow
{
    public interface IAbstractOneDimensionalArraysWorkflow
    {
        T GetMinimumValueFromArray<T>(T[] array);
        T GetMaximumValueFromArray<T>(T[] array);
        T GetArrayElementsSum<T>(T[] array);
        T GetArrayElementsProduct<T>(T[] array);
        T GetArrayElementsDifference<T>(T[] array);
        T GetArrayElementsDivision<T>(T[] array);
        T GetArrayElementsMean<T>(T[] array);
        bool IsArraySymmetric<T>(T[] array);
        T AddValueInArray<T>(T[] array);
        bool IsValueInArray<T>(T[] array, T value);
        int[] ConvertNumberToArray(int number);
        int ConvertArrayToNumber(int[] array);
        T BoostUpArray<T>(T[] array, T booster);
        T BoostDownArray<T>(T[] array, T booster);
        T[] GetArraysSum<T>(T[] arrayOne, T[] arrayTwo);
        T[] GetArraysProduct<T>(T[] arrayOne, T[] arrayTwo);
        T[] GetArraysDifference<T>(T[] arrayOne, T[] arrayTwo);
        T[] GetArraysDivision<T>(T[] arrayOne, T[] arrayTwo);
        bool AreArraysEqual<T>(T[] arrayOne, T[] arrayTwo);
    }
}