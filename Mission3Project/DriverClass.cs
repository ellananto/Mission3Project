using System;
using System.Collections.Generic;

namespace Mission3Project
{

    class DriverClass
    {  
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static void Main(string[] args)
        {
            // Welcome the user to the game
            Console.WriteLine("Welcome to the Tic-Tac-Toe Game Simulator!");
            // Create dictionary to hold places on the board
            Dictionary<int, string> GameBoard = new Dictionary<int, string>();

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

            // Getting a "supporting" object from the SupportingClass
            SupportingClass supporting = new SupportingClass();

            // Using the Board method
            supporting.Board(GameBoard);

            int checkWin = 0;

            // loop for enter positions into the dictionary based on position from user input
            do
            {
                // User Input for Game Position
                Console.WriteLine("Player 1, where would you like to put your O? (1, 2, etc.)");
                int Player1Move = Convert.ToInt32(Console.ReadLine());
                GameBoard[Player1Move] = "O";
                supporting.UpdatedBoard(GameBoard);
                checkWin = supporting.WinnerWinnerChickenDinner(GameBoard);

                // user input for the game position
                Console.WriteLine("Player 2, where would you like to put your X? (1, 2, etc.)");
                int Player2Move = Convert.ToInt32(Console.ReadLine());
                GameBoard[Player2Move] = "X";
                supporting.UpdatedBoard(GameBoard);
                checkWin = supporting.WinnerWinnerChickenDinner(GameBoard);

            }

            while (checkWin != -1 && checkWin != 1);

            // call method to print resulting board
            Console.WriteLine("This is the final board.");
            supporting.UpdatedBoard(GameBoard);

            // call method to determine who won

        }

        // outline of the board with numeric positions

    }
}
