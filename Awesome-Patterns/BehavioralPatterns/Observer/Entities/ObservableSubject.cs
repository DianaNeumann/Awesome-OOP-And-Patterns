using Observer.Observer;

namespace Observer.Entities;

public class ObservableSubject : IObservable
{
    public int State { get; private set; } = 0;
    private readonly List<IObserver> _observers = new();

    public void SomeBusinessLogic()
    {
        Console.WriteLine($"=== Computing... ===");
        State = new Random().Next(0, 10);
        Thread.Sleep(300);
        Console.WriteLine($"{GetType().Name}: My state changed to: {State}");
        Notify();

    }

    public void Attach(IObserver observer)
    {
        Console.WriteLine($"{GetType().Name}: Attached an observer.");
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        Console.WriteLine($"{GetType().Name}: Detached an observer.");
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Notify(this);
        }
    }
}