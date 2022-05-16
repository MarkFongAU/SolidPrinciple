using Solid.Interfaces;

namespace Solid.Models
{
    public class Cuboid : IShape, IThreeDimensionalShape, IManageShape
    {
        public double length { get; set; }

        public Cuboid(double length)
        {
            this.length = length;
        }

        //Post Open Close principle
        public double Area()
        {
            return Math.PI * Math.Pow(this.length, 2);
        }

        public double Volume(){
            return Math.Pow(this.length, 3);
        }

        public double Calculate(){
            return this.Area();
        }
    }
}