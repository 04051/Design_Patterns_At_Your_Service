namespace ClassLibrary;

public class Singleton
{
    private static Singleton Instance;
    
    private Singleton()
    {
        
    }

    public static Singleton GetInstance()
    {
        return Instance ??= new Singleton();
    }
}