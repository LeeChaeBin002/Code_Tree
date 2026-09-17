using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts = s.Split();

        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);
        int c = int.Parse(parts[2]);

        int minval = Math.Min(a,Math.Min(b,c));

        if(a == minval)
        {
            Console.Write("1 ");

        }
        else
        {
            Console.Write("0 ");
        }
        if(a == b && a == c)
        {
            Console.Write('1');
        }
        else
        {
            Console.Write('0');        
            
        }
        // Please write your code here.
    }
}
