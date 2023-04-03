using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDA_V3
{
    internal class Point
    {
        private int _x;
        private int _y;

        public Point(int startX, int startY)
        {
            X = startX;
            Y = startY;
        }//end constructor
        public Point() 
        {
        
        
        }
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("+");
        }
    }
}
