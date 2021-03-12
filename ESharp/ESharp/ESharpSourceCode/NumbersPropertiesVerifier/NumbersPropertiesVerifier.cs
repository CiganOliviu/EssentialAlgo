using System;

namespace ESharp.ESharpSourceCode.NumbersPropertiesVerifier
{
    public class NumbersPropertiesVerifier: IAbstractNumbersPropertiesVerifier
    {
        public bool IsPrime(int number)
        {
            if (number == 2) return true;

            for (var divisor = 2; divisor <= number / 2; divisor++)
                if (number % divisor == 0)
                    return false;

            return true;
        }

        public bool IsOdd(int number)
        {
            return number % 2 == 1;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        private int ReverseNumber(int number)
        {
            var result = 0;

            while (number != 0)
            {
                var digit = number % 10;
                result = ( result * 10 ) + digit; 
                number /= 10;
            }

            return result;
        }
        
        public bool IsPalindrome(int number)
        {
            return ReverseNumber(number) == number;
        }

        public bool IsPerfectSquare(int number)
        {
            return Math.Sqrt(number) % 1 == 0;
        }

        public bool IsFibonacci(int number)
        {
            throw new System.NotImplementedException();
        }

        public bool ISFactorial(int number)
        {
            throw new System.NotImplementedException();
        }
    }
}