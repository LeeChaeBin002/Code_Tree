using System;

public class Codetree
{  
    public static void Main()
    {
        int sex = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());

        if(sex == 0)
        {
            if(age >=19)
            {
                Console.WriteLine("MAN");
            }
            else
            {
                Console.WriteLine("BOY");
            }
        }
        else if(sex == 1)
        {
            if(age>=19)
            {
                Console.WriteLine("WOMAN");
            }
            else
            {
                Console.WriteLine("GIRL");
            }
        }
        
        
        // Please write your code here.
    }
}
