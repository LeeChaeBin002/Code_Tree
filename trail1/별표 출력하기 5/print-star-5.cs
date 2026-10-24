using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

      
            for(int i = 0; i < n; i++)
            {

            for(int z = 0; z < n-i; z++)
            {

            
                for(int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" ");
            }
              Console.WriteLine();
            }
            
        
        // Please write your code here.
    }
}
