using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string first = Console.ReadLine();
      
     
       
       Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine("Your name is {0}, {1}, {0}", last, first, last);
        // in this one "first" replaces the first ctnr {0} and "last" replaces the ctnr {1} which is the second

        Console.WriteLine($"Your name is {last}, {first}, {last}.");
        // start the string with a dollar sign and put the variable inside curly bracets

        Console.Write("How many letters has your first name?: ");
        int number1 = int.Parse(Console.ReadLine());


        Console.Write("How many Letters has your last name?: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

         // int.Parse(); and Convert.ToInt32(); are two different ways you can convert a string to int

         int result = number1 + number2;
        

        Console.WriteLine("Your name has "+ result  + " letters" );

        Console.ReadLine();

        
    }
}
// there are two ways to use variables inside strings: 
// number one: 
// {0} and {1} are containers of values that  replaced the variable strings we assign to the program
// is represented 0 as the fist element on the board, 1 as the sencond, and so on.. 
// when the variables are numbers we can also add the containers 
//example: if you assign two vaues int var2= 1 int var3= 2 you can add those cntrs and it will return the sum of both when u run the code
// Console.WriteLine("Your name is {0} {1}", first, last ) in this one "first" replaces the first ctnr {0} and "last" replaces the ctnr {1} which is the second
// should not be formatted with the "$" sign and it will work smoothly

// Number two: start the string with a dollar sign and put the variable inside curly bracets

      // The Console.ReadLine() method returns a string. 
      // Therefore, you cannot get information  from another data type, such as int
      // https://www.w3schools.com/cs/cs_user_input.php

      // every time you finish your code line you have to finish with a semicolon ";"