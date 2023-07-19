public class Counter
{
    private static Counter instance;
    private static int count;

    // Private constructor to prevent direct instantiation
    private Counter()
    {
        // Initialize count to 0
        count = 0;
    }

    // Static constructor to ensure thread-safe lazy initialization
    static Counter()
    {
        instance = new Counter();
    }

    public static Counter GetInstance()
    {
        return instance;
    }

    public void Increment()
    {
        count++;
    }

    public void Decrement()
    {
        count--;
    }

    public int Count
    {
        get { return count; }
    }
}
