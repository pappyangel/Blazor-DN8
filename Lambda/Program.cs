// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Lambda Expressions
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var oddNumbers = numbers.Where(x => x % 2 != 0);
var sumOfEven = numbers.Where(x => x % 2 == 0).Sum();
var message = $"The odd numbers are {oddNumbers.Count()} and the sum of the even numbers are {sumOfEven}";
Console.WriteLine(message);

//Delegates
var num = 64;
Func<int, double> squareRoot = x => Math.Sqrt(x);
Console.WriteLine($"Square Root of {num} is {squareRoot(num)}");
//Square Root of 64 is 8

num = 144;
Console.WriteLine($"Square Root of {num} is {squareRoot(num)}");
//Square Root of 144 is 12


List<string> names = new List<string>();

Action<string> sayHi = name =>
{
    Console.WriteLine($"Hi {name}!");
    names.Add(name);
};

sayHi("Nicky");
sayHi("Ravi");
sayHi("Danielle");
