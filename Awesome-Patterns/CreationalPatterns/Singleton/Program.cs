namespace Singleton;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("== Not Thread Safe ==");
        var s1 = NotThreadSafe.Singleton.GetInstance();
        var s2 = NotThreadSafe.Singleton.GetInstance();

        Console.WriteLine(s1 == s2
            ? "Singleton works, both variables contain the same instance."
            : "Singleton failed, variables contain different instances.");

        ///////////////////////////////////////////////////
        Console.WriteLine("== Double Check Lock ==");
        Console.WriteLine(
            "If you see the same value, then singleton was reused :)\n" +
            "If you see different values, then 2 singletons were created :(\n" +
            "RESULT:"
        );

        Thread thread1 = new(() =>
        {
            var singleton = DoubleCheckLock.Singleton.GetInstance("FOO");
            Console.WriteLine(singleton.Value);
        });

        Thread thread2 = new(() =>
        {
            var singleton = DoubleCheckLock.Singleton.GetInstance("BAR");
            Console.WriteLine(singleton.Value);
        });

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
    }
}