using Solid.Models;
using Solid.Controllers;

class Program
{
    static void Main(string[] args)
    {
        object[] shapes = {
            new Circle(2),
            new Square(5),
            new Square(6)
        };

        var areaCalculator = new AreaCalculator(shapes);
        Console.WriteLine(areaCalculator.Output());
    }
}
