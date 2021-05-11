namespace BaseClasses
{
    public class Point3D : Point
    {
        public int Z { get; }

        public Point3D(int x, int y, int z) : base(x, y) => Z = Z;
    }
}