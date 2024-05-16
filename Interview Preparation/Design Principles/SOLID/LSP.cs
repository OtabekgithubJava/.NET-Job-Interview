// This principle states that objects of a superclass should be replaceable with objects of its subclasses
// without affecting the correctness of the program.
// In other words, a subclass should be able to substitute its parent class without breaking the functionality of the program.


public class Bird
{
    public virtual string Fly()
    {
        return "Flying high";
    }
}

public class Sparrow : Bird
{
    public override string Fly()
    {
        return "Flying high";
    }
}

public class Ostrich : Bird
{
    public override string Fly()
    {
        return "I can't fly";
    }
}


// Both Sparrow and Ostrich are subclasses of Bird and can be substituted for Bird without affecting the functionality of the program