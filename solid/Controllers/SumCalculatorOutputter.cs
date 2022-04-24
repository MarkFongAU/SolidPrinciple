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

            return ""; //JSON..
        }

        public string HTML()
        {
            return "";
        }
    }
}

