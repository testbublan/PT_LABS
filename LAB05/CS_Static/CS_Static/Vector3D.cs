namespace CS_Static
{
    public class Vector3D
    {
        private double x;
        private double y;
        private double z;

        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        public double Z
        {
            get => z;
            set => z = value;
        }

        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
            => new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
            => new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);

        // Скалярное произведение (dot product) -> число
        public static double operator *(Vector3D v1, Vector3D v2)
            => v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;

        public override string ToString()
            => $"Vector ({X}, {Y}, {Z})";

        public override bool Equals(object? obj)
        {
            if (obj is not Vector3D other) return false;
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        public override int GetHashCode()
            => HashCode.Combine(X, Y, Z);
    }
}