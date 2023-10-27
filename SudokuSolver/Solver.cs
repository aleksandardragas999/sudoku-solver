using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SudokuSolver
{
    public class Solver
    {
        public Board board { get; set; }

        public Solver(Board board)
        {
            this.board = board;
        }
        public void solveSudoku()
        {
            // Start solving sudoku from the first cell
            solve(board, 0, 0);
        }

        private bool solve(Board board, int row, int col)
        {
            // Base case: If row is equal to board length, entire board has been filled
            if (row == board.size)
            {
                return true;
            }

            // Move to next row when current row is fully filled
            if (col == board.size)
            {
                return solve(board, row + 1, 0);
            }

            // Skip cells that are already filled
            if (board.matrix[row][col] != 0)
            {
                return solve(board, row, col + 1);
            }

            // Try different numbers in current cell
            for (int num = 1; num <= board.size; num++)
            {
                if (isValidPlacement(board, row, col, num))
                {
                    board.matrix[row][col] = num; // Fill current cell with valid number

                    // Move to next cell
                    if (solve(board, row, col + 1))
                    {
                        return true;
                    }

                    // Backtrack to previous state if solution not found
                    board.matrix[row][col] = 0;
                }
            }

            // No valid solution found
            return false;
        }

        private bool isValidPlacement(Board board, int row, int col, int num)
        {
            // Check if num is already in the same row, column or subgrid
            for (int i = 0; i < board.size; i++)
            {
                // Check row
                if (board.matrix[i][col] == num)
                {
                    return false;
                }

                // Check column
                if (board.matrix[row][i] == num)
                {
                    return false;
                }

                // Check subgrid
                int subgridRow = board.subgridSize * (row / board.subgridSize) + i / board.subgridSize; // Calculate row index of subgrid
                int subgridCol = board.subgridSize * (col / board.subgridSize) + i % board.subgridSize; // Calculate column index of subgrid

                if (board.matrix[subgridRow][subgridCol] == num)
                {
                    return false;
                }
            }

            // Placement is valid
            return true;
        }
    }
}
