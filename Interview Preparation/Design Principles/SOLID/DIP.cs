// This principle states that high-level modules should not depend on low-level modules; both should depend on abstractions.
// Additionally, abstractions should not depend on details; details should depend on abstractions.
// This helps to decouple modules and make the code more flexible and maintainable


public class LightBulb
{
    public void TurnOn()
    {
        // Turn on logic
    }
}

public class LightSwitch
{
    private LightBulb bulb;

    public LightSwitch()
    {
        bulb = new LightBulb(); // Dependency on concrete implementation
    }

    public void Toggle()
    {
        // Code to toggle the light bulb
    }
}


// In this example, LightSwitch depends directly on LightBulb, violating DIP. It's better to introduce an abstraction
// (e.g., an interface) between them to decouple them and adhere to DIP