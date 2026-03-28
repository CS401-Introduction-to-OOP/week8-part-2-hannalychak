namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }

    public override void Open() 
    {
        IsOpen = true;
        Console.WriteLine($"NetworkResource '{Name}' opened."); 
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"NetworkResource '{Name}' closed.");
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine($"NetworkResource '{Name}' disposed (diagnostic message)."); 
    }
}
