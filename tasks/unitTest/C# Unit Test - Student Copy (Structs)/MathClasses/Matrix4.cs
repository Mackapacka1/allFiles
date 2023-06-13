using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MathClasses
{
    public struct Matrix4
    {
        public float m00, m01, m02, m03;
        public float m10, m11, m12, m13;
        public float m20, m21, m22, m23;
        public float m30, m31, m32, m33;

        public Matrix4(
            float _m00, float _m01, float _m02, float _m03,
            float _m10, float _m11, float _m12, float _m13,
            float _m20, float _m21, float _m22, float _m23,
            float _m30, float _m31, float _m32, float _m33)       
        {
            m00 = _m00; m01 = _m01; m02 = _m02; m03 = _m03;
            m10 = _m10; m11 = _m11; m12 = _m12; m13 = _m13;
            m20 = _m20; m21 = _m21; m22 = _m22; m23 = _m23;
            m30 = _m30; m31 = _m31; m32 = _m32; m33 = _m33;
        }


        public static Matrix4 operator *(Matrix4 m4a, Matrix4 m4b)
        {
            return new Matrix4(
                m4a.m00 * m4b.m00 + m4a.m10 * m4b.m01 + m4a.m20 * m4b.m02 + m4a.m30 * m4b.m03,
                m4a.m01 * m4b.m00 + m4a.m11 * m4b.m01 + m4a.m21 * m4b.m02 + m4a.m31 * m4b.m03,
                m4a.m02 * m4b.m00 + m4a.m12 * m4b.m01 + m4a.m22 * m4b.m02 + m4a.m32 * m4b.m03,
                m4a.m03 * m4b.m00 + m4a.m13 * m4b.m01 + m4a.m23 * m4b.m02 + m4a.m33 * m4b.m03,

                m4a.m00 * m4b.m10 + m4a.m10 * m4b.m11 + m4a.m20 * m4b.m12 + m4a.m30 * m4b.m13,
                m4a.m01 * m4b.m10 + m4a.m11 * m4b.m11 + m4a.m21 * m4b.m12 + m4a.m31 * m4b.m13,
                m4a.m02 * m4b.m10 + m4a.m12 * m4b.m11 + m4a.m22 * m4b.m12 + m4a.m32 * m4b.m13,
                m4a.m03 * m4b.m10 + m4a.m13 * m4b.m11 + m4a.m23 * m4b.m12 + m4a.m33 * m4b.m13,

                m4a.m00 * m4b.m20 + m4a.m10 * m4b.m21 + m4a.m20 * m4b.m22 + m4a.m30 * m4b.m23,
                m4a.m01 * m4b.m20 + m4a.m11 * m4b.m21 + m4a.m21 * m4b.m22 + m4a.m31 * m4b.m23,
                m4a.m02 * m4b.m20 + m4a.m12 * m4b.m21 + m4a.m22 * m4b.m22 + m4a.m32 * m4b.m23,
                m4a.m03 * m4b.m20 + m4a.m13 * m4b.m21 + m4a.m23 * m4b.m22 + m4a.m33 * m4b.m23,

                m4a.m00 * m4b.m30 + m4a.m10 * m4b.m31 + m4a.m20 * m4b.m32 + m4a.m30 * m4b.m33,
                m4a.m01 * m4b.m30 + m4a.m11 * m4b.m31 + m4a.m21 * m4b.m32 + m4a.m31 * m4b.m33,
                m4a.m02 * m4b.m30 + m4a.m12 * m4b.m31 + m4a.m22 * m4b.m32 + m4a.m32 * m4b.m33,
                m4a.m03 * m4b.m30 + m4a.m13 * m4b.m31 + m4a.m23 * m4b.m32 + m4a.m33 * m4b.m33
                );
        }
        private void Set(Matrix4 m)
        {
            m00 = m.m00; m01 = m.m01; m02 = m.m02; m03 = m.m03;
            m10 = m.m10; m11 = m.m11; m12 = m.m12; m13 = m.m13;
            m20 = m.m20; m21 = m.m21; m22 = m.m22; m23 = m.m23;
            m30 = m.m30; m31 = m.m31; m32 = m.m32; m33 = m.m33;
        }
        private void Set(float _m00, float _m01, float _m02, float _m03,
            float _m10, float _m11, float _m12, float _m13,
            float _m20, float _m21, float _m22, float _m23,
            float _m30, float _m31, float _m32, float _m33)
        {
            m00 = _m00; m01 = _m01; m02 = _m02; m03 = _m03;
            m10 = _m10; m11 = _m11; m12 = _m12; m13 = _m13;
            m20 = _m20; m21 = _m21; m22 = _m22; m23 = _m23;
            m30 = _m30; m31 = _m31; m32 = _m32; m33 = _m33;
        }
        public void SetRotateX(double radians)
        {
            Set(1, 0, 0, 0,
                0, (float)Math.Cos(radians), (float)Math.Sin(radians),0,
                0, (float)-Math.Sin(radians), (float)Math.Cos(radians),0,
                0,0,0,1);
        }

        public void RotateX(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateX(radians);

            Set(this * m);
        }



        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, (float)-Math.Sin(radians),0,
                 0, 1, 0,0,
                (float)Math.Sin(radians), 0, (float)Math.Cos(radians),   0,
                0, 0, 0, 1);
        }

        public void RotateY(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateY(radians);

            Set(this * m);
        }



        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)Math.Sin(radians), 0, 0,
                (float)-Math.Sin(radians), (float)Math.Cos(radians), 0, 0,
                0, 0, 1 ,0,
                0, 0, 0 ,1);
        }

        public void RotateZ(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateZ(radians);

            Set(this * m);
        }


    }
}