// See https://aka.ms/new-console-template for more information

//Declare the list
List<String> names = new List<string>();
string name = string.Empty;

// Add values to list
//names.Add("Amir");

Console.WriteLine("write names: ");

// while (name != "-1")
while (!name.Equals("-1"))
{
    Console.Write("enter the name: ");
    name = Console.ReadLine();

    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.WriteLine($"{name} was added successfully ");
    }
}

//foreach (string st in names) { } 

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

foreach (string item in names)
{
    Console.WriteLine(item);
}

