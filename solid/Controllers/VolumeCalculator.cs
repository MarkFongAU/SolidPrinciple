using Solid.Models;
using Solid.Interfaces;

namespace Solid.Controllers
{
    public class VolumeCalculator : AreaCalculator
    {
        public VolumeCalculator(object[]? shapes = null)
        {
            base.shapes = shapes;
        }

        //Post Liskov Substitution Principle
        public override double Sum()
        {
            //Logic to calculate the volumes and then return an array of output
            List<double> volume = new List<double>();

            if (shapes != null)
            {
                foreach (var shape in shapes)
                {
                    if (shape is Square square)
                    {
                        volume.Add(Math.Pow(square.length, 3));
                    }
                    else if (shape is Circle circle)
                    {
                        volume.Add(4 / 3 * Math.PI * Math.Pow(circle.radius, 3));
                    }
                }
            }

            return volume.Sum();
        }

        //Post Liskov Substitution Principle
        public override string Output() => $"Sum of the areas of provided shapes: {Sum()}";
    }
}