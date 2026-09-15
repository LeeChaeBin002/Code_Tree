using System;

public class Codetree
{  
    public static void Main()
    {
        int score = int.Parse(Console.ReadLine());
        string result;

        result = score == 100 ? "pass" : "failure";

        Console.WriteLine(result);
        // Please write your code here.
    }
}
