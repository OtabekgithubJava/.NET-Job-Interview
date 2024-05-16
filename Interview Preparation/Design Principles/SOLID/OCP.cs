// This principle states that classes should be open for extension but closed for modification.
// This means that you should be able to add new functionality to a class without changing its existing code

public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }
}


// Here, if you want to add a new shape (e.g., a circle), you can create a new class that extends the Shape class without modifying the existing Shape or Rectangle classes