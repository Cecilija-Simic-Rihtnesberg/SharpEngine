using System;

namespace SharpEngine {
	public struct Vector {
		public float x, y, z;

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
        
		public static Vector Max(Vector a, Vector b) {
			return new Vector(MathF.Max(a.x, b.y), MathF.Max(a.y, b.y), MathF.Max(a.z, b.z));
		}
		public static Vector Min(Vector a, Vector b) {
			return new Vector(MathF.Min(a.x, b.y), MathF.Min(a.y, b.y), MathF.Min(a.x, b.z));
		}

		public static float Angle(Vector v) {
			return MathF.Atan2(v.y, v.x);
		}

		public float GetMagnitude() {
			return MathF.Sqrt(x * x + y * y + z * z);
		}
        
		// +
		// -
		// /
	}
}