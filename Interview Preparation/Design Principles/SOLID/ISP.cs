// This principle states that a client should not be forced to depend on interfaces it does not use.
// It suggests that you should split interfaces into smaller,
// more specific ones so that clients only need to know about the methods that are relevant to them


public interface IMachine
{
    void Print();
    void Scan();
}

public class Machine : IMachine
{
    public void Print()
    {
        // Printing logic
    }

    public void Scan()
    {
        // Scanning logic
    }
}

public class Printer : IMachine
{
    public void Print()
    {
        // Printing logic
    }

    public void Scan()
    {
        // Empty implementation since Printer can't scan
    }
}


// Clients that only need to print shouldn't be forced to implement the Scan method.
// It's better to have separate interfaces for printing and scanning