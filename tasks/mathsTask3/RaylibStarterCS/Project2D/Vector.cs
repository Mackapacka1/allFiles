using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tonk
{
    public struct Vector3
    {
        public float x, y, z;


        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
        }
        public static Vector3 operator +(Vector3 v3a, Vector3 v3b)
        {
            return new Vector3(v3a.x + v3b.x, v3a.y + v3b.y, v3a.z + v3b.z);
        }
        public static Vector3 operator -(Vector3 v3a, Vector3 v3b)
        {
            return new Vector3(v3a.x - v3b.x, v3a.y - v3b.y, v3a.z - v3b.z);
        }
        public static Vector3 operator *(Vector3 v3a, Vector3 v3b)
        {

            return new Vector3(v3a.x * v3b.x, v3a.y * v3b.y, v3a.z * v3b.z);
        }


        public static Vector3 operator +(Vector3 v3a, float num)
        {
            return new Vector3
                (v3a.x + num, v3a.y + num, v3a.z + num);
        }
        public static Vector3 operator -(Vector3 v3a, float num)
        {
            return new Vector3
                (v3a.x - num, v3a.y - num, v3a.z - num);
        }
        public static Vector3 operator *(Vector3 v3a, float num)
        {
            return new Vector3
                (v3a.x * num, v3a.y * num, v3a.z * num);
        }
        public static Vector3 operator /(Vector3 v3a, float num)
        {
            return new Vector3
                (v3a.x / num, v3a.y / num, v3a.z / num);
        }


        public static Vector3 operator +(float num, Vector3 v3a)
        {
            return new Vector3
                (v3a.x + num, v3a.y + num, v3a.z + num);
        }
        public static Vector3 operator -(float num, Vector3 v3a)
        {
            return new Vector3
                (v3a.x - num, v3a.y + num, v3a.z - num);
        }
        public static Vector3 operator *(float num, Vector3 v3a)
        {
            return new Vector3
                (v3a.x * num, v3a.y * num, v3a.z * num);
        }
        public float Dot(Vector3 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z;
        }

        public Vector3 Cross(Vector3 rhs)
        {
            return new Vector3(
                y * rhs.z - z * rhs.y,
                z * rhs.x - x * rhs.z,
                x * rhs.y - y * rhs.x);
        }
    }
}
