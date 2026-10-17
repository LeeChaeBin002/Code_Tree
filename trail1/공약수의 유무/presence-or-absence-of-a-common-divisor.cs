using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        bool f = false;
        for(int i = a; i<=b; i++)
        {
            if(1920 % i == 0 && 2880 % i == 0)
            {
                f=true;
            }
        }
        if(f==true)
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
