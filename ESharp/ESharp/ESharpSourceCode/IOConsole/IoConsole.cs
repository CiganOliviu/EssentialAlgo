using ESharp.DataStructures.Matrix;
using ESharp.DataStructures.OneDimensionalArray;

namespace ESharp.ESharpSourceCode.IOConsole
{
    public class IoConsole : IAbstractIoConsole
    {
        public IAbstractOneDimensionalArrayObject ReadOneDimensionalArray(int size)
        {
            throw new System.NotImplementedException();
        }

        public void OutputOneDimensionalArray(IAbstractOneDimensionalArrayObject array)
        {
            throw new System.NotImplementedException();
        }

        public IAbstractMatrix ReadMatrix(int lines, int columns)
        {
            throw new System.NotImplementedException();
        }

        public void OutputMatrix(IAbstractMatrix matrix)
        {
            throw new System.NotImplementedException();
        }
    }
}