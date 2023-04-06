using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public struct Colour
    {
        // this will store four bytes representing RGBA in the most to last significant bytes
        public UInt32 colour;
        public byte red
        {
            get { return (byte)((colour >> 24) & 0xff); }
            set { colour = (colour & 0x00ffffff) | ((UInt32)value << 24); }
        }
        public byte green
        {
            get { return (byte)((colour >> 16) & 0x00ff); }
            set { colour = (colour & 0xff00ffff) | ((UInt32)value << 16); }
        }
        public byte blue
        {
            get { return (byte)((colour >> 8) & 0x0000ff); }
            set { colour = (colour & 0xffff00ff) | ((UInt32)value << 8); }
        }
        public byte alpha
        {
            get { return (byte)((colour) & 0x000000ff); }
            set { colour = (colour & 0xffffff00) | ((UInt32)value); }
        }

        public Colour(byte r, byte g, byte b, byte a)
        {
            colour = 0;

            this.red = r;
            this.green = g;
            this.blue = b;
            this.alpha = a;
            
        }

        
    }




    
}
