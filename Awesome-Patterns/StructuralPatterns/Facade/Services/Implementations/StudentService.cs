using Facade.Services.Interfaces;

namespace Facade.Services.Implementations;

public class StudentService : IStudentService
{
    public void CreateStudent(string name)
    {
        Console.WriteLine($"{GetType().Name}: student \"{name}\" was created!");
    }

    public void DoSomethingWithStudent(string name)
    {
        Console.WriteLine($"{GetType().Name}: do something with student \"{name}\"");
    }

    public void DoSomethingElseWithStudent(string name)
    {
        Console.WriteLine($"{GetType().Name}: do something else with student \"{name}\"");
    }
}