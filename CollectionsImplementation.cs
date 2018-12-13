using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void main(string []args)
        {

        }
    }

    // main
    public class Box : IEquatable<Box>
    {
        public Box(int h,int l,int w)
        {
            this.Height = h;
            this.Length = l;
            this.Width = w;
        }

        public int Height{get; set;}
        public int Length{get; set;}
        public int Width{get; set;}

        public bool Equals(Box other)
        {
            if(new BoxSameDimensions().Equals(this,other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

    // operations

    public class BoxSameDimensions : EqualityComparer<Box>
    {
            public override bool Equals(Box b1, Box b2)
            {
                if(b1.Height == b2.Height && b1.Length == b2.Length && b1.Width == b2.Width)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        public override int GetHashCode(Box bx)
        {
            int hCode = bx.Height ^ bx.Length ^ bx.Width;
            return hCode.GetHashCode();
        }
    }

}