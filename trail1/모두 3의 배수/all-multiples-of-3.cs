using System;

public class Codetree
{  
    public static void Main()
    {
        bool multiple = true;
        for(int i = 0; i < 5; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if(n % 3 != 0)
            {
                multiple=false;
            
            }
           
            
        }
            if(multiple)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        
        // Please write your code here.
    }
}
