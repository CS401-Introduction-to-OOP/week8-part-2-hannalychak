using Week8;
class Program
{
    public static void Main()
    {
        // Value type demo
        Point p1 = new Point { X = 1, Y = 2 }; 
        Point p2 = p1; 

        // Modify p2 and print both p1 and p2 
        p2.X = 18; 
        Console.WriteLine("Struct Behavior");
        p1.Print();
        p2.Print(); 

        //Reference type demo
        PointRef r1 = new PointRef { X = 1, Y = 2 }; 
        PointRef r2 = r1; 

        // Modify r2 and print both r1 and r2 
        r2.X = 18;
        Console.WriteLine("Class Behavior");
        r1.Print(); 
        r2.Print(); 

        //Boxing demo
        Console.WriteLine("Boxing & Unboxing");
        BoxingTester.Test();
    }
    
}