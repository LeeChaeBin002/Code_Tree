using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);
        int sum = 0;

        if(A <= B)
        {
            for(int i = A; i <= B; i++)
            {
                if(i % 5 == 0)
                {
                    sum += i;
                }
            }
        }
        else if(A >= B)
        {
            for(int i = B; i <= A; i++)
            {
                if(i % 5 == 0)
                {
                    sum += i;
                }
            }
        }

        Console.WriteLine(sum);
        
    }
        
}
