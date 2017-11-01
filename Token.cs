using System;
using System.Collections.Generic;
using System.Text;

namespace Connect4
{
    class Token
    {


        internal void drawToken(String playerId)
        {
            if(playerId == "X")
            {
                Console.BackgroundColor = ConsoleColor.Red;//makes X red instead of char
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" X ");//prints the playerId to array
                
            }

            if (playerId == "O")
            {
                Console.BackgroundColor = ConsoleColor.Yellow; //makes O Yellow instead of char
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" O ");//prints the playerId to array
            }
        }
    }
}
