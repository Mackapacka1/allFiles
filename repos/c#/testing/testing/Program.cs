using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public struct Vector4
    {
        public float x, y, z;

        
        public Vector4(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Vector4 operator +(Vector4 v4a, Vector4 v4b)
        {
            return new Vector4(v4a.x + v4b.x, v4a.y + v4b.y, v4a.z + v4b.z);
        }
        public static Vector4 operator -(Vector4 v4a, Vector4 v4b)
        {
            return new Vector4(v4a.x - v4b.x, v4a.y - v4b.y, v4a.z - v4b.z);
        }
        public static Vector4 operator *(Vector4 v4a, Vector4 v4b)
        {

            return new Vector4(v4a.x * v4b.x, v4a.y * v4b.y, v4a.z * v4b.z);
        }
        public static Vector4 operator +(Vector4 v4a, float num)
        {
            return new Vector4(v4a.x + num, v4a.y + num, v4a.z + num);
        }
        public static Vector4 operator -(Vector4 v4a, float num)
        {
            return new Vector4(v4a.x - num, v4a.y + num, v4a.z - num);
        }
        public static Vector4 operator *(Vector4 v4a, float num)
        {
            return new Vector4(v4a.x * num, v4a.y * num, v4a.z * num);
        }


        public static Vector4 operator +(float num, Vector4 v4a)
        {
            return new Vector4(v4a.x + num, v4a.y + num, v4a.z + num);
        }
        public static Vector4 operator -(float num, Vector4 v4a)
        {
            return new Vector4(v4a.x - num, v4a.y + num, v4a.z - num);
        }
        public static Vector4 operator *(float num, Vector4 v4a)
        {
            return new Vector4(v4a.x * num, v4a.y * num, v4a.z * num);
        }
    }
}
