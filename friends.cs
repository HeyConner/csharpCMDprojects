using System;

class Friend
{
    static void Main()
    {
        string[] myFriends = {"Conner", "Wilson", "Brock", "Ben", "Ryan"};

        Console.WriteLine("Here are some of my friends: ");
        foreach (string friends in myFriends)
        {
            Console.WriteLine(friends + " " + "is my friend.");
        }
    }
}