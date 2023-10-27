using SudokuSolver;

Board b = new Board("input25x25.txt");
Solver s = new Solver(b);
s.solveSudoku();
s.board.PrintBoard();
