using System;

namespace _3DVector
{
    class Vector
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public Vector() : this(0, 0, 0) { }

        public override string ToString()
        {
            return "(" + this.X.ToString()
                + ", " + this.Y.ToString()
                + ", " + this.Z.ToString() + ")";
        }

        public double Abs()
        {
            return Math.Sqrt(
                this.X * this.X + this.Y * this.Y + this.Z * this.Z);
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y, -v.Z);
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector();
            Console.WriteLine("v1 = " + v1.ToString());

            Vector v2 = new Vector(1, -2, 2);
            Console.Write("v2 = " + v2.ToString() + " |v2| = ");
            Console.WriteLine(v2.Abs());

            Vector v3 = -v2;
            Console.Write("v3 = " + v3.ToString() +
                "   v2 + v3 = " + (v2 + v3).ToString() +
                " v2 - v3 = " + (v2 - v3).ToString());
        }
    }
}
