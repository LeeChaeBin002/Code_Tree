using System;

public class Codetree
{  
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for(int i = 1; i <= N; i++)
        {
            string s = i.ToString();
            
                if ( i % 3 == 0 || s.Contains("3") || s.Contains("6") || s.Contains("9"))
                {
                    Console.Write($"0 ");
                }
                
                else
                {
                    Console.Write($"{i} ");
                }
        
        }
        // Please write your code here.
    }
}
