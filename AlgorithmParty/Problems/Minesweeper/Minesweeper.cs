using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Problems.Minesweeper
{
    public class Minesweeper
    {
        /*
         * Test Input
         * MineSweeper(4, 4, "*", ".", ".", ".", "*", ".", ".", ".", "*", ".", "*", ".", "*", ".", ".", ".");
         */

        public static Dictionary<int, int> bombCounters = new Dictionary<int, int>();

        private void MineSweeper(int col, int row, params string[] place)
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    var intpos = (i * 4) + j;
                    var pos = place[intpos];

                    if (pos == "*")
                    {
                        if (IsValidPosition(intpos - 1, row, false))
                        {
                            AddBombCounter(intpos - 1);
                        }

                        if (IsValidPosition(intpos + 1, row, true))
                        {
                            AddBombCounter(intpos + 1);
                        }

                        if (IsValidPosition(intpos + row + 1, row, true))
                        {
                            AddBombCounter(intpos + row + 1);
                        }

                        if (IsValidPosition(intpos + row - 1, row, false))
                        {
                            AddBombCounter(intpos + row - 1);
                        }
                    }
                }
            }

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    var intpos = (i * 4) + j;
                    var pos = place[intpos];

                    if (pos == "*")
                    {
                        Console.Write("*");
                    }
                    else if (bombCounters.ContainsKey(intpos))
                    {
                        var bombCount = bombCounters[intpos];

                        Console.Write(bombCount.ToString());
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }

                Console.WriteLine();
            }
        }

        private bool IsValidPosition(int position, int rows, bool isIncrement)
        {
            // check if position drop off line
            if (isIncrement && position % rows == 0)
            {
                return false;
            }

            if (!isIncrement && position % rows == 3)
            {
                return false;
            }

            return true;
        }

        private void AddBombCounter(int position, params string[] place)
        {
            if (bombCounters.ContainsKey(position))
            {
                bombCounters[position]++;
            }
            else
            {
                bombCounters.Add(position, 1);
            }
        }
    }
}
