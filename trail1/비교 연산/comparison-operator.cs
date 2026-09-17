using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts = s.Split();

        int A = int.Parse(parts[0]);
        int B = int.Parse(parts[1]);

        if(A >= B)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }
        if(A > B)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }
        if(A <= B)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }
        if(A < B)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }
        if(A == B)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }
        if(A != B)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }            // Please write your code here.
    }
}
