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

        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(v1.Y * v2.Z - v2.Y * v1.Z,
                v1.Z * v2.X - v2.Z * v1.X, v1.X * v2.Y - v2.X * v1.Y);
        }

        public static double InnerProduct(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public override bool Equals(object obj)
        {
            Vector v = obj as Vector;
            if (v == null) return false;

            return this.X == v.X && this.Y == v.Y && this.Z == v.Z;
        }

        public override int GetHashCode()
        {
            int x = this.X.GetHashCode();
            int y = this.Y.GetHashCode();
            int z = this.Z.GetHashCode();
            return (x + y + z) ^ (x - y + z) ^ (x - y - z);
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
            Console.WriteLine("v3 = " + v3.ToString() +
                "   v2 + v3 = " + (v2 + v3).ToString() +
                " v2 - v3 = " + (v2 - v3).ToString());

            Console.WriteLine("v1 = v2 + v3 : {0}", v1.Equals(v2 + v3));

            Vector v4 = new Vector(3, 1, -2);
            Console.WriteLine("v4 = " + v4.ToString());
            Console.WriteLine("v2・v4 = " + (Vector.InnerProduct(v2, v4))
                + " v2 * v4 = " + (v2 * v4).ToString());
        }
    }
}
