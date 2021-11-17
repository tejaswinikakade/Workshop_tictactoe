using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Play the game TIC_TAC_TOE");
            UC1_CreatBoard uc1 = new UC1_CreatBoard();
            uc1.Board();
        }
    }
}
