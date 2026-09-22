using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);

        if (0 < A)
        {
            for(int i = 1; i <= B;i++)
            {   
                Console.Write(A);
            }
        }
        else if(0 >= A)
            {
                Console.Write(0);
            }
        // Please write your code here.
    }
}
