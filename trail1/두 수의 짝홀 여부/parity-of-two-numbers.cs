using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts = s.Split();

        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);
                
        if(a % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else if (a % 2 == 1)
        {
            Console.WriteLine("odd");
        }
        if(b % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else if (b % 2 == 1)
        {
            Console.WriteLine("odd");
        }        // Please write your code here.
    }
}
