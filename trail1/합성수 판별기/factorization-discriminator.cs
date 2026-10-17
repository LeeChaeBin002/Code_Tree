using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool f =false;
        for(int i = 2; i < n; i++)
        {
           if(n % i == 0)
           {
                f=true;
           } 
        }

        if(f==true)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("N");
        }
        
        // Please write your code here.
    }
}
