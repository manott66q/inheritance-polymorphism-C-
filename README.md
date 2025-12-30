# inheritance-polymorphism-C#
A simple C# project demonstrating inheritance and polymorphism concepts.

# Inheritance and Polymorphism in C#

## 📌 Project Overview
This project demonstrates **Inheritance** and **Polymorphism** concepts in C# through 3 real-world examples. Each example shows how base classes can be extended and how methods can be overridden to provide specific implementations.

---

## 🎯 Concepts Covered

### 1. **Inheritance**
Inheritance allows a class to inherit properties and methods from another class. It promotes code reusability.

- **Parent Class (Base Class)**: The class being inherited from
- **Child Class (Derived Class)**: The class that inherits from the parent class

### 2. **Polymorphism**
Polymorphism means "many forms". It allows objects of different classes to be treated as objects of a common parent class.

- **Method Overriding**: Child classes provide their own implementation of parent class methods
- **Virtual and Override Keywords**: Used to enable method overriding in C#

---

## 📂 Project Structure
```
inheritance-polymorphism-csharp/
│
├── Example1_ShapeCalculator/
│   └── ShapeCalculator.cs          # Shape calculation system
│
├── Example2_EmployeeManagement/
│   └── EmployeeManagement.cs       # Employee management system
│
├── Example3_VehicleSystem/
│   └── VehicleSystem.cs            # Vehicle management system
│
└── README.md                        # Documentation
```

---

## 💻 Examples

### Example 1: Shape Calculator System

**Purpose**: Calculate area and perimeter of different shapes.

**Classes**:
- `Shape` (Base Class)
- `Circle` (Derived Class)
- `Rectangle` (Derived Class)
- `Triangle` (Derived Class)

**Key Features**:
- Each shape has its own formula for area and perimeter
- Demonstrates method overriding
- Uses virtual and override keywords

**How to Run**:
```bash
cd Example1_ShapeCalculator
csc ShapeCalculator.cs
ShapeCalculator.exe
```

**Output**:
```
=== Shape Calculator System ===

Shape: Circle
Color: Red
Area: 78.54
Perimeter: 31.42
------------------------
Shape: Rectangle
Color: Blue
Area: 50.00
Perimeter: 30.00
------------------------
...
```

---

### Example 2: Employee Management System

**Purpose**: Manage different types of employees with varying salaries and responsibilities.

**Classes**:
- `Employee` (Base Class)
- `Manager` (Derived Class)
- `Developer` (Derived Class)
- `Intern` (Derived Class)

**Key Features**:
- Different salary calculations for each employee type
- Custom responsibilities for each role
- Demonstrates real-world inheritance usage

**How to Run**:
```bash
cd Example2_EmployeeManagement
csc EmployeeManagement.cs
EmployeeManagement.exe
```

**Output**:
```
=== Employee Management System ===

Name: Ali Khan
ID: 101
Salary: $100000.00
Responsibilities: Lead team of 10 members
...
```

---

### Example 3: Vehicle System

**Purpose**: Manage different types of vehicles with varying fuel efficiency and specifications.

**Classes**:
- `Vehicle` (Base Class)
- `Car` (Derived Class)
- `Bike` (Derived Class)
- `Truck` (Derived Class)

**Key Features**:
- Different fuel efficiency calculations
- Maximum distance calculation based on fuel capacity
- Vehicle-specific specifications

**How to Run**:
```bash
cd Example3_VehicleSystem
csc VehicleSystem.cs
VehicleSystem.exe
```

**Output**:
```
=== Vehicle Management System ===

Brand: Honda
Model: Civic
Fuel Efficiency: 15.00 km/liter
Max Distance: 750.00 km
...
```

---

## 🔑 Key Concepts Explained

### Inheritance Syntax in C#
```csharp
// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

// Derived class
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}
```

### Polymorphism with Method Overriding
```csharp
// Base class
public class Shape
{
    public virtual double CalculateArea()
    {
        return 0.0;
    }
}

// Derived class
public class Circle : Shape
{
    private double radius;
    
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}
```

---

## 🚀 How to Use This Project

### Prerequisites
- .NET Framework or .NET Core installed
- C# Compiler (csc.exe)
- Visual Studio (optional but recommended)

### Running Individual Examples

**Option 1: Using Command Line**
```bash
# Navigate to example folder
cd Example1_ShapeCalculator

# Compile the code
csc ShapeCalculator.cs

# Run the executable
ShapeCalculator.exe
```

**Option 2: Using Visual Studio**
1. Open Visual Studio
2. Create new Console Application
3. Copy the code from any example
4. Run the project (F5)

---

## 📖 Learning Outcomes

After studying this project, you will understand:

✅ How inheritance promotes code reusability  
✅ How to create base and derived classes  
✅ How to use `virtual` and `override` keywords  
✅ How polymorphism allows treating different objects uniformly  
✅ Real-world applications of OOP concepts  
✅ How to structure object-oriented programs  

---

## 🤝 Contributing

Feel free to:
- Add more examples
- Improve existing code
- Fix bugs
- Enhance documentation

---

## 📝 License

This project is open source and available for educational purposes.

---

## 👨‍💻 Author

Created as a learning project to demonstrate Inheritance and Polymorphism in C#.

---

## 📧 Contact

For questions or suggestions, please open an issue on GitHub.

---

## 🎓 Additional Resources

- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [C# Inheritance Tutorial](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance)
- [C# Polymorphism Tutorial](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism)

---

**Happy Coding! 🚀**
