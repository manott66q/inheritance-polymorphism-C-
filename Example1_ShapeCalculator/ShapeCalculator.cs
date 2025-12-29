using System;

// Base class - Shape
public class Shape
{
    protected string color;
    protected string name;
    
    // Constructor
    public Shape(string name, string color)
    {
        this.name = name;
        this.color = color;
    }
    
    // Virtual method to calculate area (will be overridden)
    public virtual double CalculateArea()
    {
        return 0.0;
    }
    
    // Virtual method to calculate perimeter (will be overridden)
    public virtual double CalculatePerimeter()
    {
        return 0.0;
    }
    
    // Display shape information
    public void DisplayInfo()
    {
        Console.WriteLine($"Shape: {name}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Area: {CalculateArea():F2}");
        Console.WriteLine($"Perimeter: {CalculatePerimeter():F2}");
        Console.WriteLine("------------------------");
    }
}

// Circle class - Inherits from Shape
public class Circle : Shape
{
    private double radius;
    
    public Circle(string color, double radius) : base("Circle", color)
    {
        this.radius = radius;
    }
    
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

// Rectangle class - Inherits from Shape
public class Rectangle : Shape
{
    private double length;
    private double width;
    
    public Rectangle(string color, double length, double width) : base("Rectangle", color)
    {
        this.length = length;
        this.width = width;
    }
    
    public override double CalculateArea()
    {
        return length * width;
    }
    
    public override double CalculatePerimeter()
    {
        return 2 * (length + width);
    }
}

// Triangle class - Inherits from Shape
public class Triangle : Shape
{
    private double side1, side2, side3;
    
    public Triangle(string color, double side1, double side2, double side3) : base("Triangle", color)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }
    
    public override double CalculateArea()
    {
        // Using Heron's formula
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }
    
    public override double CalculatePerimeter()
    {
        return side1 + side2 + side3;
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Shape Calculator System ===\n");
        
        // Creating objects of different shapes
        Shape circle = new Circle("Red", 5.0);
        Shape rectangle = new Rectangle("Blue", 10.0, 5.0);
        Shape triangle = new Triangle("Green", 3.0, 4.0, 5.0);
        
        // Displaying information (Polymorphism in action)
        circle.DisplayInfo();
        rectangle.DisplayInfo();
        triangle.DisplayInfo();
        
        Console.ReadLine();
    }
}
