using System;
using ESharp.DataStructures.Matrix;
using ESharp.DataStructures.OneDimensionalArray;

namespace ESharp.ESharpSourceCode.IOConsole
{
    public class IoConsole : IAbstractIoConsole
    {
        public IAbstractOneDimensionalArrayObject ReadOneDimensionalArray(int size)
        {
            var array = OneDimensionalArrayFactoryObject.GetOneDimensionalArrayObject();
            array.SetLengthOfOneDimensionalArray(size);

            for (var it = 0; it < size; it++)
                array.GetOneDimensionalArray()[it] = Convert.ToInt32(Console.ReadLine());

            return array;
        }

        public void OutputOneDimensionalArray(IAbstractOneDimensionalArrayObject array)
        {
            for (var it = 0; it < array.GetLengthOfOneDimensionalArray(); it++)
                Console.Write(array.GetOneDimensionalArray()[it] + " ");
        }

        public IAbstractMatrix ReadMatrix(int lines, int columns)
        {
            throw new NotImplementedException();
        }

        public void OutputMatrix(IAbstractMatrix matrix)
        {
            throw new NotImplementedException();
        }
    }
}