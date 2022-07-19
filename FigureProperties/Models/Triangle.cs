using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProperties.Models
{
    public class Triangle
    {
        private List<double> array = new List<double>();
        public List<double> Sides
        {
            get => array;
            set
            {
                if (array.Count <= 3)
                    array = value;
            }
        }
    }
}
