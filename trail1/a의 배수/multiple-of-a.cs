using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int a = int.Parse(s[1]);

        int i = 1;
        while( i <= N )
        {
            if(i % a == 0)
            {
                Console.WriteLine(1);
                i++;
            }
            else
            {
                Console.WriteLine(0);
                i++;
            }
        }
        
        // Please write your code here.
    }
}
