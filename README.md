
   


#Sudoku Solver

Implementation of the principle of backtracking algorithm for SudokuSolver in C# in Visual Studio 2022.



#Introduction
	
	*Sudoku Solver is a C# application that can solve "Sudoku puzzles" in different ways:

		- Solve Sudoku puzzles of different levels of difficulty (examples shown for 9x9, 16x16 and 25x25)
		- Generate a solution for a Sudoku puzzle
		- Confirming the accuracy of the Sudoku grid
		- Displayed puzzle solution
		- Fast and efficient solving algorithm (backtracking recursion algorithm)

#Installation

	1."Clone the repository:"
		git clone https://github.com/aleksandardragas999/sudoku-solver.git 
	2.**Navigate to the project directory:**
		

#Usage

*Terminal:
	1.Open a Terminal:
		Open your preferred terminal application (e.g., PowerShell, Command Prompt, or a terminal in Visual Studio Code).
	
	2.Navigate to Your Project Directory:
		Use the cd (change directory) command to navigate to the directory where your C# console application project is located. For example:
		bash
		(cd path\to\your\project\directory)

	3.Position in project
		cd SudokuSolver	

	4.Build the Project:
		The next command for build C# console app is:
		
		dotnet build
	
	4.Check Build Results:
		The terminal will display build messages, and you should look for any errors or warnings. If there are issues, you need to address them by fixing the code in your project.

	5.Successful Build:
		If the build is successful, you'll see a message indicating that the build succeeded.
	
	6.In my example
		Position in foleder(bin->Debug->net7.0)

	7.Finally
		dotnet SudokuSolver.dll
	
	8.View Output:
		The console window will appear, displaying the output of your C# console application.

HINT:
	My test examples are located in the following folders:
		1. SudokuSolver
		2. bin folder
		3. Debug folder
		4. net7.0
		5.Name of .txt files for testing(
						 input9x9.txt
						 input16x16.txt
						 *For testing create txt. file with matrix you want and add in 
						 Program.cs input  
						)
		If you want to add a new test txt. file, you only need to add the path to that file in the Program.cs class.

Good luck and enjoy Sudoku Solver in C#