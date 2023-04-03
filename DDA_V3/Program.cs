using System;
using System.Collections.Generic;

namespace DDA_V3
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Point P0 = new Point(4, 8);
            Point P1 = new Point(4, 3);
            Line newLine = new Line(P0, P1);
            newLine.Draw();


            Console.ReadKey();



        }
    }
}
