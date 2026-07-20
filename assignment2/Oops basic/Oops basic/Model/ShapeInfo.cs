using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Oops_basic.Model
{
    public class ShapeInfo
    {
        public string shapeName { get; set; }
        public string Color { get; set; }
    }
    public class CircleInfo : ShapeInfo
    {
        public double Radius { get; set; }
        public CircleInfo(string shapeName, string color, double radius)
        {
            this.Color = color;
            this.Radius = radius;
        }
    }

    public class RectangleInfo : ShapeInfo
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public RectangleInfo(string shapeName, string color, double length, double width)
        {
            this.shapeName = shapeName;
            this.Color = color;
            this.Length = length;
            this.Width = width;
        }
    }
}
