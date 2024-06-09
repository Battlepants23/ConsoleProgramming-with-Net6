// See https://aka.ms/new-console-template for more information

void PrintName() { Console.WriteLine("Amir"); }

//PrintName();

void Addition(int num1, int num2)
{
    Console.WriteLine($"Sum of the two numbers is {num1+num2}");
}

int LargestNumber(int num1, int num2, int num3, int num4)
{
    int largest = num1;
    if (num1 < num2) 
    {
        largest = num2;
    }
    if (num2 < num3)
    {
        largest = num3;
    }
    if (num3 < num4)
    {
        largest = num4;
    }
    return largest;
}


Console.WriteLine("Enter 1st number ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 3rd number ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 4th number ");
int number4 = Convert.ToInt32(Console.ReadLine());

// Addition(number1, number2);

int result =  LargestNumber(number1, number2, number3, number4);
Console.WriteLine($"The largest number is: {result}");

//Console.WriteLine("The largest number is: " + result);
