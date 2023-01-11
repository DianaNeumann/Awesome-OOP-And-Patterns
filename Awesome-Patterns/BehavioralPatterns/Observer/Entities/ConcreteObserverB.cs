using Observer.Observer;
namespace Observer.Entities;

public class ConcreteObserverB : IObserver
{
    public void Notify(IObservable subject)
    {
        if (( (ObservableSubject)subject).State is 0 or >= 2)
        {
            Console.WriteLine($"{GetType().Name}: Reacted to the event.");
        }
    }
}