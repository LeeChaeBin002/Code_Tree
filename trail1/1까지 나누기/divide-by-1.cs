using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;
        int i = 1;
        while(n > 1)
        {
           cnt++;
           n = n / i;
           i++;
        }
        Console.WriteLine(cnt);
        
        // Please write your code here.
    }
}
