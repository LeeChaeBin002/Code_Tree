using System;

public class Codetree
{  
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i = 1; i<=100; i++)
        {
            sum += i;
            if(sum >= N) 
            { 
                Console.WriteLine(i);
                break;
            }
          // Please write your code here.
        }
    }
}
