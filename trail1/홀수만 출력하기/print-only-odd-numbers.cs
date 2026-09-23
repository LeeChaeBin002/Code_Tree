using System;

public class Codetree
{  
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
      
        for (int i = 0; i < N; i++)
        {
            int val = int.Parse(Console.ReadLine());

            if(val % 2 == 1 && val % 3 == 0)
            {
                Console.WriteLine(val);
            }
        }
        

        // Please write your code here.
    }
}
