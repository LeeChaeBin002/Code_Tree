using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s =Console.ReadLine().Split();
        int N = int.Parse(s[1]);

        if(s[0] == "A")
        {
            for(int i = 1; i <= N; i++)
            {
                Console.Write($"{i} ");
            }
        }
        else if(s[0] =="D")
        {
            for(int i = N; 1 <= i; i--)
            {   
                Console.Write($"{i} ");
            }
        }

        // Please write your code here.
    }
}
