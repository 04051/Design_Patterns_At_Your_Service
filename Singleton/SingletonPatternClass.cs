using System.Runtime.CompilerServices;

namespace ClassLibrary;

public class Singleton
{
    private static Singleton Instance;
    private Singleton()
    {
        
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public static Singleton GetInstance()
    {
        if (Instance == null)
            return new Singleton();
        return Instance;
    }
}