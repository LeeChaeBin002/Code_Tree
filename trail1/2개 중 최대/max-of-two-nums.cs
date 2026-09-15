using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts = s.Split();

        int A = int.Parse(parts[0]);
        int B = int.Parse(parts[1]);
        int C;
        C = A > B ? A : B; 
        Console.WriteLine(C);
        // Please write your code here.
    }
}
