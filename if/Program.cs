using System;

class Program
{
    public static void Main()
    {
        int a = 10, b = 20, c = 30;
        
        // if statement
        if (a < b && b < c) Console.WriteLine("a<b<c");
        else if (b < a && a < c) Console.WriteLine("b<a<c");
        else if (c < a && a < b) Console.WriteLine("c<a<b");
        else Console.WriteLine("No condition met");


     
    }

}


