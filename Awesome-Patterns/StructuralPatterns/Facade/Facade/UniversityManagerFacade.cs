using Facade.Services.Interfaces;

namespace Facade.Facade;

public class UniversityManagerFacade
{
    private readonly IStudentService _studentService;
    private readonly IGroupService _groupService;

    public UniversityManagerFacade(IStudentService studentService, IGroupService groupService)
    {
        _studentService = studentService;
        _groupService = groupService;
    }

    public void RegisterStudent(string studentName, string groupName)
    {
        // some calculations...
        _studentService.CreateStudent(studentName);
        _groupService.CreateGroup(groupName);
        _groupService.AddStudentToGroup(studentName, groupName);
    }

    public void SomeBusinessLogic()
    {
        _studentService.DoSomethingWithStudent("tinky ");
        _studentService.DoSomethingElseWithStudent("winky");
        _groupService.DoSomethingWithGroup("dipsy");
        _groupService.DoSomethingElseWithGroup("lala po");
    }
}