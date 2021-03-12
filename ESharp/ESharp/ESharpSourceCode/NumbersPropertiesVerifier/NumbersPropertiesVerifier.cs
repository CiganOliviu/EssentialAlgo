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
            throw new System.NotImplementedException();
        }

        public bool IsEven(int number)
        {
            throw new System.NotImplementedException();
        }

        public bool IsPalindrome(int number)
        {
            throw new System.NotImplementedException();
        }

        public bool IsPerfectSquare(int number)
        {
            throw new System.NotImplementedException();
        }

        public bool IsFibonacci(int number)
        {
            throw new System.NotImplementedException();
        }

        public bool IsFactorialResult(int number)
        {
            throw new System.NotImplementedException();
        }
    }
}