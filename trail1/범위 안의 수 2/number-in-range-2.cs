using System;

public class Codetree
{  
    public static void Main()
    {
        int sum = 0;
        float avg = 0;
        int cnt = 0;
        for(int i = 1; i <= 10; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if(0 <= n && 200 >= n)
            {
                sum += n;
                cnt++;
                avg = (float)sum / cnt ; 
            }
        }
        
        Console.WriteLine($"{sum} {avg:F1}");
       
    }
}
