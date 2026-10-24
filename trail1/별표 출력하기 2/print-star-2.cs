using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            for(int j = n; j >= i; j--)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        // Please write your code here.
    }
}
