using System;

public class Codetree
{  
    public static void Main()
    {
        char s =char.Parse(Console.ReadLine());

        if( s=='S')
        {
            Console.WriteLine("Superior");
        }
        else if(s == 'A')
        {
            Console.WriteLine("Excellent");
        }
        else if(s=='B')
        {
            Console.WriteLine("Good");
        }    
        else if(s=='C')
        {
            Console.WriteLine("Usually");
        }
        else if(s=='D')
        {
            Console.WriteLine("Effort");
        }
        else
        {
            Console.WriteLine("Failure");
        }

        // Please write your code here.
    }
}
