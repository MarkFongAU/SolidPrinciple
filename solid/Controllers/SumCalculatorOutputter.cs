using System.Text.Json;

namespace Solid.Controllers
{
    public class SumCalculatorOutputter
    {
        protected AreaCalculator calculator;

        public SumCalculatorOutputter(AreaCalculator calculator)
        {
            this.calculator = calculator;
        }

        public string JSON()
        {
            var data = new
            {
                sum = this.calculator.Sum()
            };

            return JsonSerializer.Serialize(data); //JSON..
        }

        public string HTML()
        {

            return $"Sum of the areas of provided shapes: {this.calculator.Sum()}";
        }
    }
}

