using System;

public class Codetree
{  
    public static void Main()
    {
        int M = int.Parse(Console.ReadLine());

        if(M >= 3 && M <= 5)
        {
            Console.WriteLine("Spring");
        }
        else if (M >= 6 && M <= 8)
        {
            Console.WriteLine("Summer");
        }
        else if (M >= 9 && M <= 11)
        {
            Console.WriteLine("Fall");
        }
        else if (M <=2 || M == 12)
        {
            Console.WriteLine("Winter");
        }

        // Please write your code here.
    }
}
