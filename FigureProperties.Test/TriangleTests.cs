using FigureProperties.Extentions;
using FigureProperties.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FigureProperties.Test
{
    public class TriangleTests
    {
        [Test]
        public void TriangleSquare()
        {
            var perimetr = (5 + 4 + 3) / 2;
            var expectedSquare = Math.Sqrt(perimetr *
               (perimetr - 5) *
               (perimetr - 4) *
               (perimetr - 3));
            Assert.AreEqual(new Triangle() { Sides = new List<double> { 5, 4, 3 } }.GetSquare(), expectedSquare);
        }

        [Test]
        public void TriangleIsRight()
        {
            var expectedResult = Math.Pow(5, 2) == Math.Pow(4, 2) + Math.Pow(3, 2);
            Assert.AreEqual(new Triangle() { Sides = new List<double> { 5, 4, 3 } }.IsRight(), expectedResult);
        }
    }
}
