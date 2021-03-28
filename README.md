# EssentialAlgo

EssentialAlgo is a library which consists in a suite of popular algorithms
used most of the time. IT is mainly constructed around the idea of 
getting all the necessary data structures and algorithms together.

## FundamentalAlgorithms

```
namespace ESharp.ESharpSourceCode.FundamentalAlgorithms
{
    public interface IAbstractFundamentalAlgorithms
    {
        int GetGaussSum(int factor);
        int GetFactorialNumber(int factor);
        int GetFactorialNumberRecursive(int factor);
        int GetFibonacciNumberRecursive(int factor);
        int GetFibonacciNumber(int factor);
        int GetMannaPnueliNumber(int factor);
        int GetAckermanNumber(int inferiorLimit, int superiorLimit);
        int GetEulerNumber(int inferiorLimit, int superiorLimit);
        int GetCatalanNumber(int factor);
    }
}
```

### Get Gauss Sum

Method Definition
```
int GetGaussSum(int factor);
```

Function Description through tests

```
Assert.IsTrue(_fundamentalAlgorithms.GetGaussSum(6) == 21);
Assert.IsTrue(_fundamentalAlgorithms.GetGaussSum(5) == 15);
Assert.IsTrue(_fundamentalAlgorithms.GetGaussSum(1) == 1);
```

### Get Factorial Number

Method Definition
```
int GetFactorialNumber(int factor);
```

Function Description through tests

```
Assert.IsTrue(_fundamentalAlgorithms.GetFactorialNumber(5) == 120);
Assert.IsTrue(_fundamentalAlgorithms.GetFactorialNumber(7) == 5040);
Assert.IsTrue(_fundamentalAlgorithms.GetFactorialNumber(0) == 1);
```

### Get Factorial Number Recursive

Method Definition
```
int GetFactorialNumberRecursive(int factor);
```

Function Description through tests

```
Assert.IsTrue(_fundamentalAlgorithms.GetFactorialNumberRecursive(5) == 120);
Assert.IsTrue(_fundamentalAlgorithms.GetFactorialNumberRecursive(7) == 5040);
Assert.IsTrue(_fundamentalAlgorithms.GetFactorialNumberRecursive(0) == 1);
```

### Get Fibonacci Number Recursive

Method Definition
```
int GetFibonacciNumberRecursive(int factor);
```

Function Description through tests

```
Assert.IsTrue(_fundamentalAlgorithms.GetFibonacciNumberRecursive(10) == 55);
Assert.IsTrue(_fundamentalAlgorithms.GetFibonacciNumberRecursive(14) == 377);
Assert.IsTrue(_fundamentalAlgorithms.GetFibonacciNumberRecursive(1) == 1);
```

### Get Fibonacci Number

Method Definition
```
int GetFibonacciNumber(int factor);
```

Function Description through tests

```
Assert.IsTrue(_fundamentalAlgorithms.GetFibonacciNumber(10) == 55);
Assert.IsTrue(_fundamentalAlgorithms.GetFibonacciNumber(14) == 377);
Assert.IsTrue(_fundamentalAlgorithms.GetFibonacciNumber(1) == 1);
```

### Get Manna Pnueli Number

Method Definition
```
int GetMannaPnueliNumber(int factor);
```

Function Description through tests

```
Assert.IsTrue(_fundamentalAlgorithms.GetMannaPnueliNumber(8) == 11);
Assert.IsTrue(_fundamentalAlgorithms.GetMannaPnueliNumber(15) == 14);
```

### Get Ackerman Number
```
int GetAckermanNumber(int inferiorLimit, int superiorLimit);
```

Function Description through tests

```
Assert.IsTrue(_fundamentalAlgorithms.GetAckermanNumber(1, 2) == 4);
```

### Get Euler Number
```
int GetEulerNumber(int inferiorLimit, int superiorLimit);
```

Function Description through tests

```
Assert.IsTrue(_fundamentalAlgorithms.GetEulerNumber(3, 1) == 4);
```

### Get Catalan Number
```
int GetCatalanNumber(int factor);
```

Function Description through tests

```
Assert.IsTrue(_fundamentalAlgorithms.GetCatalanNumber(3) == 5);
```

## NumbersAlgorithms

```
namespace ESharp.ESharpSourceCode.NumbersAlgorithms
{
    public interface IAbstractNumbersAlgorithms
    {
        int GetTheLargestCommonDivisor(int inferiorLimit, int superiorLimit);
        int GetTheLargestCommonDivisorRecursive(int inferiorLimit, int superiorLimit);
        int GetTheLeastCommonMultiple(int inferiorLimit, int superiorLimit);
        int GetValueIfPrime(int factor);
        int ReverseNumber(int number);
        int GetPalindromeNumber(int factor);
        float GetMeanOfTwoNumbers<T>(T firstNumber, T secondNumber);
        void InterchangeVariablesValues<T>(ref T firstVariable, ref T secondVariable);
        int GetDigitsSumOfNumber(int number);
        int GetDigitsProductOfNumber(int number);
    }
}
```

### Get the largest common divisor
```
int GetTheLargestCommonDivisor(int inferiorLimit, int superiorLimit);
```

Function Description through tests

```
Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisor(8, 12) == 4);
Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisor(1, 2) == 1);
Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisor(36, 69) == 3);
Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisor(100, 50) == 50);
```

### Get the largest common divisor recursively
```
int GetTheLargestCommonDivisorRecursive(int inferiorLimit, int superiorLimit);
```

Function Description through tests

```
Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisorRecursive(8, 12) == 4);
Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisorRecursive(1, 2) == 1);
Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisorRecursive(36, 69) == 3);
Assert.IsTrue(_numbersAlgorithms.GetTheLargestCommonDivisorRecursive(100, 50) == 50);
```

### Get the least common multiple
```
int GetTheLeastCommonMultiple(int inferiorLimit, int superiorLimit);
```

Function Description through tests

```
Assert.IsTrue(_numbersAlgorithms.GetTheLeastCommonMultiple(8, 12) == 24);
Assert.IsTrue(_numbersAlgorithms.GetTheLeastCommonMultiple(1, 2) == 2);
Assert.IsTrue(_numbersAlgorithms.GetTheLeastCommonMultiple(200, 324) == 16200);
Assert.IsTrue(_numbersAlgorithms.GetTheLeastCommonMultiple(100, 50) == 100);
```

### Get value if prime
```
int GetValueIfPrime(int factor);
```

Function Description through tests

```
Assert.IsTrue(_numbersAlgorithms.GetValueIfPrime(12) == 0);
Assert.IsTrue(_numbersAlgorithms.GetValueIfPrime(25) == 0);
Assert.IsTrue(_numbersAlgorithms.GetValueIfPrime(13) == 13);
Assert.IsTrue(_numbersAlgorithms.GetValueIfPrime(23) == 23);  
```

### Reverse number
```
int ReverseNumber(int number);
```

Function Description through tests

```
Assert.IsTrue(_numbersAlgorithms.ReverseNumber(12) == 21);
Assert.IsTrue(_numbersAlgorithms.ReverseNumber(25) == 52);
Assert.IsTrue(_numbersAlgorithms.ReverseNumber(1369895) == 5989631);
Assert.IsTrue(_numbersAlgorithms.ReverseNumber(333) == 333);
```

### Get Palindrome number
```
int GetPalindromeNumber(int factor);
```

Function Description through tests

```
Assert.IsTrue(_numbersAlgorithms.GetPalindromeNumber(121) == 121);
Assert.IsTrue(_numbersAlgorithms.GetPalindromeNumber(25) == 0);
Assert.IsTrue(_numbersAlgorithms.GetPalindromeNumber(1369895) == 0);
Assert.IsTrue(_numbersAlgorithms.GetPalindromeNumber(333) == 333);
```

### Get Mean of two numbers
```
float GetMeanOfTwoNumbers<T>(T firstNumber, T secondNumber);
```

Function Description through tests

```
Assert.IsTrue(Math.Abs(_numbersAlgorithms.GetMeanOfTwoNumbers(121, 122) - 121.5) < 3);
Assert.IsTrue(Math.Abs(_numbersAlgorithms.GetMeanOfTwoNumbers(123, 432) - 277.5) < 3);
Assert.IsTrue(Math.Abs(_numbersAlgorithms.GetMeanOfTwoNumbers(213123, 1369895) - 791509) < 3);
Assert.IsTrue(Math.Abs(_numbersAlgorithms.GetMeanOfTwoNumbers(333, 2) - 167.5) < 3);
```

### Interchange Variables Values
```
void InterchangeVariablesValues<T>(ref T firstVariable, ref T secondVariable);
```

Function Description through tests

```
var firstVariable = 12;
var secondVariable = 13;

_numbersAlgorithms.InterchangeVariablesValues(ref firstVariable, ref secondVariable);
Assert.IsTrue(firstVariable == 13 && secondVariable == 12);

_numbersAlgorithms.InterchangeVariablesValues(ref firstVariable, ref secondVariable);
Assert.IsTrue(firstVariable == 12 && secondVariable == 13);

var firstDoubleVariable = 123.32;
var secondDoubleVariable = 345.32;

_numbersAlgorithms.InterchangeVariablesValues(ref firstDoubleVariable, ref secondDoubleVariable);
Assert.IsTrue(Math.Abs(firstDoubleVariable - 345.32) < 2 && Math.Abs(secondDoubleVariable - 123.32) < 2);

_numbersAlgorithms.InterchangeVariablesValues(ref firstDoubleVariable, ref secondDoubleVariable);
Assert.IsTrue(Math.Abs(firstDoubleVariable - 123.32) < 2 && Math.Abs(secondDoubleVariable - 345.32) < 2);
```

### Get Digits Sum Of Number
```
int GetDigitsSumOfNumber(int number);
```

Function Description through tests

```
Assert.IsTrue(_numbersAlgorithms.GetDigitsSumOfNumber(121) == 4);
Assert.IsTrue(_numbersAlgorithms.GetDigitsSumOfNumber(25) == 7);
Assert.IsTrue(_numbersAlgorithms.GetDigitsSumOfNumber(1369895) == 41);
Assert.IsTrue(_numbersAlgorithms.GetDigitsSumOfNumber(333) == 9);
```

### Get Digits Product of Number
```
int GetDigitsProductOfNumber(int number);
```

Function Description through tests

```
Assert.IsTrue(_numbersAlgorithms.GetDigitsProductOfNumber(121) == 2);
Assert.IsTrue(_numbersAlgorithms.GetDigitsProductOfNumber(25) == 10);
Assert.IsTrue(_numbersAlgorithms.GetDigitsProductOfNumber(1369895) == 58320);
Assert.IsTrue(_numbersAlgorithms.GetDigitsProductOfNumber(333) == 27);
```

## Numbers Properties Verifier

```
namespace ESharp.ESharpSourceCode.NumbersPropertiesVerifier
{
    public interface IAbstractNumbersPropertiesVerifier
    {
        bool IsPrime(int number);
        bool IsOdd(int number);
        bool IsEven(int number);
        bool IsPalindrome(int number);
        bool IsPerfectSquare(int number);
        bool IsFibonacci(int number);
        bool IsFactorial(int number);
    }
}
```

### Is Prime
```
bool IsPrime(int number);
```

Function Description through tests

```
Assert.IsTrue(_numbersPropertiesVerifier.IsPrime(13));
Assert.IsFalse(_numbersPropertiesVerifier.IsPrime(16));
Assert.IsTrue(_numbersPropertiesVerifier.IsPrime(31));
Assert.IsFalse(_numbersPropertiesVerifier.IsPrime(6));
Assert.IsFalse(_numbersPropertiesVerifier.IsPrime(21));
```

### Is Odd
```
bool IsOdd(int number);
```

Function Description through tests

```
Assert.IsTrue(_numbersPropertiesVerifier.IsOdd(13));
Assert.IsTrue(_numbersPropertiesVerifier.IsOdd(17));
Assert.IsFalse(_numbersPropertiesVerifier.IsOdd(22));
Assert.IsFalse(_numbersPropertiesVerifier.IsOdd(2));
Assert.IsTrue(_numbersPropertiesVerifier.IsOdd(3));
```

### Is Even
```
bool IsEven(int number);
```

Function Description through tests

```
Assert.IsTrue(_numbersPropertiesVerifier.IsEven(13));
Assert.IsTrue(_numbersPropertiesVerifier.IsEven(17));
Assert.IsFalse(_numbersPropertiesVerifier.IsEven(22));
Assert.IsFalse(_numbersPropertiesVerifier.IsEven(2));
Assert.IsTrue(_numbersPropertiesVerifier.IsEven(3));
```

### Is Palindrome
```
bool IsPalindrome(int number);
```

Function Description through tests

```
Assert.IsTrue(_numbersPropertiesVerifier.IsPalindrome(131));
Assert.IsFalse(_numbersPropertiesVerifier.IsPalindrome(123));
Assert.IsFalse(_numbersPropertiesVerifier.IsPalindrome(1234));
Assert.IsTrue(_numbersPropertiesVerifier.IsPalindrome(1));
Assert.IsTrue(_numbersPropertiesVerifier.IsPalindrome(99));
```

### Is Perfect Square
```
bool IsPerfectSquare(int number);
```

Function Description through tests

```
Assert.IsTrue(_numbersPropertiesVerifier.IsPerfectSquare(144));
Assert.IsFalse(_numbersPropertiesVerifier.IsPerfectSquare(123));
Assert.IsTrue(_numbersPropertiesVerifier.IsPerfectSquare(169));
Assert.IsTrue(_numbersPropertiesVerifier.IsPerfectSquare(4));
```

### Is Fibonacci
```
```

Function Description through tests

```
```

### Is Factorial
```
```

Function Description through tests

```
```