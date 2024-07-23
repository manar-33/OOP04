using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    public class Circle : ICircle
    {
        public double Radius { get ; set ; }
        public double Area { get { return 3.14 * Radius * Radius; }}

        decimal IShape.Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($" Circle Area : {Area}, Radius: {Radius}"); 
        }
    }
}
