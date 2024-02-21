// See https://aka.ms/new-console-template for more information

/*// For loop
for (int i = 0; i < 10; i++) 
{
    Console.WriteLine($"I am in loop {i}");
    //Console.WriteLine("I am in loop " +i);
}
Console.WriteLine("Loop ends");

// While loop (Condition controlled)

int n = 0;
while (n < 5)
{
    Console.WriteLine("Enter value of n");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {n}");
}

Console.WriteLine("While Loop ends");*/


// Do while loop

int m = 0;
do
{ 
    Console.WriteLine("still in loop");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("condition not met, enter another number");
}
while (m < 5);
Console.WriteLine("Do while loop ends");

