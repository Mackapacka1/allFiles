using System;
using System.Collections.Generic;
using System.Text;

namespace money
{
    internal class currencies
    {
        private float aud;
        public float Aud
            { get { return aud; } set { aud = value; } }    

        public float Usd
        {
            get { return (float)(Aud * 0.7); }
        }
    }
}
