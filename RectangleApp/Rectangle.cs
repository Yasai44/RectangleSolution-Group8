// Contribution by Sainabou Camara
// Contribution by Harsimranpreet Kaur

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    public class Rectangle
    {
        private int length;
        private int width;

        //Default Constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        //Non-default Constructor
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
         
        public int GetParimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}
