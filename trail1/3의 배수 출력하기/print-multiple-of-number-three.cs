using System;

public class Codetree
{  
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int i = 1;
        
        while(i * 3 <= N)
        {
            
            Console.Write($"{i * 3} ");
            i++;
        }
        // Please write your code here.
    }
}
