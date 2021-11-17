using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    public class UC1_CreatBoard
    {

        char[] arr = new char[10];

        public void Board()
        {
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}