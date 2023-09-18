using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        //string - Strings (a sequence of characters, including letters, numbers, or symbols)
        string fname = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        //string - Strings (a sequence of characters, including letters, numbers, or symbols)
        string lname = Console.ReadLine();
        //use {curl brakets for variables inside of "quotes"} remember to add the $ before the qutoes for this as well.
        Console.WriteLine($"your name is {lname}, {fname} {lname}");
    }
}