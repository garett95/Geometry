using System;

namespace Geometry
{
    class Triangle : IFigure
    {
        public Triangle(
            double a,
            double b,
            double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; } 
        public double B { get; }
        public double C { get; }


        public double GetSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangularTriangle()
        {
            if (A > B && A > C)
                return A * A == B * B + C * C;
            else if (B > A && B > C)
                return B * B == A * A + C * C;
            else return C * C == A * A + B * B;
        }

        public bool IsTriangle()
        {
            if(A > 0 && B> 0 && C > 0)
            {
                if (A + B <= C || A + C <= B || B + C <= A)
                    return false;
                else
                    return true;
            }
            else
            {
                throw new ArgumentException("Side of a triangle must be greater than 0.");
            }
        }
    }
}
