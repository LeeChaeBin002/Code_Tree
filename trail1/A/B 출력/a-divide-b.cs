using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s =Console.ReadLine().Split();
        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);
        float n;

    
        Console.Write($"{A / B}." );
        A = A % B;
        for(int i = 1; i<21; i++)
        {
            A *=10;
            Console.Write(A / B);
            A = A % B;
        }
        
        // Please write your code here.
    }
}
