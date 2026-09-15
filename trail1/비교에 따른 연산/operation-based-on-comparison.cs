using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts = s.Split();

        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);

        if(a>b)
        {
            Console.WriteLine(a*b);
        }
        else
        {
             Console.WriteLine(b/a);
        }
        // Please write your code here.
    }
}
