using FigureProperties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProperties.Extentions
{
    public static class TriangleExtentions
    {
        public static double GetSquare(this Triangle triangle)
        {
            var perimetr = triangle.Sides.Sum() / 2;
            return Math.Sqrt(perimetr * 
                (perimetr - triangle.Sides[0]) * 
                (perimetr - triangle.Sides[1]) * 
                (perimetr - triangle.Sides[2])); //Geron formula
        }

        public static bool IsRight(this Triangle triangle)
        {
            var arr = triangle.Sides.OrderBy(o => o).ToList();
            return Math.Pow(arr.Last(), 2) == Math.Pow(arr[0], 2) + Math.Pow(arr[1], 2);
        }
    }
}
