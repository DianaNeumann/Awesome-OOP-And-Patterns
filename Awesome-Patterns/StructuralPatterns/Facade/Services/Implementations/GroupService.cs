using Facade.Services.Interfaces;

namespace Facade.Services.Implementations;

public class GroupService : IGroupService
{
    public void CreateGroup(string name)
    {
        Console.WriteLine($"{GetType().Name}: group \"{name}\" was created!");
    }

    public void AddStudentToGroup(string name, string studentName)
    {
        Console.WriteLine($"{GetType().Name}: add student \"{studentName}\" to group \"{name}\"!");
    }

    public void DoSomethingWithGroup(string name)
    {
        Console.WriteLine($"{GetType().Name} do something with group \"{name}\"");
    }

    public void DoSomethingElseWithGroup(string name)
    {
        Console.WriteLine($"{GetType().Name} do something else with group \"{name}\"");

    }
}