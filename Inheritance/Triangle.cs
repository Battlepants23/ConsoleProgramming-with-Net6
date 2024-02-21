
class Triangle : Shape, IShape
{

    public double Altitude { get; set; }

    public Triangle( int altitude)
    {
       
    }


    public double GetArea()
    {


        return 0.5 * Length * Altitude;

    }
}
