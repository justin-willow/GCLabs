using Lab10_Circle;

Console.WriteLine("Welcome to the Circle Tester!");

double initialRadius = Validator.GetValidDoubleInput("Enter radius: ");
var circle = new Circle(initialRadius);
bool continueGrowingCircle = true;

while (continueGrowingCircle)
{
    Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
    Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
    Console.WriteLine($"Area: {circle.CalculateArea()}");

    bool shouldGrowCircle = Validator.GetValidYesNoInput("Should the circle grow? (y/n): ");

    if (shouldGrowCircle)
    {
        Console.WriteLine("The circle is magically growing...");
        circle.Grow();
    }
    else
    {
        Console.WriteLine($"Goodbye! The circle's final radius is {circle.GetRadius()}");
        continueGrowingCircle = false;
    }
}