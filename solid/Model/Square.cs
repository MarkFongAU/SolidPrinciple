using Solid.Interfaces;

namespace Solid.Models
{
    public class Square : IShape
    {
        public double length { get; set; }

        public Square(double length)
        {
            this.length = length;
        }

        //Post Open Close principle
        public double Area()
        {
            return Math.Pow(this.length, 2);
        }

        // public double Volume(){
        //     return Math.Pow(this.length, 3);
        // }
    }
}



