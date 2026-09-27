using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);
        int mul = 1;

        for(int i = A; i <= B; i++)
        {
            mul *= i;
        }
        Console.WriteLine(mul);
        // Please write your code here.
    }
}
