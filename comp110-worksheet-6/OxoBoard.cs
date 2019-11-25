﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp110_worksheet_6
{
	public enum Mark { None, O, X };

	public class OxoBoard
	{
        Mark[,] borad;
		// Constructor. Perform any necessary data initialisation here.
		// Uncomment the optional parameters if attempting the stretch goal -- keep the default values to avoid breaking unit tests.
		public OxoBoard( int width = 3, int height = 3, int inARow = 3)
		{
            borad = new Mark[width,height];
		}

		// Return the contents of the specified square.
		public Mark GetSquare(int x, int y)
		{
            return borad[x, y];
		}

		// If the specified square is currently empty, fill it with mark and return true.
		// If the square is not empty, leave it as-is and return False.
		public bool SetSquare(int x, int y, Mark mark)
		{
			if(x < borad.GetLength(0) && y < borad.GetLength(1))
            {
                if (borad[x,y] == Mark.None)
                {
                    borad[x, y] = mark;
                    return true;
                }
            }

            return false;
		}

		// If there are still empty squares on the board, return false.
		// If there are no empty squares, return true.
		public bool IsBoardFull()
		{
            for (int p = 0; p < borad.GetLength(0); p++)
            {
                for (int j = 0; j < borad.GetLength(1); j++)
                {
                    if (borad[p,j] == Mark.None)
                    {
                        return false;
                    }
                }
            }
            return true;
		}

		// If a player has three in a row, return Mark.O or Mark.X depending on which player.
		// Otherwise, return Mark.None.
		public Mark GetWinner()
		{
			foreach(Mark mark in new Mark [Mark.O, Mark.X])
                {
                    if (DiagonalCheck1(mark) || DiagonalCheck2(mark))
                {
                    return mark;
                }

            for (int p = 0; p < borad.GetLength(0); p++)
            {
                if (HorizontalCheck(Mark,i) || VerticalCheck(Mark,i))
                {
                    return mark;
                }
            }
        return Mark.None;

		}


            public bool HorizontalCheck(Mark , mark , int y)
        {
            for (int x = 0; x < borad.GetLength(0); x++)
            {
                if (borad[x,y] != mark)
                {
                    return false;
                }
                    return true;
            }
            

        }

        public bool VerticalCheck(Mark, Mark, int x)
        {
            for (int y = 0; y < borad.GetLength(1); y++)
            {
                if (borad[x,y] != mark)
                {
                    return false;
                }
            }
            return true;
        }

            public bool DiagonalCheck1(Mark, mark)
        {
            for (int p = 0; p < borad.GetLength(0); p++)
            {
                if(borad[p,j] != mark)
                {
                    return false;
                }
            }
            return true;
        }

            public bool DiagonalCheck2(Mark, mark)
        {
            for(int j = 0; j < borad.GetLength(0);j++)
            {
                if (borad[borad.GetLength(0) - 1 -j, j] != mark)
                {
                    return false;
                }
            }
            return true;
        }
        public bool Dig
private Mark mark;

        // Display the current board state in the terminal. You should only need to edit this if you are attempting the stretch goal.
        public void PrintBoard()
		{
			for (int y = 0; y < 3; y++)
			{
				if (y > 0)
					Console.WriteLine("--+---+--");

				for (int x = 0; x < 3; x++)
				{
					if (x > 0)
						Console.Write(" | ");

					switch (GetSquare(x, y))
					{
						case Mark.None:
							Console.Write(" "); break;
						case Mark.O:
							Console.Write("O"); break;
						case Mark.X:
							Console.Write("X"); break;
					}
				}

				Console.WriteLine();
			}
		}
	}
}

