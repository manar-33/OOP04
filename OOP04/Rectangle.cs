using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    public class Rectangle : IRectangle
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public double Area { get { return Length * Width ; } }

        decimal IShape.Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($" Rectangle Area : {Area}, Length:{Length}, Width :{Width}");
        }
    }
}
