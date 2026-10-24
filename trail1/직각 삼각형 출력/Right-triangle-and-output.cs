using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            for(int j =0; j<2*i+1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        // Please write your code here.
    }
}
