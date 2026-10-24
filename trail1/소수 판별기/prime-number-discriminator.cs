using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime= true;

        for(int i = 2; i < n; i++)
        {
            if(n % i == 0)
            {
                isPrime=false;
                break;
            }
                
        }
        
        if(isPrime)
        {
            Console.WriteLine("P");
        }
        else
        {
            Console.WriteLine("C");
        }

        // Please write your code here.
    }
}
