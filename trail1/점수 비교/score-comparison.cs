using System;

public class Codetree
{  
    public static void Main()
    {
        string s =Console.ReadLine();
        string[] parts = s.Split();
        int A1 = int.Parse(parts[0]);
        int A2 = int.Parse(parts[1]);
        string s1 =Console.ReadLine();
        string[] parts1 = s1.Split();        
        int B1 = int.Parse(parts1[0]);
        int B2 = int.Parse(parts1[1]);

        if(A1 > B1 && A2 > B2)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }


        // Please write your code here.
    }
}
