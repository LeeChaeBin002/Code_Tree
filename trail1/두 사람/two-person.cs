using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts = s.Split();
        string s1 = Console.ReadLine();
        string[] parts1 = s1.Split();

        int age = int.Parse(parts[0]);
        int age1 = int.Parse(parts1[0]);


        if((age>=19 && parts[1]=="M") || (age1>=19 && parts1[1]=="M"))
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
