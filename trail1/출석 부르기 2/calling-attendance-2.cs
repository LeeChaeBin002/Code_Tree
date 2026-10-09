using System;

public class Codetree
{  
    public static void Main()
    {
        while(true)
        {
            int a = int.Parse(Console.ReadLine());

            if(a==1)
            {
                Console.WriteLine("John");
            }
            else if(a==2)
            {
                Console.WriteLine("Tom");
            }
            else if(a==3)
            {
                Console.WriteLine("Paul");
                
            }
            else if(a==4)
            {
                Console.WriteLine("Sam");
                
            }
            else
            {
                Console.WriteLine("Vacancy");
                break;
            }
        }
        // Please write your code here.
    }
}
