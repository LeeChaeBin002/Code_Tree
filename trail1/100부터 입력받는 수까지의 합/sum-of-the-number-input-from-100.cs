using System;

public class Codetree
{  
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int sum = 0 ;
        for(int i = N; i<=100; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
        // Please write your code here.
    }
}
