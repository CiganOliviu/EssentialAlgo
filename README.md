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
### Get Palindrome number
### Get Mean of two numbers
### Interchange Variables Values
### Get Digits Sum Of Number
### Get Digits Product of Number