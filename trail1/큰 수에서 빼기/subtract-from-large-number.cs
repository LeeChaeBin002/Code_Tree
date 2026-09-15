using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts =s.Split();

        int A = int.Parse(parts[0]);
        int B = int.Parse(parts[1]);

        if(A<B)
        {
            Console.WriteLine(B-A);
        }
        else
        {
            Console.WriteLine(A-B);
        }
    

        // Please write your code here.
    }
}
