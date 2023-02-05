// See https://aka.ms/new-console-template for more information

public class ThreadSafeSingletonObject
{
    private static ThreadSafeSingletonObject _instance;

    private ThreadSafeSingletonObject()
    {
    }

    public static ThreadSafeSingletonObject GetInstance()
    {
        if (_instance == null)
        {
            lock (_instance)
            {
                // The first thread to acquire the lock, reaches this
                // conditional, goes inside and creates the Singleton
                // instance. Once it leaves the lock block, a thread that
                // might have been waiting for the lock release may then
                // enter this section. But since the Singleton field is
                // already initialized, the thread won't create a new
                // object.
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingletonObject();
                }
            }
        }

        return _instance;
    }
}