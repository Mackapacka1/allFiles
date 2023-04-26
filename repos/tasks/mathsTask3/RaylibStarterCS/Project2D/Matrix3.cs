using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tonk
{
    public struct Matrix3
    {
        public float m00, m01, m02;
        public float m10, m11, m12;
        public float m20, m21, m22;

        public Matrix3(
            float _m00, float _m01, float _m02,
            float _m10, float _m11, float _m12,
            float _m20, float _m21, float _m22)
        {
            m00 = _m00; m01 = _m01; m02 = _m02;
            m10 = _m10; m11 = _m11; m12 = _m12;
            m20 = _m20; m21 = _m21; m22 = _m22;
        }

        public void SetScaled(float x, float y, float z)
        {
            m00 = x; m01 = 0; m02 = 0;
            m10 = 0; m11 = y; m12 = 0;
            m20 = 0; m21 = 0; m22 = z;
        }

        private void Set(Matrix3 m)
        {
            m00 = m.m00; m01 = m.m01; m02 = m.m02;
            m10 = m.m10; m11 = m.m11; m12 = m.m12;
            m20 = m.m20; m21 = m.m21; m22 = m.m22;
        }

        private void Set(float _m00, float _m01, float _m02,
            float _m10, float _m11, float _m12,
            float _m20, float _m21, float _m22)
        {
            m00 = _m00; m01 = _m01; m02 = _m02;
            m10 = _m10; m11 = _m11; m12 = _m12;
            m20 = _m20; m21 = _m21; m22 = _m22;
        }

        public void SetRotateX(double radians)
        {
            Set(1, 0, 0,
                0, (float)Math.Cos(radians), (float)Math.Sin(radians),
                0, (float)-Math.Sin(radians), (float)Math.Cos(radians));
        }

        public void RotateX(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateY(radians);

            Set(this * m);
        }
        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, (float)-Math.Sin(radians),
                 0, 1, 0,
                (float)Math.Sin(radians), 0, (float)Math.Cos(radians));
        }

        public void RotateY(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateY(radians);

            Set(this * m);
        }
        public void SetRotate(Matrix3 matrix)
        {
            m00 = matrix.m00; m01 = matrix.m01; m02 = matrix.m02;
            m10 = matrix.m10; m11 = matrix.m11; m12 = matrix.m12;
            m20 = matrix.m20; m21 = matrix.m21; m22 = matrix.m22;
        }


        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)Math.Sin(radians), 0,
                (float)-Math.Sin(radians), (float)Math.Cos(radians), 0,
                0, 0, 1);
        }

        public void RotateZ(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateZ(radians);

            Set(this * m);
        }



        public void SetTranslation(float x, float y)
        {
            m20 = x; m21 = y;
        }

        public void Translate(float x, float y)
        {
            m20 += x; m21 += y;
        }

        public static Matrix3 operator *(Matrix3 m3a, Matrix3 m3b)
        {
            return new Matrix3(
                m3a.m00 * m3b.m00 + m3a.m10 * m3b.m01 + m3a.m20 * m3b.m02,
                m3a.m01 * m3b.m00 + m3a.m11 * m3b.m01 + m3a.m21 * m3b.m02,
                m3a.m02 * m3b.m00 + m3a.m12 * m3b.m01 + m3a.m22 * m3b.m02,

                m3a.m00 * m3b.m10 + m3a.m10 * m3b.m11 + m3a.m20 * m3b.m12,
                m3a.m01 * m3b.m10 + m3a.m11 * m3b.m11 + m3a.m21 * m3b.m12,
                m3a.m02 * m3b.m10 + m3a.m12 * m3b.m11 + m3a.m22 * m3b.m12,

                m3a.m00 * m3b.m20 + m3a.m10 * m3b.m21 + m3a.m20 * m3b.m22,
                m3a.m01 * m3b.m20 + m3a.m11 * m3b.m21 + m3a.m21 * m3b.m22,
                m3a.m02 * m3b.m20 + m3a.m12 * m3b.m21 + m3a.m22 * m3b.m22);
        }


        public static Vector3 operator *(Matrix3 M, Vector3 V)
        {
            return new Vector3(
                V.x * M.m00 + V.y * M.m10 + V.z * M.m20,
                V.x * M.m01 + V.y * M.m11 + V.z * M.m21,
                V.x * M.m02 + V.y * M.m12 + V.z * M.m22);
        }

        public Matrix3(float uniformScale)
        {
            m00 = m11 = m22 = uniformScale;
            m01 = m02 = m10 = m12 = m20 = m21 = 0;
        }
    }
}
