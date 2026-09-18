using System;

public class Codetree
{  
    public static void Main()
    {
        int Y =int.Parse(Console.ReadLine());

        if(Y % 4 == 0 && Y % 100 ==0 && Y % 400 !=0)
        {
           
             Console.WriteLine("false");

        }
        else if( Y % 4 == 0 )
            {
                Console.WriteLine("true");            
            }    
        else if(Y % 4 != 0)
        {
            Console.WriteLine("false");
        }
        
        // Please write your code here.
    }
}
