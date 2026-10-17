using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;
        while(n < 1000)
        {
            if(n % 2 == 0)
            {
                n = n * 3 + 1;
                cnt++;
            }
            else if(n % 2 !=0)
            {
                n = n * 2 + 2;
                cnt++;
            }
        }
        Console.WriteLine(cnt);
        // Please write your code here.
    }
}
