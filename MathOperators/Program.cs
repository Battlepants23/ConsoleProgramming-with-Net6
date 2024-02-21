// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// Assignment Operator

int age = 10;

// Arithmatic Operator

int num1 = 4;
int num2 = 2;

Console.WriteLine($"Addition {num1 + num2}");
Console.WriteLine($"Subtraction {num1 - num2}");
Console.WriteLine($"Multiplication {num1 * num2}");
Console.WriteLine($"Division {num1 / num2}");
Console.WriteLine($"Remainder {num1 % num2}");

num1 = num1 + 4;

Console.WriteLine($"New num1 value {num1}");
Console.WriteLine($"Addition {num1 + num2}");
Console.WriteLine($"Subtraction {num1 - num2}");
Console.WriteLine($"Multiplication {num1 * num2}");
Console.WriteLine($"Division {num1 / num2}");
Console.WriteLine($"Remainder {num1 % num2}");

// Compound arithmatic Operator

num1 += 4;
Console.WriteLine(num1);
num1 -= 4;
Console.WriteLine(num1);
num1 *= 4;
Console.WriteLine(num1);
num1 /= 4;
Console.WriteLine(num1);
num1 %= 4;
Console.WriteLine(num1);