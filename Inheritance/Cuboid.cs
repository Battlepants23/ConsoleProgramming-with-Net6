
class Cuboid : Shape, IShape
{

    public double Width { get; set; }

    public Cuboid( int length, int width, int height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double GetArea()
    {

        return Height * Width;

    }

    public double GetVolume()
    {

        return Length * Height * Width;

    }

}
