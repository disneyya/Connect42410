using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Connect4
{
    class Board

    {
        Player myPlayer = new Player();
        Token myToken = new Token();
        GameMaster myGameMaster = new GameMaster();
        int size = 10;
        int rowsTillBoard = 4;
        int spacesInBetweenBoard = 10;
        int spacesBeforeBeginingBoard = 5;
        int beginingTokenForDrop = 2; 
        public static String[,] board =
        {

            {"*","*","*","*","*","*","*"},
            {" "," "," "," "," "," "," "},
            {"*","*","*","*","*","*","*"},
            {" "," "," "," "," "," "," "},
            {"*","*","*","*","*","*","*"},
            {" "," "," "," "," "," "," "},
            {"*","*","*","*","*","*","*"},
            {" "," "," "," "," "," "," "},
            {"*","*","*","*","*","*","*"},
            {" "," "," "," "," "," "," "},
            {"*","*","*","*","*","*","*"}
        };


        public void displayTitle()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("                           C O N N E C T     F O U R\n\n        ");
        }

        internal void UpdateBoard(String playerID, int columnNumber)
        {
            var topCurserPosition = Console.CursorTop;
            var leftCurserPosition = Console.CursorLeft;
            for (int i = size; i >= 0; i--)
            {
                if (board[i, columnNumber - 1] == "*")
                {
                    board[i, columnNumber - 1] = playerID;

                    Thread.Sleep(150);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(spacesBeforeBeginingBoard + (columnNumber - 1) * spacesInBetweenBoard, (beginingTokenForDrop));//setsCursor to end of array prints off playerId whos turn it is
                                        
                    Thread.Sleep(150);
                    Console.SetCursorPosition(spacesBeforeBeginingBoard + (columnNumber - 1) * spacesInBetweenBoard, (i + rowsTillBoard));//setsCursor to end of array prints off playerId whos turn it is
                    myToken.drawToken(playerID);//calls drawToken method in Token.cs
                    
                    Console.BackgroundColor = ConsoleColor.Black;//sets background color to black
                    Console.ForegroundColor = ConsoleColor.White;//sets text color to white
                    Console.SetCursorPosition(leftCurserPosition, topCurserPosition - 2); // draws over text

                    
                    
                    return;

                }

            }

        }

        public void displayBoard()
        {
            Console.ForegroundColor = ConsoleColor.White;//sets text for column number white
            Console.BackgroundColor = ConsoleColor.Blue;// creates top of board sets it blue
            Console.WriteLine("      1         2         3         4         5         6         7      ");//creates column numbers before the board
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;//sets left side of board to blue
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("|");

                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;//sets lines in between rows to blue
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("-");//for extra spacing
                    Console.Write("|"); // creates lines in between rows
                    
                    if (board[i, j] == "*")
                    {
                        
                        Console.BackgroundColor = ConsoleColor.Black;//sets backGround of * in array to black
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.Write("     {0}  ", board[i, j]);
                }
                Console.BackgroundColor = ConsoleColor.Blue;//sets right side of board to blue
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("| ");//prints left side of the board
                Console.BackgroundColor = ConsoleColor.Black;//sets text below array to white and black background
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Blue;//sets bottom of board to blue
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ------------------------------------------------------------------------");//creates bottom of board
            Console.BackgroundColor = ConsoleColor.Black;//sets text back to white and black
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
