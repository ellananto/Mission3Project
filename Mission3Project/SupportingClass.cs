using Mission3Project;
using System;
using System.Collections.Generic;


namespace Mission3Project
{
    public class SupportingClass
    {

        // display in-play board, each dictionary spot will hold a players spot selection
        public void UpdatedBoard(Dictionary<int, string> dict)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", dict[1], dict[2], dict[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", dict[4], dict[5], dict[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", dict[7], dict[8], dict[9]);
            Console.WriteLine("     |     |      ");

        }


        // display intial board method 
        public void Board(Dictionary<int, string> dict)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  1  |  2  |  3");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  4  |  5  |  6");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  7  |  8  |  9");
            Console.WriteLine("     |     |      ");
        }

        // Create a Method that signals a winner

        public int WinnerWinnerChickenDinner(Dictionary<int, string> dict)
        {
            bool isTie = true;
            // Horizontal winning combos
            if (dict[1] == dict[2] && dict[2] == dict[3])
            { 
                return 1;
            }
            else if (dict[4] == dict[5] && dict[5] == dict[6])
            {
                return 1;
            }
            else if (dict[7] == dict[8] && dict[8] == dict[9])
            {
                return 1;
            }
            // Vertical winning combos
            else if (dict[1] == dict[4] && dict[4] == dict[7])
            {
                return 1;
            }
            else if (dict[2] == dict[5] && dict[5] == dict[8])
            {
                return 1;
            }
            else if (dict[3] == dict[6] && dict[6] == dict[9])
            {
                return 1;
            }
            // Diagonal Winning combos
            else if (dict[1] == dict[5] && dict[5] == dict[9])
            {
                return 1;
            }
            else if (dict[3] == dict[5] && dict[5] == dict[7])
            {
                return 1;
            }
            // Check for tie
            else
            {
                for (int i = 0; i < dict.Count; i++)
                {
                    if (dict[i] != "O" && dict[i] != "X")
                    {
                        isTie = false;
                    }
                }
                if (isTie)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        

    }

}