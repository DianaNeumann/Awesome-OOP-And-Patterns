namespace Proxy.Entities;

public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine($"{GetType().Name}: Handling Request.");
    }
}