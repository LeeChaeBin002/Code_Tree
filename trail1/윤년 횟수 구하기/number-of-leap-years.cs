using System;

public class Codetree
{  
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int cnt = 0;
        for(int i = 1; i <=N ; i++)
        {
            if(i % 4 == 0)
            {
                cnt++;
                if(i % 100 == 0 && i % 400 != 0)
                {
                    cnt--;
                }
            }
            else if(i % 4 != 0)
            {
                
            }   
        }
        Console.WriteLine(cnt);

        
        // Please write your code here.
    }
}
