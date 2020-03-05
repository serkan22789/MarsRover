using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNetCore.Models
{
    public struct Size
    {       
        public Size(int aWidth, int aHeight)
        {
            width = aWidth;
            height = aHeight;
        }

        private int width;
        private int height;

        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }
            
    }
}
