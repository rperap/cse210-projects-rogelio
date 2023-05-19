using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("enter value for y");
        // int y = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Enter your value for x ");
        // int x = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Enter your value for z");
        // int z = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter number; ");
        string valueFromUser= Console.ReadLine();    
        
        int x = int.Parse(valueFromUser);
        int y = 2;
        int z = 7;


        if (x > y && x > z)
        {
            
        
         Console.WriteLine($"{x} is greater than {y} and {z}");
            }

         else if (x < y)
        {
            Console.WriteLine($"{y} is greater than {x}");

        }    
        else 
        {
            Console.WriteLine($"{x} equals to {y}");
        }
    }
}