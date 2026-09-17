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
        
        int Minvla = Math.Min(a,Math.Min(b,c));

        Console.WriteLine(Minvla);
        
        
        // Please write your code here.
    }
}
