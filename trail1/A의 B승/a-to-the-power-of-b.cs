using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);
        int pow = 1;
        for (int i = 0; i < B; i++)
        {
                pow *= A;
        }
        Console.WriteLine(pow);
        // Please write your code here.
    }
}
