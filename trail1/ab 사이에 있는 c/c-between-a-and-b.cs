using System;

public class Codetree
{  
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int c = int.Parse(s[2]);
        bool result =false;
        for(int i = a; i <= b; i++)
        {
            if(i % c == 0)
            {
                result = true;
                
            }
        }
            
            if(result == true) Console.WriteLine("YES");
            else
            {
                Console.WriteLine("NO");
                
            }

        
        
        // Please write your code here.
    }
}
