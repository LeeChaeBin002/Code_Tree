using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;
        int sum = 0;
        float avg = 0;
        for(int i = 1; i <= n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            cnt++;
            sum += a;
            avg = (float)sum / cnt;
        }
        Console.WriteLine($"{sum} {avg:F1}");
        // Please write your code here.
    }
}
