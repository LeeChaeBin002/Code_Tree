using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i = 1; i <= n; i++)
        {
            int val = int.Parse(Console.ReadLine());

            if(val % 2 != 0 && val % 3 == 0)
            {
                sum += val;
            }
        }
        Console.WriteLine(sum);
        // Please write your code here.
    }
}
