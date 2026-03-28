namespace Week8;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> resources = new();

    public void Add(T resource)
    {
        resources.Add(resource);
    }

    public void OpenAll() 
    {
        foreach (var res in resources)
        {
            res.Open(); 
        }
    }

    public void CloseAll() 
    {
        foreach (var res in resources)
        {
            res.Close();
        }
    }
}