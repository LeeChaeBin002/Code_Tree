using System;

public class Codetree
{  
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int a = 0;
        
        for(int i = 1; i < N; i++)
        {
            if(N % i == 0)
            {
                a += i;
            }
        }
    
        if(N == a)
        {
            Console.WriteLine("P");
        }
        else
        {
            Console.WriteLine("N");
        }

    }
        // Please write your code here.
}
