
namespace ClassLibrary;

public class Singleton
{
    private static Singleton Instance;
    private Singleton()
    {
        
    }

    public static Singleton GetInstance()
    {
        if (Instance == null)
            Instance = new Singleton();
        return Instance;
    }
}