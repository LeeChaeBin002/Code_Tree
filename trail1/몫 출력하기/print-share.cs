using System;

public class Codetree
{  
    public static void Main()
    {
        string input;
        while((input=Console.ReadLine())!= null)
        {
            int a = int.Parse(input);
            if(a % 2 != 0)
            {
                continue;
            }
            if(a % 2 == 0)
            {

            
            for(int i =0; i<3; i++)
            {
                a /=2;
                Console.WriteLine(a);
                break;
            }
            }
        }
        // Please write your code here.
    }
}
