// See https://aka.ms/new-console-template for more information
public class SingletonObject
{
    private static SingletonObject _instance;

    private SingletonObject()
    {
    }

    public static SingletonObject GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SingletonObject();
        }

        return _instance;
    }
}
