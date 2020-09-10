using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Using Method Syntax)
            // Done - Create a list of video games.
            //Done List games by the length of the game name.
            //Done Order by length of the game name.
            //Use the lambda expression in this exercise as well.

            List<string> listOfGames = new List<string>() { "PacMan", "River Ride", "Enduro", "Fifa 2020", "Counter Of Strike" };
            //Console.WriteLine(listOfGames);

            var listOfGameLenght = listOfGames.OrderBy(x => x.Length);
            foreach (var x in listOfGameLenght)
            {
                Console.WriteLine(x);
            }

        }
    }
}
