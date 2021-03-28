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
* Get the gaussian sum.

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
* Get Factorial value. 

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
* Get Factorial value but recursively. 

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
* Get Fibonacci number but recursively. 

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
* Get Fibonacci number. 

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
* Get the Manna Pnueli number. 

Function Description through tests

```
    Assert.IsTrue(_fundamentalAlgorithms.GetMannaPnueliNumber(8) == 11);
    Assert.IsTrue(_fundamentalAlgorithms.GetMannaPnueliNumber(15) == 14);
```

### Get Ackerman Number
```
    int GetAckermanNumber(int inferiorLimit, int superiorLimit);
```
* Get the Ackerman Number

Function Description through tests

```
    Assert.IsTrue(_fundamentalAlgorithms.GetAckermanNumber(1, 2) == 4);
```

### Get Euler Number
```
    int GetEulerNumber(int inferiorLimit, int superiorLimit);
```
* Get the Euler Number

Function Description through tests

```
    Assert.IsTrue(_fundamentalAlgorithms.GetEulerNumber(3, 1) == 4);
```

### Get Catalan Number
```
    int GetCatalanNumber(int factor);
```
* Get the Catalan Number