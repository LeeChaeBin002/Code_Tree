using System;

public class Codetree
{  
    public static void Main()
    {
        int[] arr = new int[100];
        int idx = 0;
        while(true)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            string c = s[2];

            arr[idx] = a * b;
            idx++;
            if (c == "C") 
            {
                break;
            }
        }

        for (int i = 0; i < idx; i++)
        {
            Console.WriteLine(arr[i]);
        }
        // Please write your code here.
    }
}
