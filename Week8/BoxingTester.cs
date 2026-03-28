namespace Week8;

public static class BoxingTester
{
    static void Test()
    {
        int a = 18; 

        // 1. Box a into object 
        object b = a; 
        
        // 2. Unbox back into int 
        int c = (int)b; 

        // 3. Print all values 
        Console.WriteLine($"Original int a: {a}");
        Console.WriteLine($"Boxed object b: {b}");
        Console.WriteLine($"Unboxed int c: {c}");
        
        // 4. Comments explaining what happens
        // боксінг відбувся на 7-10 строчці, типу значення а ми скопіювали зі стеку в новий обжект б, по суті створили екземпляр в хіп, кучі  
        // 13 строчка вже анбоксінг, в змінну с яка в стеку копіюється з хіпу значення змінної б 
    }
}
