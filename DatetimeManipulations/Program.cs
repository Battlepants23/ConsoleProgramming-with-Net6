// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

// Empty Date Time
DateTime testdatetime = new DateTime();

// Create a date time from date and time 
DateTime dateOfBirth = new DateTime(1989, 11, 23);
Console.WriteLine("My date of Birth is : " + dateOfBirth);

// Create a Date timje from current time stamps 
DateTime currentDate = DateTime.Now;                   
Console.WriteLine("The current time is " + currentDate);

// Create a date time from the string 
DateTime datefromString =  DateTime.Parse("11/23/1989", CultureInfo.InvariantCulture);
Console.WriteLine("The date from string is " + datefromString);

// Add additional time 
Console.WriteLine("One hour from now is " + currentDate.AddHours(1));
Console.WriteLine("One day  from now is " + currentDate.AddDays(1));

// Ticks from date time
Console.WriteLine("This is a numeral " + currentDate.Ticks);

// Date Only


// Time Only



