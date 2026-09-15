using System;

public class Codetree
{  
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] parts = s.Split();

        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);
        int c = int.Parse(parts[2]);

        int sum =a+b+c;
        int avg =(a+b+c)/3;
        int result=sum-avg;

        Console.WriteLine(sum);
        Console.WriteLine(avg);
        Console.WriteLine(result);
        // Please write your code here.
    }
}
