using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP005
{
    public interface IShape
    {
        double c { get;  }
        void DisplayShapeInfo();

    }

    public interface ICircle : IShape { }

    public interface IRectangle : IShape { }

    public class Circle : ICircle
    {

        public double reduies { get; set; }

        public Circle(double reduies)
        {
            this.reduies = reduies;
        }
        public double area => Math.PI * reduies * reduies;

        public double c => throw new NotImplementedException();

        public void DisplayShapeInfo() 
        {
            Console.WriteLine($"Circle - Radius: {reduies}, Area: {area:F2}");
        }
    }

    public class Rectangle : IRectangle
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double area => width * height;

        public double c => throw new NotImplementedException();

        public void DisplayShapeInfo() 
        {
            Console.WriteLine($"Rectangle - Width: {width}, Height: {height}, Area: {area:F2}");
        }
    }
    
}
