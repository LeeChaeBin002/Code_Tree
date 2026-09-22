using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int A =int.Parse(s[0]);
        int B = int.Parse(s[1]);

        int i = A;

        while(i <= B)
        {
            Console.Write($"{i} ");

            if(i % 2 ==1)
            {
                i *=2;
            }
            else
            {
                i +=3;
            }
        }
        
        
        }
        // Please write your code here.
    }

