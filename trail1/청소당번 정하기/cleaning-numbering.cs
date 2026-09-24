using System;

public class Codetree
{  
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cntClass = 0;
        int corridor = 0;
        int bathroom = 0;
        
        for(int i = 1; i <= n; i++)
        {
            if(i % 12 == 0)
            {
               bathroom++;
            }
            else if(i % 3 == 0)
            {
                corridor++;
            }
            else if(i % 2 == 0)
            {
                cntClass++;
            }
            
        }
            Console.WriteLine($"{cntClass} {corridor} {bathroom}");
        // Please write your code here.
    }
}
