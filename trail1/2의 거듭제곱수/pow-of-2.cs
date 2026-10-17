using System;

public class Codetree
{  
    public static void Main()
    {
        int n =int.Parse(Console.ReadLine());
        int cnt = 0;
        for(int i = 2; i <= n;i*=2)
        {
            cnt++;
        }
        Console.WriteLine(cnt);
        
        // Please write your code here.
    }
}
