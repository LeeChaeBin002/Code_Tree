using System;

public class Codetree
{  
    public static void Main()
    {
        string s =Console.ReadLine();
        string[] parts=s.Split();

        int h = int.Parse(parts[0]);
        int w = int.Parse(parts[1]);

        float bmi= w/((h/100f)*(h/100f));

        Console.WriteLine($"{(int)bmi}");

        if(bmi>25)
        {
            Console.WriteLine($"Obesity");
        }
        // Please write your code here.
    }
}
