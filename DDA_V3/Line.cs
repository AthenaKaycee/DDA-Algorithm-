using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDA_V3
{
    internal class Line
    {
        private Point _P0;//point 1
        private Point _P1; //point 2
        private double _Slope; //reseach 
        private Point _MidPoint;// point
                                //end of constructor 1






        public Line(Point newp0, Point newp1)
        {
            _p0 = newp0;
            _p1 = newp1;
        } //end of constructor 2




        public Line(int x1, int y1, int x2, int y2)
        {
            _p0.X = x1;
            _p0.Y = y1;
            _p1.X = x2;
            _p1.Y = y2;
        }//end of constructor 3




        private Point _p0 = new Point ();
        private Point _p1 = new Point();

        private Point P0
        {
            get { return _p0; }
            set { _p0 = value; }
        }
        private Point P1
        {
            get { return _p1; }
            set { _p1 = value; }
        }




        public void Draw()
        {

            //DDA Algorithm
            //Name of the varibles 
            double XR = 0;
            double YR = 0;
            double steps = 0;
            double xDraw = 0;
            double yDraw = 0;
            //The diffentce between the points
            double dx = Math.Abs(P0.X - P1.X);
            double dy = Math.Abs(P0.Y - P1.Y);

            //Getting the incriment of x and y 

            if (dx > dy)
            {

                steps = Math.Abs(dx);

            }
            else
            {

                steps = Math.Abs(dy);

            }//end else 
            XR = dx / steps;
            YR = dy / steps;


            xDraw = P0.X;
            yDraw = P0.Y;
            
            for (int i = 0; i <= steps; i += 1)
            {
                Console.SetCursorPosition((int)xDraw, (int)yDraw);
                Console.WriteLine("*");
                xDraw -= XR;
                yDraw -= YR;
            }//end for loop 



        }//end method

        public void Perturb(int xmin, int xmax, int ymin, int ymax)
        {
            Random rnd = new Random();

            int xEnd = rnd.Next(xmin, xmax);
            int yEnd = rnd.Next(ymin, ymax);

            if (xEnd > yEnd)
            {
                P0.Y += xEnd;
            }
            else
            {
                P0.X += yEnd;
            }
        }//End Perturb

        public void Collapse()
        {
            int dx = P0.X - P1.X;

            int dy = P0.Y - P1.Y;
        }

        //end class
    }
}
