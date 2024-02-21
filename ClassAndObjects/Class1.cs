using System.Runtime.CompilerServices;

Person person= new ();

Console.WriteLine ("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter MiddleName: ");
string MiddleName = Console.ReadLine ();

Console.WriteLine("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Type in your salary: ");
double LocalSalary = Convert.ToDouble(Console.ReadLine());
person.setSalary(LocalSalary);

if (string.IsNullOrEmpty(MiddleName))
{
    Console.WriteLine("your name is: " + person.FullName());
}
else
{

    Console.WriteLine("your name is: " + person.FullName(MiddleName));
}

Console.WriteLine("your age is: " + person.Age);

Console.WriteLine("your Year of Birth is: " + DateUtil.YearofBirth(person.Age));

Console.WriteLine("your salary is: " + person.getSalary());






