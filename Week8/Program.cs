
using Week8;

class Program
{
    public static void Main()
    {
        var file = new FileResource("report.txt"); 
        var network = new NetworkResource("api.company.local");
    
        var manager = new ResourceManager<Resource>(); 

        // 1. Add resources to manager
        manager.Add(file);
        manager.Add(network);

        // 2. Open all resources 
        manager.OpenAll();

        // 3. Demonstrate using with one disposable resource 
        using (var res = new FileResource("file")) 
        {
            res.Open();
        } 

        // 4. Close all resources 
        manager.CloseAll();

        Console.WriteLine("Done."); 
    }
}