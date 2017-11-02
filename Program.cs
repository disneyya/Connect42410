using System;
using System.Threading;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameDone = false;
            int dropChoice = 0;
            int playerTurnCounter = 1;

            Board myBoard = new Board();
            Player firstPlayer = new Player();
            Player secondPlayer = new Player();
            GameMaster myGameMaster = new GameMaster();
            int win;

            myBoard.displayTitle();
            myBoard.displayBoard();

            Console.WriteLine("Let's Play Connect 4");
            Console.WriteLine("Player One please enter your name: ");
            firstPlayer.playerName = Console.ReadLine();
            firstPlayer.playerID = "X";

            Console.WriteLine("Player Two please enter your name: ");
            secondPlayer.playerName = Console.ReadLine();
            secondPlayer.playerID = "O";

            while (gameDone != true)
            {
                if (playerTurnCounter % 2 != 0)
                {
                    Console.WriteLine("{0} Please enter a number between 1 and 7: ", firstPlayer.playerName);
                    try
                    {
                        dropChoice = Convert.ToInt32(Console.ReadLine());
                        

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Sorry {0} you must pick a number between 1 and 7", firstPlayer.playerName);
                        Console.WriteLine();
                        
                    }
                    myBoard.UpdateBoard(firstPlayer.playerID, dropChoice);
                    myGameMaster.CheckFour(Board.board, firstPlayer);


                }
                if (playerTurnCounter % 2 == 0)
                {
                    Console.WriteLine("{0} Please enter a number between 1 and 7: ", secondPlayer.playerName);
                    try
                    {
                        dropChoice = Convert.ToInt32(Console.ReadLine());
                        myBoard.UpdateBoard(secondPlayer.playerID, dropChoice);

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Sorry {0} you must pick a number between 1 and 7", secondPlayer.playerName);
                        Console.WriteLine();
                    }

                }
                playerTurnCounter++;

            }
        }
    }
}
