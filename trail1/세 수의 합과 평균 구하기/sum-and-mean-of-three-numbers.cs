using System;

public class Codetree
{  
    public static void Main()
    {
        string s =Console.ReadLine();
        string[] parts=s.Split(); 
        
        int A = int.Parse(parts[0]);
        int B = int.Parse(parts[1]);
        int C = int.Parse(parts[2]);

        int sum=A+B+C;
        int avg =(A+B+C)/3;

        Console.WriteLine($"{sum}");
        Console.WriteLine($"{avg}");

                // Please write your code here.
    }
}
