using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts = s.Split();

        float A = float.Parse(parts[0]);
        float B = float.Parse(parts[1]);
        float avg = (A+B)/2;
        float sum =A+B;
        Console.WriteLine($"{sum} {avg:F1}");
        // Please write your code here.
    }
}
