using System;
namespace testme;

// how would i setup a system test
// 1. Create a new test project
// 2. Add a reference to the project you want to test
// 3. Create a new test class
// 4. Create a new test method
// 5. Create an instance of the class you want to test
// 6. Call the method you want to test
// 7. Assert the result
// 8. Run the test
// 9. Check the result
// 10. Refactor the test


public class A 
{
    public static int f1(int x)
    {
        x = x + 1;
        return x;
    }
    
    internal static int f2(int x)
    {
        x = x + 2;
        return x;
    }
    
    protected static int f3(int x)
    {
        x = x + 3;
        return x;
    }
    
    private static int f4(int x)
    {
        x = x + 4;
        return x;
    }
    
    public static double f5(int x,int y)
    {
        return x/y;
    }
    
    public static int f6(int x)
    {
        if(x < 0)
        {
            throw new Exception("x can't be negative");
        }
        
        return x + 5;
    }
    
    public static string f7(string s)
    {
        var ss = s + " more stuff";
        return ss;
    }
    
    public int f8(int x)
    {
        // Assume this calls a sql database such as "selct * from where something = x"
        return x + 8;
    }
}

internal class B
{
    internal static int g1(int x,A a)
    {
        return a.f8(x);
    }
}


public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        var v1 = A.f1(1);
        var v2 = A.f2(2); 
        var v5 = A.f5(5,2);
        var v6 = A.f6(3);
        var v7 = A.f7("hello");
        var a = new A();
        var v8 = B.g1(1,a);
    }
}