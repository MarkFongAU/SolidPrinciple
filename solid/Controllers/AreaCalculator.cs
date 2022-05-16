using Solid.Models;
using Solid.Interfaces;

namespace Solid.Controllers
{
    public class AreaCalculator
    {
        protected object[]? shapes;

        public AreaCalculator(object[]? shapes = null)
        {
            this.shapes = shapes;
        }

        public virtual double Sum()
        {
            List<double> area = new List<double>();

            if (shapes != null)
            {
                foreach (var shape in shapes)
                {
                    //Pre Open Close
                    // if (shape is Square square)
                    // {
                    //     area.Add(Math.Pow(square.length, 2));
                    // }
                    // else if (shape is Circle circle)
                    // {
                    //     area.Add(Math.PI * Math.Pow(circle.radius, 2));
                    // }

                    //Post Open Close principle
                    if (shape is IShape localShape)
                    {
                        area.Add(localShape.Area());
                        continue;
                    }

                    throw new System.Exception();
                }
            }

            return area.Sum();
        }

        public virtual string Output() => $"Sum of the areas of provided shapes: {Sum()}";
    }
}



