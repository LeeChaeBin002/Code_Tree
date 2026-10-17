using System;

public class Codetree
{  
    public static void Main()
    {
        int cnt = 0;
        int n = int.Parse(Console.ReadLine());
        while(n != 1)
        {
            if(n % 2 != 0)
            {
                n = n * 3 + 1;
                cnt++;
            }
            else if(n % 2 == 0)
            {
                n /= 2;
                cnt++;
            }
        
        }

        Console.WriteLine(cnt);
        // Please write your code here.
    }
}
