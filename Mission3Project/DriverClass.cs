using System;
using System.Collections.Generic;

namespace Mission3Project
{
    class DriverClass
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static void Main(string[] args)
        {
            // Welcome the user to the game
            Console.WriteLine("Welcome to the Tic-Tac-Toe Game Simulator!");
            // Create dictionary to hold places on the board
            Dictionary<int, string> GameBoard = new Dictionary<int, string>();
            // array of positions

            // preset the positions into the dictionary
            GameBoard.Add(1, " ");
            GameBoard.Add(2, " ");
            GameBoard.Add(3, " ");
            GameBoard.Add(4, " ");
            GameBoard.Add(5, " ");
            GameBoard.Add(6, " ");
            GameBoard.Add(7, " ");
            GameBoard.Add(8, " ");
            GameBoard.Add(9, " ");

            Console.WriteLine("For inputting moves, you can choose one of the following positions in the board (1, 2, 3)");
            Console.WriteLine("Reminder: You cannot take a spot already taken by another player.");
            Board();

            // loop for enter positions into the dictionary based on position from user input
            for (int i = 0; i < 4; i++)
            {
                // User Input for Game Position
                Console.WriteLine("Player1, where would you like to put your O? (1, 2, etc.)");
                int Player1Move = Convert.ToInt32(Console.ReadLine());
                // check if the space is available 
                GameBoard[Player1Move] = "O";
                UpdatedBoard();

                if (i <= 2)
                {
                    Console.WriteLine("Player2, where would you like to put your X? (1, 2, etc.)");
                    int Player2Move = Convert.ToInt32(Console.ReadLine());
                    GameBoard[Player2Move] = "X";
                    UpdatedBoard();
                }

                // call method to print resulting board
                // call method to determine who won
            }


            static void Board()
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
                Console.WriteLine("     |     |      ");
            }

             void UpdatedBoard()
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", GameBoard[1], GameBoard[2], GameBoard[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", GameBoard[4], GameBoard[5], GameBoard[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", GameBoard[7], GameBoard[8], GameBoard[9]);
                Console.WriteLine("     |     |      ");
            }
        }
    }
}
