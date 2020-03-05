using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNetCore.Models
{
    public struct Size
    {
        public int Width;
        public int Height;

        public Size(int aWidth, int aHeight)
        {
            Width = aWidth;
            Height = aHeight;
        }
    }
}
