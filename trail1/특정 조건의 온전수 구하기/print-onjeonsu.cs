using System;

public class Codetree
{  
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int cnt = 0;
        for(int i = 1; i <= N; i++)
        {
            if(i % 2 == 0) continue;

            if( i % 10 == 5) continue;

            if(i % 3 == 0 && i % 9 != 0) continue;
            
                Console.Write(i+" ");
            
        }
        // Please write your code here.
    }
}
