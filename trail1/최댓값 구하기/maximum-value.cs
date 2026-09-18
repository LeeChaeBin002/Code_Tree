using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts = s.Split();

        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);
        int c = int.Parse(parts[2]);

        int maxval = Math.Max(a,Math.Max(b,c));

        Console.WriteLine(maxval);
        // Please write your code here.
    }
}
