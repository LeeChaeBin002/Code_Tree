using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s= Console.ReadLine().Split();
        int A = int.Parse(s[0]);
        int N = int.Parse(s[1]);

        for(int i =1; i<= N; i++)
        {
            Console.WriteLine(A+N);
            A += N;
        }

        // Please write your code here.
    }
}
