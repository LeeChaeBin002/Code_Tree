using System;

public class Codetree
{  
    public static void Main()
    {
        string[] arr = Console.ReadLine().Split();
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        int c = int.Parse(arr[2]);
        bool result = true;
        for(int i = a; i<=b; i++)
        {
            if(i % c == 0)
            {
                result = false;
                break;
            }
        }
        if(result==false)
        {
            Console.WriteLine("NO");
        }
        else
        {
            Console.WriteLine("YES");
        }
        // Please write your code here.
    }
}
