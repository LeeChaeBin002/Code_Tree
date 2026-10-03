using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cnt = 1;

        for(int i=1; i<=10; i++)
         {
            cnt *= i;
            if(cnt >= n)
            {
              Console.WriteLine(i);
              break;

            }
         }
        // Please write your code here.
    }
}
