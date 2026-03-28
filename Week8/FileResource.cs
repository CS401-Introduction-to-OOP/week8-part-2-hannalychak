namespace Week8;

public class FileResource : Resource, IDisposable 
{
    public FileResource(string name) : base(name)
    {
    } 

    public override void Open() 
    {
        IsOpen = true;
        Console.WriteLine($"FileResource '{Name}' opened.");
    }

    public override void Close() 
    {
        IsOpen = false;
        Console.WriteLine($"FileResource '{Name}' closed."); 
    }

    public void Dispose() 
    {
        Close(); 
        Console.WriteLine($"FileResource '{Name}' disposed (diagnostic message).");
    }
}
