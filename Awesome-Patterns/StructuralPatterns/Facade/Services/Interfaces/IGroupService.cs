namespace Facade.Services.Interfaces;

public interface IGroupService
{
    void CreateGroup(string name);
    void AddStudentToGroup(string name, string studentName);
    void DoSomethingWithGroup(string name);
    void DoSomethingElseWithGroup(string name);
}