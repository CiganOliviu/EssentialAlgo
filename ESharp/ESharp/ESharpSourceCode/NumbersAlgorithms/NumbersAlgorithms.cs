using System;

namespace ESharp.ESharpSourceCode.NumbersAlgorithms
{
    public class NumbersAlgorithms : IAbstractNumbersAlgorithms
    {
        public int GetTheLargestCommonDivisor(int inferiorLimit, int superiorLimit)
        {
            if (superiorLimit == 0)
                return 0;

            var rest = inferiorLimit % superiorLimit;

            while (rest != 0)
            {
                inferiorLimit = superiorLimit;
                superiorLimit = rest;
                rest = inferiorLimit % superiorLimit;
            }

            return superiorLimit;
        }

        public int GetTheLargestCommonDivisorRecursive(int inferiorLimit, int superiorLimit)
        {
            throw new System.NotImplementedException();
        }

        public int GetTheLeastCommonMultiple(int inferiorLimit, int superiorLimit)
        {
            throw new System.NotImplementedException();
        }

        public int GetPrimeValue(int factor)
        {
            throw new System.NotImplementedException();
        }

        public int ReverseNumber(int number)
        {
            throw new System.NotImplementedException();
        }

        public int GetPalindromeNumber(int factor)
        {
            throw new System.NotImplementedException();
        }

        public float GetMeanOfTwoNumbers<T>(T firstNumber, T secondNumber)
        {
            throw new System.NotImplementedException();
        }

        public void InterchangeVariablesValues<T>(ref T firstVariable, ref T secondVariable)
        {
            throw new System.NotImplementedException();
        }

        public int GetDigitsSumOfNumber(int number)
        {
            throw new System.NotImplementedException();
        }

        public int GetDigitsProductOfNumber(int number)
        {
            throw new System.NotImplementedException();
        }
    }
}