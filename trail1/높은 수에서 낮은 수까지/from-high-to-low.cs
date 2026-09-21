using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int A =int.Parse(s[0]);
        int B = int.Parse(s[1]);

        if(A<B)
        {
           for(int i = B; i>=A; i--)
           {
             Console.Write($"{i} ");
           }
        }
        else if(A>B)
        {
            for(int i = A; i>=B; i--)
            {
             Console.Write($"{i} ");

            }

        }
        else if(A==B)
        {
              Console.Write(A);

        }
    
        // Please write your code here.
    }
}
