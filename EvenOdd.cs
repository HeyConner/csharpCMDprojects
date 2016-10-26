using System;

class LeapYear
{
    static void Main()
    {
     Console.WriteLine("GIVE ME A NUMBER");
    string numberGiven = Console.ReadLine();
    int number = int.Parse(numberGiven);

    Console.WriteLine("Here are the even and odds up to your number.");
    for (int num = 0; num <= number; num ++)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine( num + " " + "Even");
        }
        else
        {
            Console.WriteLine(num + " " + "Odd");
        }
    }
    }
}