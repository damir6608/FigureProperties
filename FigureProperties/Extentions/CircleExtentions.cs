using FigureProperties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProperties.Extentions
{
    public static class CircleExtentions
    {
        public static double GetSquare(this Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }
    }
}
