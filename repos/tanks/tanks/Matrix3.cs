using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace tanks
{

    public struct Matrix3
    {
        public float m00, m01, m02;
        public float m10, m11, m12;
        public float m20, m21, m22;

        public Matrix3(float v) : this()
        {
            this.v = v;
        }

        //public Matrix3(float v1, float v2, float v3, float v4, float v5, float v6, float v7, float v8, float v9) : this()
        //{
        //    this.v1 = v1;
        //    this.v2 = v2;
        //    this.v3 = v3;
        //    this.v4 = v4;
        //    this.v5 = v5;
        //    this.v6 = v6;
        //    this.v7 = v7;
        //    this.v8 = v8;
        //    this.v9 = v9;
        //}



        public Matrix3 LocalTransform
        {
            get { return localTransform; }
        }

        public Matrix3 GlobalTransform
        {
            get { return globalTransform; }
        }
    }

}