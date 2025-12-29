using System;

// Base class - Vehicle
public class Vehicle
{
    public string brand;
    public string model;
    public int year;
    public double fuelCapacity;
    
    public Vehicle(string brand, string model, int year, double fuelCapacity)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.fuelCapacity = fuelCapacity;
    }
    
    // Virtual method to calculate fuel efficiency
    public virtual double CalculateFuelEfficiency()
    {
        return 0.0;
    }
    
    // Virtual method to calculate max distance
    public virtual double CalculateMaxDistance()
    {
        return fuelCapacity * CalculateFuelEfficiency();
    }
    
    // Virtual method to display specifications
    public virtual void DisplaySpecifications()
    {
        Console.WriteLine("General vehicle specifications");
    }
    
    // Display vehicle information
    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Fuel Capacity: {fuelCapacity} liters");
        Console.WriteLine($"Fuel Efficiency: {CalculateFuelEfficiency():F2} km/liter");
        Console.WriteLine($"Max Distance: {CalculateMaxDistance():F2} km");
        DisplaySpecifications();
        Console.WriteLine("------------------------");
    }
}

// Car class - Inherits from Vehicle
public class Car : Vehicle
{
    private int numberOfDoors;
    private bool isAutomatic;
    
    public Car(string brand, string model, int year, double fuelCapacity, int doors, bool automatic) 
        : base(brand, model, year, fuelCapacity)
    {
        this.numberOfDoors = doors;
        this.isAutomatic = automatic;
    }
    
    public override double CalculateFuelEfficiency()
    {
        return 15.0;
    }
    
    public override void DisplaySpecifications()
    {
        Console.WriteLine($"Type: Car");
        Console.WriteLine($"Number of Doors: {numberOfDoors}");
        Console.WriteLine($"Transmission: {(isAutomatic ? "Automatic" : "Manual")}");
    }
}

// Bike class - Inherits from Vehicle
public class Bike : Vehicle
{
    private int engineCC;
    private bool hasFairing;
    
    public Bike(string brand, string model, int year, double fuelCapacity, int cc, bool fairing) 
        : base(brand, model, year, fuelCapacity)
    {
        this.engineCC = cc;
        this.hasFairing = fairing;
    }
    
    public override double CalculateFuelEfficiency()
    {
        return 35.0;
    }
    
    public override void DisplaySpecifications()
    {
        Console.WriteLine($"Type: Bike");
        Console.WriteLine($"Engine Capacity: {engineCC} CC");
        Console.WriteLine($"Fairing: {(hasFairing ? "Yes" : "No")}");
    }
}

// Truck class - Inherits from Vehicle
public class Truck : Vehicle
{
    private double loadCapacity;
    private int numberOfAxles;
    
    public Truck(string brand, string model, int year, double fuelCapacity, double loadCapacity, int axles) 
        : base(brand, model, year, fuelCapacity)
    {
        this.loadCapacity = loadCapacity;
        this.numberOfAxles = axles;
    }
    
    public override double CalculateFuelEfficiency()
    {
        return 8.0;
    }
    
    public override void DisplaySpecifications()
    {
        Console.WriteLine($"Type: Truck");
        Console.WriteLine($"Load Capacity: {loadCapacity} tons");
        Console.WriteLine($"Number of Axles: {numberOfAxles}");
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Vehicle Management System ===\n");
        
        Vehicle car = new Car("Honda", "Civic", 2023, 50, 4, true);
        Vehicle bike = new Bike("Honda", "CD 70", 2023, 9, 70, false);
        Vehicle truck = new Truck("Hino", "500 Series", 2022, 200, 15, 3);
        
        car.DisplayInfo();
        bike.DisplayInfo();
        truck.DisplayInfo();
        
        Console.ReadLine();
    }
}
