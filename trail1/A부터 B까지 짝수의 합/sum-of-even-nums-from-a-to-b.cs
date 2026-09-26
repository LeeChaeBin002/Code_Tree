using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);
        int sum = 0;

        for(int i = A; i <= B; i++)
        {
            if(i % 2 == 0)
            {
                sum +=i;
            }
        }

        Console.WriteLine(sum);
        // Please write your code here.
    }
}
