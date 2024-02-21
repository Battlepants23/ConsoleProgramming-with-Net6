// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

string firstname = "Amir";
string lastname = "Khan";

DateTime date = DateTime.Now;

// Print to screen
Console.WriteLine(lastname);
Console.WriteLine("Hellow world");

// Concatenation
Console.WriteLine(firstname + " " + lastname);
Console.WriteLine("My full name is " + firstname + " " + lastname);
Console.WriteLine($"My full name is {firstname}, {lastname}");
Console.WriteLine("My full name is {0}, {1}", firstname, lastname);

// String length
int length = lastname.Length;
Console.WriteLine($"Your name is {length} characters long");

// Replace String parts
string newName = firstname.Replace('A', 'N');
Console.WriteLine($"Your new name is {newName}");
string newName1 = newName.Replace('i', ' ');
Console.WriteLine($"Your new name is {newName1}");

// Append string
string fullname = firstname + " " + lastname;
Console.WriteLine($"Your full name is {fullname}");

// Split string
string test = "avabvabcvabcdvabcdevabcdvabcvabva";
string[] result = test.Split( 'v' );
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

// Compare string

string nullString = null;
string emptyString = string.Empty;
string whiteSpaceString = " ";


if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("string is null");
}

if (firstname == lastname) // if (firstname != lastname)
{
    Console.WriteLine("first and last names are same");
}
else
{
    Console.WriteLine("first and last names are not same");
}

int compareResult = string.Compare(firstname, lastname);

if (compareResult == 0)
{
    Console.WriteLine("Two names are same ");
}
else
{
    Console.WriteLine("Two names are different");
}


// convert to string

//string convertedString = null;
int number = 12345;

string convertedString = number.ToString();
Console.WriteLine($"The original converted string is { convertedString}");
convertedString = 67890.ToString();
Console.WriteLine($"The later converted string is {convertedString}");