namespace Observer.Observer;

public interface IObserver
{
    void Notify(IObservable subject);
}