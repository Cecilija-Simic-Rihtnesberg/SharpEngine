using System;
using System.Numerics;

namespace SharpEngine {
    public struct Vector {
        public float x, y, z;

        public static Vector Forward => new Vector(0, 1);
        public static Vector Backward => new Vector(0, -1);
        public static Vector Left => new Vector(-1, 0);
        public static Vector Right => new Vector(1, 0);
        public static Vector Zero => new Vector(0, 0);
        public static double Down { get; set; }

        public Vector(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector(float x, float y) {
            this.x = x;
            this.y = y;
            this.z = 0;
        }

        public static Vector operator *(Vector v, float f) {
            return new Vector(v.x * f, v.y * f, v.z * f);
        }

        public static Vector operator /(Vector v, float f) {
            return new Vector(v.x / f, v.y / f, v.z / f);
        }
        
        public static Vector operator +(Vector lhs, Vector rhs) {
            return new Vector(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }
        
        public static Vector operator -(Vector lhs, Vector rhs) {
            return new Vector(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }
        
        public static Vector operator -(Vector v) {
            return new Vector(-v.x, -v.y, -v.z);
        }
        
        public static Vector Max(Vector a, Vector b) {
            return new Vector(MathF.Max(a.x, b.x), MathF.Max(a.y, b.y), MathF.Max(a.z, b.z));
        }
        public static Vector Min(Vector a, Vector b) {
            return new Vector(MathF.Min(a.x, b.x), MathF.Min(a.y, b.y), MathF.Min(a.z, b.z));
        }

        public static float Dot(Vector a, Vector b) {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        public static float Angle(Vector v) {
            return MathF.Atan2(v.y, v.x);
        }

        public float GetMagnitude() {
            return MathF.Sqrt(x * x + y * y + z * z);
        }

        public Vector Normalize() {
            var magnitude = GetMagnitude();
            // DO NOT DIVIDE BY ZERO!
            return magnitude > 0 ? this / GetMagnitude() : this;
        }

        public float GetSquareMagnitude()
        {
            throw new NotImplementedException();
        }
    }
}