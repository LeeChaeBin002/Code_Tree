using System;

public class Codetree
{  
    public static void Main()
    {
        string[] p1 = Console.ReadLine().Split();
        string s1 = p1[0];
        int bt1 = int.Parse(p1[1]); 

        string[] p2 = Console.ReadLine().Split();
        string s2 = p2[0];
        int bt2 = int.Parse(p2[1]);

        string[] p3 = Console.ReadLine().Split();
        string s3 = p3[0];
        int bt3 = int.Parse(p3[1]);

        bool isA1 = (s1 =="Y" && bt1 >= 37);
        bool isA2 = (s2 == "Y" && bt2 >= 37);
        bool isA3 = (s3 == "Y" && bt3 >= 37);
            
        if((isA1 && isA2) || (isA1 && isA3) || (isA2 && isA3))
        {
            Console.WriteLine('E');
        }
        else
        {
            Console.WriteLine('N');
        }



        // Please write your code here.
    }
}
