using System;

public class PingPong
{
    public static void Main()
    {
        Console.WriteLine("Lets play ping pong");
        Console.WriteLine("Please enter a number to play ping pong with.");
        string numberGiven = Console.ReadLine();
        int number = int.Parse(numberGiven);

        Console.WriteLine("Service!");
        for (int num = 0; num <= number; num++)
        {
            if (num % 5 == 0 && num % 10 == 0)
            {
                Console.WriteLine("Ping");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Pong");
            }
            else 
            {
                Console.WriteLine(num);
            }
        }
    }
}