// This principle states that a class should have only one reason to change,
// meaning that it should have only one responsibility or job. If
// class has multiple responsibilities, changes to one of them may require modifications to other parts of the class,
// which can lead to fragile code:

// Bad example violating SRP !!!
public class Employee
{
    public void CalculateSalary()
    {
        // Calculation logic
    }

    public void GenerateReport()
    {
        // Report generation logic
    }
}


// In this case, the Employee class has multiple responsibilities: calculating salary and generating reports.
// It would be better to split these responsibilities into separate classes