using FigureProperties.Extentions;
using FigureProperties.Models;
using NUnit.Framework;
using System;

namespace FigureProperties.Test
{
    public class CircleTests
    {
        [Test]
        public void CircleSquare()
        {
            Assert.AreEqual(new Circle() { Radius = 2 }.GetSquare(), Math.PI * Math.Pow(2, 2));
        }
    }
}