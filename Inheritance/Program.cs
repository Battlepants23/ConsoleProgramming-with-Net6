


Console.WriteLine("Enter value for length: ");
int lenght = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter value for width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter value for height: ");
int height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter value for altitude: ");
int altitude = Convert.ToInt32(Console.ReadLine());

var cube = new Cube() { Height = height, Length = lenght };

var cube1 = new Cube();

var cuboid = new Cuboid(lenght, width, height);
var triangle = new Triangle(altitude);

//cube.Length = lenght;
//cube.Height = height;

//cuboid.Width = width;
//cuboid.Height= height;
//cuboid.Length = lenght;

triangle.Length = lenght;
triangle.Altitude = altitude;

Console.WriteLine("Area of cube is: " + cube.GetArea());
Console.WriteLine("Area of cube1 is: " + cube1.GetArea());
Console.WriteLine("Area of cuboid is: " + cuboid.GetArea());
Console.WriteLine("Volume of cuboid is: " + cuboid.GetVolume());
Console.WriteLine("Area of triangle is: " + triangle.GetArea());







