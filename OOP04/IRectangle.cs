using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    public interface IRectangle : IShape
    {
        int Width { get; set; }
        int Length { get; set; }
    }
}
