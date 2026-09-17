using System;

public class Codetree
{  
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        if(a % 13 == 0 || a % 19 ==0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }


        // Please write your code here.
    }
}
