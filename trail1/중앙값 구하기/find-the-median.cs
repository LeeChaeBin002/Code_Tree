using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);
        int C = int.Parse(s[2]);

        int median = (A + B + C) - Math.Max(A,Math.Max(B,C)) - Math.Min(A,Math.Min(B,C));

        Console.WriteLine(median);


        // Please write your code here.
    }
}
