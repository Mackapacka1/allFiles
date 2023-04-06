using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathClasses
{
    public struct Vector4
    {
        public float x, y, z, w;


        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }


        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z + w * w);
        }
        public Vector4 Normalize()
        {
            float m = Magnitude();
            return new Vector4(
                this.x /= m,
                this.y /= m,
                this.z /= m,
                this.w /= m);
        }

        public static Vector4 operator +(Vector4 v4a, Vector4 v4b)
        {
            return new Vector4
                (v4a.x + v4b.x, v4a.y + v4b.y, v4a.z + v4b.z, v4a.w + v4b.w);
        }
        public static Vector4 operator -(Vector4 v4a, Vector4 v4b)
        {
            return new Vector4
                (v4a.x - v4b.x, v4a.y - v4b.y, v4a.z - v4b.z, v4a.w - v4b.w);
        }
        public static Vector4 operator *(Vector4 v4a, Vector4 v4b)
        {

            return new Vector4
                (v4a.x * v4b.x, v4a.y * v4b.y, v4a.z * v4b.z, v4a.w * v4b.w);
        }
        public static Vector4 operator *(Vector4 v4a, float num)
        {
            return new Vector4
                (v4a.x * num, v4a.y * num, v4a.z * num, v4a.w * num);
        }
        public static Vector4 operator +(Vector4 v4a, float num)
        {
            return new Vector4
                (v4a.x + num, v4a.y + num, v4a.z + num, v4a.w + num);
        }
        public static Vector4 operator -(Vector4 v4a, float num)
        {
            return new Vector4
                (v4a.x - num, v4a.y - num, v4a.z - num, v4a.w - num);
        }
        public static Vector4 operator /(Vector4 v4a, float num)
        {
            return new Vector4
                (v4a.x / num, v4a.y / num, v4a.z / num, v4a.w / num);
        }



        public static Vector4 operator +(float num, Vector4 v4a)
        {
            return new Vector4
                (v4a.x + num, v4a.y + num, v4a.z + num, v4a.w + num);
        }
        public static Vector4 operator -(float num, Vector4 v4a)
        {
            return new Vector4
                (v4a.x - num, v4a.y + num, v4a.z - num, v4a.w - num);
        }
        public static Vector4 operator *(float num, Vector4 v4a)
        {
            return new Vector4
                (v4a.x * num, v4a.y * num, v4a.z * num, v4a.w * num);
        }

        public float Dot(Vector4 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z + w * 0;
        }

        public Vector4 Cross(Vector4 rhs)
        {
            return new Vector4(
        y * rhs.z - z * rhs.y,
        z * rhs.x - x * rhs.z,
        x * rhs.y - y * rhs.x,
        0);
        }

        public static Vector4 operator *(Matrix4 M, Vector4 V)
        {

            Vector4 result = new Vector4(
            V.x * M.m00 + V.y * M.m10 + V.z * M.m20 + V.w * M.m30,
            V.x * M.m01 + V.y * M.m11 + V.z * M.m21 + V.w * M.m31,
            V.x * M.m02 + V.y * M.m12 + V.z * M.m22 + V.w * M.m32,
            V.x * M.m03 + V.y * M.m13 + V.z * M.m23 + V.w * M.m33);

            return result;
        }
    }
}
