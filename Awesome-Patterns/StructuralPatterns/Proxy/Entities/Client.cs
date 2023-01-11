namespace Proxy.Entities;

public class Client
{
    public void ClientCode(ISubject subject)
    {
        subject.Request();
    }
}