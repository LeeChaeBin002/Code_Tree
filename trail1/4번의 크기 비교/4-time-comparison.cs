using System;

public class Codetree
{  
    public static void Main()
    {  
        int A = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        string[] parts = s.Split();
        int B = int.Parse(parts[0]);
        int C = int.Parse(parts[1]);
        int D = int.Parse(parts[2]);
        int E = int.Parse(parts[3]);

        if(A > B)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }
        if(A > C)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }  
        
        if(A > D)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }       
        if(A > E)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }
        
        }            // P    }
}
