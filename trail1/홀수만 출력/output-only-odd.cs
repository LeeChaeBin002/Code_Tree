using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);

        for(int i = A; i <= B ; i+=2)
        {
            Console.Write($"{i} ");
        }
        // Please write your code here.
    }
}
