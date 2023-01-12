using Facade.Facade;
using Facade.Services.Implementations;

UniversityManagerFacade universityManager = new(new StudentService(), new GroupService());

universityManager.RegisterStudent("tinky", "dipsy");