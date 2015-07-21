using System;
using System.Collections.Generic;
using System.Text;

namespace Generator
{
    public struct Resolution
    {
        private int height;
        private int width;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
    }
}
