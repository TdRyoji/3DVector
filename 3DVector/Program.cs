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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector();
            Console.WriteLine("v1 = " + v1.ToString());
        }
    }
}
