using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    public interface IShape
    {
        public decimal  Area { get; set; }
        public void DisplayShapeInfo();
        
    }
}
