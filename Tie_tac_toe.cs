using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Tie_tac_toe
    {
        
            public void choose()
            {
                Console.WriteLine("Player 1 - Choose the letter 'X' OR 'O'");
                string l1 = Console.ReadLine();


                if (l1 == "X")
                {
                    Console.WriteLine("Player 1 is using 'X'");
                    Console.WriteLine("Player 2 is using 'O'");
                }
                else
                {
                    Console.WriteLine("Player 1 is using 'O'");
                    Console.WriteLine("Player 2 is using 'X'");
                }
            }
        }
    }

