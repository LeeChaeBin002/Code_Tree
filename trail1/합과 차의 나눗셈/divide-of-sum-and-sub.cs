using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts= s.Split();

        float a = float.Parse(parts[0]);
        float b = float.Parse(parts[1]);
        float result;
        result=(a+b)/(a-b);
        Console.WriteLine($"{result:F2}");
        // Please write your code here.
    }
}
