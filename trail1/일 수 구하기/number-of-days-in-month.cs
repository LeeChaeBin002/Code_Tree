using System;

public class Codetree
{  
    public static void Main()
    {
        int n =int.Parse(Console.ReadLine());

        if(n % 2 == 1 && n<=7)
        {
            Console.WriteLine("31");
        }
        else if( n == 2)
        {
            Console.WriteLine("28");
        }
        else if(n % 2 == 0 && n<=7)
        {
            Console.WriteLine("30");
        }
        else if(n % 2 == 0 && n>=8)
        {
            Console.WriteLine("31");
        }
        else if(n % 2 == 1 && n>=8)
        {
            Console.WriteLine("30");
        }
        // Please write your code here.
    }
}
