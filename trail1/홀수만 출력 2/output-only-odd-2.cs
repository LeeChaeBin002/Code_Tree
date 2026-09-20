using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s= Console.ReadLine().Split();
        int B = int.Parse(s[0]);
        int A = int.Parse(s[1]);

        for(int i = B; A <= i; i--)
        {
            if( i % 2 != 0)
            {

                Console.Write($"{i} ");
            }
        }
        // Please write your code here.
    }
}
