using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts =s.Split();

        int m = int.Parse(parts[0]);
        int e = int.Parse(parts[1]);

        if(m >= 90 && e >= 95)
        {
            Console.WriteLine("100000");
        }
        else if (m >= 90 && e >=90)
        {
            Console.WriteLine("50000");
        }
        else
        {
            Console.WriteLine("0");
        }
        // Please write your code here.
    }
}
