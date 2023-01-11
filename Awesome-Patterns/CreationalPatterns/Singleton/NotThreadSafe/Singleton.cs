namespace Singleton.NotThreadSafe;

public sealed class Singleton
{
    private Singleton() { }

    // Объект одиночки храниться в статичном поле класса. Существует
    // несколько способов инициализировать это поле, и все они имеют разные
    // достоинства и недостатки. В этом примере мы рассмотрим простейший из
    // них, недостатком которого является полная неспособность правильно
    // работать в многопоточной среде.
    private static Singleton _instance;

    // Это статический метод, управляющий доступом к экземпляру одиночки.
    // При первом запуске, он создаёт экземпляр одиночки и помещает его в
    // статическое поле. При последующих запусках, он возвращает клиенту
    // объект, хранящийся в статическом поле.
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }

    public void SomeBusinessLogic()
    {
        throw new NotImplementedException();
    }
}