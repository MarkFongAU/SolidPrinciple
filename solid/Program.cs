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

        object[] solidShapes = {
            new Circle(2),
            new Square(5),
            new Square(6)
        };

        var areas = new AreaCalculator(shapes);
        var volumes = new VolumeCalculator(solidShapes);
        Console.WriteLine("Areas: " + areas.Output());
        Console.WriteLine("Volumes: " + volumes.Output());

        var outputArea = new SumCalculatorOutputter(areas);
        var outputVolume = new SumCalculatorOutputter(volumes);
        Console.WriteLine(outputArea.JSON());
        Console.WriteLine(outputArea.HTML());

        Console.WriteLine(outputVolume.JSON());
        Console.WriteLine(outputVolume.HTML());
    }
}
