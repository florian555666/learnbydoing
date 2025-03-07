using System;

namespace ConsoleApp1
{
public class GameA
{
    public static void Play()
    {
     Console.WriteLine("Welcome to the game!");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Sorry, you are not old enough to play this game.");
                Console.WriteLine("Press any key to exit the game.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You are old enough to play this game.");
                Console.WriteLine("Press any key to start the game.");
                Console.ReadKey();
                Console.WriteLine("You are in a dark room.");
                Console.WriteLine("There is a door to your right and left.");
                Console.WriteLine("Which one do you take?");
                string choice = Console.ReadLine();
                if (choice == "left")
                {
                    Console.WriteLine("You find a treasure chest!");
                    Console.WriteLine("Press any key to open the chest.");
                    Console.ReadKey();
                    Console.WriteLine("You found a key!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.WriteLine("You leave the room and find yourself in a hallway.");
                    Console.WriteLine("There are three doors in front of you.");
                    Console.WriteLine("Which one do you take?");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "1")
                    {
                        Console.WriteLine("You find a room with a monster!");
                        Console.WriteLine("You are eaten by the monster.");
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("Press any key to exit the game.");
                        Console.ReadKey();
                    }
                    else if (choice2 == "2")
                    {
                        Console.WriteLine("You find a room with a chest!");
                        Console.WriteLine("You open the chest and find a sword!");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.WriteLine("You leave the room and find yourself in a hallway.");
                        Console.WriteLine("There are three doors in front of you.");
                        Console.WriteLine("Which one do you take?");
                        string choice3 = Console.ReadLine();
                        if (choice3 == "1")
                        {
                            Console.WriteLine("You find a room with a monster!");
                            Console.WriteLine("You use the sword to defeat the monster!");
                            Console.WriteLine("You find a key in the room!");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
        }
    }
}
 }
}
    }
}