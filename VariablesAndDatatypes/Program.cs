// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool working;

// prompt user for input
Console.WriteLine("Please enter your Name: ");
fullName= Console.ReadLine();

Console.WriteLine("Please enter your Age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your Salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter your Gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("You are working (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());


// print information
Console.WriteLine("your name is: " + fullName); // concatination
Console.WriteLine("your age is: {0}" , age);  // providing argument so that age is read at 0th position
Console.WriteLine($"your salary is: {salary}"); // interpolation
Console.WriteLine($"your gender is: {gender}"); // interpolation
Console.WriteLine($"your work status is: {working}"); // interpolation

