namespace Facade.Services.Interfaces;

public interface IStudentService
{
    void CreateStudent(string name);
    void DoSomethingWithStudent(string name);
    void DoSomethingElseWithStudent(string name);
}