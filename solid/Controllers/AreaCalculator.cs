using Solid.Models;

namespace Solid.Controllers{
    public class AreaCalculator
    {
        protected object[] shapes;

        public AreaCalculator (object[] shapes = null){
            this.shapes = shapes;
        }

        public double Sum(){
            List<double> area = new List<double>();

            foreach (var shape in shapes){
                //Square
                if (shape is Square square){
                    area.Add(Math.Pow(square.length, 2));
                }else if (shape is Circle circle){
                    area.Add(Math.PI * Math.Pow(circle.radius, 2));
                }
            }

            return area.Sum();
        }

        public string Output() => $"Sum of the areas of provided shapes: {Sum()}";
    }
}



