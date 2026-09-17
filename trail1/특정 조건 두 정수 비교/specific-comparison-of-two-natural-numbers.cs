using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts = s.Split();

        int A = int.Parse(parts[0]);
        int B = int.Parse(parts[1]);
        int r1;
        int r2;

        if(A < B)
        {
            r1 = 1;
        }
        else
        {
            r1 = 0;
        }
        if(A == B)
        {
            r2 = 1;
        }
        else
        {
            r2 = 0;
        }

        Console.WriteLine($"{r1} {r2}");
        // Please write your code here.
    }
}
