using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int B = int.Parse(s[0]);
        int A = int.Parse(s[1]);
       

        while(A <= B)
        {
            Console.Write($"{B} ");
            B -= 2;
        }
        // Please write your code here.
    }
}
