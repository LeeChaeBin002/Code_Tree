using System;

public class Codetree
{  
    public static void Main()
    {
        int cnt = 0;

        for(int i = 1; i <= 5;i++)
        {
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                cnt++;
            }
        }

        Console.WriteLine(cnt);
    }
        // Please write your code here.
}
