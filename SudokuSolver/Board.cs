using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Board
    {
        public int[][] matrix { get; set; } = null;
        public string filePath { get; set; } = null;
        public int size { get; set; }

        public int subgridSize { get; set; }

        public Board(string filePath){
            
            this.filePath = filePath;
            this.FillMatrix();
            this.subgridSize = (int)Math.Sqrt((double)size);
        }

        public Board(int size)
        {
            this.size = size;
            matrix = new int[size][];
            for (int i = 0; i < size; i++)
            {
                matrix[i] = new int[size];
            }
            this.subgridSize = (int)Math.Sqrt((double)size);
        }

        private void FillMatrix()
        {
            // Check if the filePath is valid
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                Console.WriteLine("Invalid file path or file does not exist.");
                return;
            }

            // Read all lines from the text file
            string[] lines = File.ReadAllLines(filePath);

            int numRows = lines.Length;

            if (numRows == 0)
            {
                Console.WriteLine("The file is empty.");
                return;
            }
            size = numRows;

            matrix = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                string[] rowValues = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Check if the number of values in a row matches the determined size
                if (rowValues.Length != size)
                {
                    Console.WriteLine($"Invalid number of values in row {i + 1}.");
                    return;
                }

                matrix[i] = new int[size];

                for (int j = 0; j < size; j++)
                {
                    if (int.TryParse(rowValues[j], out int cellValue))
                    {
                        matrix[i][j] = cellValue;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid value at row {i + 1}, column {j + 1}.");
                        return;
                    }
                }
            }

            Console.WriteLine($"Matrix successfully loaded from the file. Size: {size}x{size}");
        }

        public void PrintBoard()
        {
            if (matrix == null)
            {
                Console.WriteLine("The Sudoku board has not been loaded yet.");
                return;
            }

            Console.WriteLine("Sudoku Board:");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }





    }
}
