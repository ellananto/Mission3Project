using Mission3Project;
using System;
using System.Collections.Generic;

namespace Mission3Project
{
    public class SupportingClass
    {

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


        // method 
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

    }

}