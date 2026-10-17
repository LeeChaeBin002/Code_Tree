using System;

public class Codetree
{  
    public static void Main()
    {
        float avg = 0;
        int total= 0;
        int cnt =0;
        while(true)
        {
            int a = int.Parse(Console.ReadLine());
            
            if(a>= 30 || a < 20) break;
            cnt++;
            total += a;
        }
        avg = (float)total / cnt;
        Console.WriteLine($"{avg:F2}");
        // Please write your code here.
    }
}
