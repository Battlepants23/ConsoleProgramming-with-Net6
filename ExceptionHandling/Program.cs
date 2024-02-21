// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

/*  try -  a try block attempts an operation
 *  catch - catch any fatel error or exception 
 *  finally - whether the try or the catch was successful, do this
 *  throw - end the program execution with the error 
 */

Console.WriteLine("Enter 1st number ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number ");
int number2 = Convert.ToInt32(Console.ReadLine());



try
{
    int quotient = number1 / number2;

    Console.WriteLine("the quotient is " + quotient);
}

catch (DivideByZeroException ex)
{
    Console.WriteLine("fatel error " + ex.Message);
}
catch (Exception ex) // this exception message will include every kind of error detail which is generally not at all required to display to te user or else he may get confure 
{
    Console.WriteLine(ex.Message);

    throw;
   
}
finally 
{
    Console.WriteLine("Operation ends here");
}