# Fibonacci Sequence
Program that gets sequence of Fibonacci from specified start and specified count

#### Usage
##### Run from terminal/bash
  1. Go to project directory
  2. Open terminal/bash in that directory
  3. type
        * dotnet run <start index> <count> (this will print first <count> numbers of Fibonacci sequence started from <start index>)
        * dotnet run <count> (this will print first <count> numbers of Fibonacci sequence)
        * dotnet run (this will print first 100 elements of Fibonacci sequence)

##### Run from code
Function signature is
~~~csharp
public static IEnumerable<BigInteger> FibonacciSequence();
~~~

#### Examples
~~~csharp
var fibs = FibonacciSequence();
foreach(var num in fibs.Skip(10).Take(20))
{
    Console.WriteLine(num);
}
~~~
~~~csharp
var fibs = FibonacciSequence();
BigInteger sum = fibs.Take(n).Aggregate((sum,num) => sum+=num);
~~~