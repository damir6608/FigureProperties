using FigureProperties.Models;
using FigureProperties.Extentions;
using System;
using System.Collections.Generic;

namespace FigureCaller
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle() { Sides = new List<double> { 5, 4, 3 } };
            var triangleSquare = triangle.GetSquare();
            var isRight = triangle.IsRight();

            var circleSquare = new Circle() { Radius = 4 }.GetSquare();
        }
    }
}
