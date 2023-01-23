using System;
using System.Collections.Generic;

namespace Mission3Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome the user to the game
            Console.WriteLine("Welcome to the Tic-Tac-Toe Game Simulator!");
            // Create dictionary to hold places on the board
            Dictionary<string, string> GameBoard = new Dictionary<string, string>();

            // preset the positions into the dictionary
            GameBoard.Add("TOP LEFT", "");
            GameBoard.Add("TOP MIDDLE", "");
            GameBoard.Add("TOP RIGHT", "");
            GameBoard.Add("MIDDLE LEFT", "");
            GameBoard.Add("MIDDLE MIDDLE", "");
            GameBoard.Add("MIDDLE RIGHT", "");
            GameBoard.Add("BOTTOM LEFT", "");
            GameBoard.Add("BOTTOM MIDDLE", "");
            GameBoard.Add("BOTTOM RIGHT", "");

            Console.WriteLine("For inputting moves, you can choose one of the following: Top Left, Top Middle, Top Right\n Middle Left, Middle Middle, Middle Right\n Bottom Left, Bottom Middle, Bottom Right ");
            Console.WriteLine("You cannot take a spot already taken by another player.");


            // loop for enter positions into the dictionary based on position from user input
            for (int i = 0; i < 4; i++)
            {
                // User Input for Game Position
                Console.WriteLine("Player1, where would you like to put your O? (Top Left, etc.)");
                string Player1Move = Console.ReadLine().ToUpper();
                GameBoard[Player1Move] = "O";

                if (i <= 2)
                {
                    Console.WriteLine("Player2, where would you like to put your X (Top Left, etc.)");
                    string Player2Move = Console.ReadLine().ToUpper();
                    GameBoard[Player2Move] = "X";
                }

                // call method to print the board
                // call method to determine who won
            }



        }
    }
}
