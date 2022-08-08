using System;

namespace Geometry
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius {get; }

        public void ValidateCircle()
        {
            if (Radius < 0)
            {
                throw new ArgumentException("Radius must be greather than 0.");
            }
        }

        public double GetSquare() => Math.PI * Math.Pow(Radius, 2);
    }
}
