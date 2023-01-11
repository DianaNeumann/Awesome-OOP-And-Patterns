using Proxy.Entities;
using Proxy.Proxies;

Client client = new();

Console.WriteLine("Client: Executing the client code with a real subject:");
RealSubject realSubject = new();
client.ClientCode(realSubject);

Console.WriteLine("\nClient: Executing the same client code with a subject proxy:");
SubjectProxy proxy = new(realSubject);
client.ClientCode(proxy);