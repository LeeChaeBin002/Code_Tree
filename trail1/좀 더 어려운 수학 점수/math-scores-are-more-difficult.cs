using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string s1 = Console.ReadLine();

        string[] parts = s.Split();
        string[] parts1 = s1.Split();

        int A1 = int.Parse(parts[0]);
        int A2 = int.Parse(parts[1]);
        int B1 = int.Parse(parts1[0]);
        int B2 = int.Parse(parts1[1]);


        if(A1 > B1 )
        {
            Console.WriteLine('A');
        }
        else if (A1 < B1)
        {
            Console.WriteLine('B');
        }
        else if (A1 == B1)//수학 점수 같음
        {
            if(A2 > B2)
            {
                Console.WriteLine('A');
            }
            else if(A2 < B2)
            {
                Console.WriteLine('B');
            }

        }
        // Please write your code here.
    }
}
