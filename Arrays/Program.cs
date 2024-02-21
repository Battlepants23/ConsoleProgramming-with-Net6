// See https://aka.ms/new-console-template for more information
// Declare fixed size array
using System.Linq.Expressions;

int[] grades = new int[5];
//  5 space addresses - 0 1 2 3 4
// if n is the size of the array , then array has addresses 0 to n-1

// Adding values to fixed size array
/*grades[0] = 23;
grades[1] = 34;
grades[2] = 54;
grades[3] = 65;
grades[4] = 76;*/

try
{
    int[] gradesA = new int[5];

    gradesA[0] = 23;
    gradesA[1] = 34;
    gradesA[2] = 54;
    gradesA[3] = 65;
    gradesA[4] = 76;
    gradesA[5] = 70;

}
catch (IndexOutOfRangeException ex)
{
   Console.WriteLine(ex.Message);
}


// or

//int[] items= new int[] { 23, 34, 54 ,87, 89 };

// program to accept array values from users

Console.WriteLine("");

Console.WriteLine("Enter your grades: ");

for (int i = 0; i < grades.Length; i++)
{
    Console.Write("enter your grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(" ");
// print the values of entered grades

Console.WriteLine("Your grades are: ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}





