using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if(n>=3000)
        {
            Console.WriteLine("book");
        }
        else if(n >= 1000)
        {
            Console.WriteLine("mask");
        }
        else
        {
            Console.WriteLine("no");
        }

        // Please write your code here.
    }
}
