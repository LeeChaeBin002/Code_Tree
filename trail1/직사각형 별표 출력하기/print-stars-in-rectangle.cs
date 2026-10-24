using System;

public class Codetree
{  
    public static void Main()
    {
        string[] arr = Console.ReadLine().Split();
        int n = int.Parse(arr[0]);
        int m = int.Parse(arr[1]);
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        // Please write your code here.
    }
}
