using System;

public class Codetree
{  
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for(int i = N; i <= 100; i++ )
        {

            if(90 <= i)
            {
                Console.Write("A ");
            }
            else if(80 <= i)
            {
                Console.Write("B ");
            }   
            else if(70 <= i)
            {
                Console.Write("C ");
            } 
            else if(60 <= i)
            {
                Console.Write("D ");
            } 
            else
            {
                Console.Write("F ");
            } 
        }
        // Please write your code here.
    }
}
