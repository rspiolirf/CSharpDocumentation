using System;

namespace BaseClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p3d = new Point3D(5, 3, 8);
            Console.WriteLine($"Point3D -> X: {p3d.X}, Y: {p3d.Y}, Z: {p3d.Z}");

            Point p3d2 = new Point3D(2, 4, 6);
            Console.WriteLine($"Point3D -> X: {p3d2.X}, Y: {p3d2.Y}");
        }
    }
}
