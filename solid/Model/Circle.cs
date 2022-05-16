using Solid.Interfaces;

namespace Solid.Models
{
    public class Circle : IShape
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        //Post Open Close principle
        public double Area()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        // public double Volume(){
        //     return 4/3 * Math.PI * Math.Pow(this.radius, 3);
        // }
    }
}



