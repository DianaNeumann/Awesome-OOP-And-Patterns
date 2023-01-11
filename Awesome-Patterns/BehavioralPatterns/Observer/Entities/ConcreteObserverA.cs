using Observer.Observer;
namespace Observer.Entities;

public class ConcreteObserverA : IObserver
{
    public void Notify(IObservable subject)
    {
        if (( (ObservableSubject)subject).State < 3)
        {
            Console.WriteLine($"{GetType().Name}: Reacted to the event.");
        }
    }
}