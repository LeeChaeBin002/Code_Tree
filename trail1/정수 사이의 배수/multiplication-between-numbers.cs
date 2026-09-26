using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);
        int sum = 0;
        int cnt = 0;
        float avg = 0;
        for(int i = A; i <= B; i++)
        {
            if(i % 5 == 0 || i % 7 == 0)
            {
                cnt++;
                sum += i;
            } 
        }
            avg = (float)sum / cnt ;
            
        Console.WriteLine($"{sum} {avg:F1}");
    }
}
