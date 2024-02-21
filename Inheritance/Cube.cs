
using System.Drawing;

class Cube : Shape
{
    public double CommonLength { get; set; }


    public Cube()
    {

    }


    public double GetArea()
    {

        return Length * Length;

    }

}
