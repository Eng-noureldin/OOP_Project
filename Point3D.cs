public class Point3D : IComparable, ICloneable
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    // Constructor Chaining
    public Point3D() : this(0, 0, 0) { }
    public Point3D(int x) : this(x, 0, 0) { }
    public Point3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // Override ToString
    public override string ToString()
    {
        return $"Point Coordinates: ({X}, {Y}, {Z})";
    }

    // Override Equals (Best Practice when overloading ==)
    public override bool Equals(object? obj)
    {
        if (obj is Point3D p)
            return X == p.X && Y == p.Y && Z == p.Z;
        return false;
    }

    public override int GetHashCode() => HashCode.Combine(X, Y, Z);

    // Overloading == and !=
    public static bool operator ==(Point3D p1, Point3D p2)
    {
        if (ReferenceEquals(p1, null)) return ReferenceEquals(p2, null);
        return p1.Equals(p2);
    }
    public static bool operator !=(Point3D p1, Point3D p2) => !(p1 == p2);

    // IComparable for sorting (Sort by X, then Y)
    public int CompareTo(object? obj)
    {
        if (obj is Point3D p)
        {
            if (this.X == p.X) return this.Y.CompareTo(p.Y);
            return this.X.CompareTo(p.X);
        }
        return 1;
    }

    // ICloneable for cloning
    public object Clone()
    {
        return new Point3D(X, Y, Z);
    }
}