using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if(n<0)
        {
            Console.WriteLine("ice");
        }
        else if(n>=100)
        {
            Console.WriteLine("vapor");
        }
        else
        {
            Console.WriteLine("water");

        }

        // Please write your code here.
    }
}
