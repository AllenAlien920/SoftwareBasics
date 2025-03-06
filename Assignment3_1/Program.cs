namespace Assignment3_1;

class Program
{
    public static void Main()
    {
        double totalArea = 0;
        ShapeFactory shapeFactory = new ShapeFactory();
        for (var i = 0; i < 10; ++i)
        {
            var shape = shapeFactory.CreateRandomShape();
            Console.WriteLine(shape);
            totalArea += shape.Area();
        }

        Console.WriteLine($"Total Area : {totalArea}");
    }
}

public abstract class Shape
{
    public abstract double Area();

    public abstract bool IsValid();
}

public class Rectangle(double height, double width) : Shape
{
    private double Height { get; set; } = height;
    private double Width { get; set; } = width;

    public override string ToString()
    {
        return $"Rectangle : Height = {Height}, Width = {Width}";
    }

    public override double Area()
    {
        if (!IsValid()) throw new ArithmeticException("Height or Width is not positive");
        return Height * Width;
    }

    public override bool IsValid()
    {
        return Height > 0 && Width > 0;
    }
}

public class Square(double side) : Shape
{
    private double Side { get; set; } = side;

    public override string ToString()
    {
        return $"Square : Side = {Side}";
    }

    public override double Area()
    {
        if (!IsValid()) throw new ArithmeticException("Side is not positive");
        return Side * Side;
    }

    public override bool IsValid()
    {
        return Side > 0;
    }
}

public class Triangle(double sideA, double sideB, double sideC) : Shape
{
    private double SideA { get; set; } = sideA;
    private double SideB { get; set; } = sideB;
    private double SideC { get; set; } = sideC;

    public override string ToString()
    {
        return $"Triangle : SideA = {SideA}, SideB = {SideB}, SideC = {SideC}";
    }

    public override double Area()
    {
        if (!IsValid()) throw new ArithmeticException("Side is not positive or the three sides cannot form a triangle");
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override bool IsValid()
    {
        if (SideA <= 0 || SideB <= 0 || SideC <= 0) return false;
        return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
    }
}

public class ShapeFactory
{
    public Rectangle CreateRectangle(double height, double width)
    {
        return new Rectangle(height, width);
    }

    public Square CreateSquare(double side)
    {
        return new Square(side);
    }

    public Triangle CreateTriangle(double sideA, double sideB, double sideC)
    {
        return new Triangle(sideA, sideB, sideC);
    }

    public Shape CreateRandomShape()
    {
        var random = new Random();
        var type = random.Next() % 3;
        switch (type)
        {
            case 0:
                var height = Math.Abs(random.NextDouble()) * 100;
                var width = Math.Abs(random.NextDouble()) * 100;
                return CreateRectangle(height, width);
            case 1:
                var side = Math.Abs(random.NextDouble()) * 100;
                return CreateSquare(side);
            case 2:
                var sideA = Math.Abs(random.NextDouble()) * 100;
                var sideB = Math.Abs(random.NextDouble()) * 100;
                var leftBound = Math.Abs(sideA - sideB);
                var rightBound = sideA + sideB;
                var sideC = Math.Abs(random.NextDouble()) * 100 % (rightBound - leftBound) + leftBound;
                return CreateTriangle(sideA, sideB, sideC);
        }

        throw new Exception();
    }
}