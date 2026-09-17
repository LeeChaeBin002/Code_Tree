using System;

public class Codetree
{  
    public static void Main()
    {
        int A = int.Parse(Console.ReadLine());

        if(A % 3 ==0 || A % 5 == 0)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }
        // Please write your code here.
    }
}
