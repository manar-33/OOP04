﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    public interface ICircle: IShape
    {
       double Radius { get; set; }
    }
}
