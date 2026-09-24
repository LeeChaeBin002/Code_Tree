using System;

public class Codetree
{  
    public static void Main()
    {       
        
        int cnt1 = 0;
        int cnt2 = 0;
        for(int i = 0; i < 10; i++)
        {
            int n = int.Parse(Console.ReadLine());
            
            if(n % 3 == 0)
            {
                cnt1++;
            }
            if(n % 5 == 0)
            {
                cnt2++;
            }
        }
            Console.WriteLine($"{cnt1} {cnt2}");
        

        // Please write your code here.
    }
}
