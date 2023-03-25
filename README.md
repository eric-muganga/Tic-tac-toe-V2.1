# Tic-tac-toe-V2.1
Created By Muganga Eric

Tic Tac Toe Game Documentation
Overview
The program is a console-based game of Tic Tac Toe that allows two players to take turns marking the spaces on a 3 x 3 board with their assigned symbols (X or O). A player wins the game if they place three of their symbols in a horizontal, vertical, or diagonal row, or if all spaces on the board are filled with no winner, the game is considered a draw.

Instructions for running the program
Download and install Visual Studio or any other C# code editor of your choice.
Create a new project, and add a new file to the project called TicTacToe.cs.
Copy and paste the code in the TicTacToe.cs file into your new file, and save it.
Run the program.
Game menu
When the program is run, it displays a menu with three options:

New game: starts a new game.
About the author: displays the author's name, student number, and email address.
Quit: prompts the user to confirm if they want to exit the program.

The game board
The game board is a 3 x 3 matrix displayed on the console. The board is initialized at the beginning of each game, and each space on the board is marked with an empty space character (' ').

Game play
Player X always goes first, and then the players take turns making moves.
Each player is prompted to enter the position number on the board where they want to place their symbol.
A player's symbol can only be placed in an empty space on the board.
If a player places three of their symbols in a horizontal, vertical, or diagonal row, they win the game.
If all spaces on the board are filled with no winner, the game is considered a draw.

Functions
The program includes several functions:

Main function: displays the menu options and calls the relevant function based on the user's choice.
NewGame function: initializes the game board and loops until a winner is declared or the game is a draw.
AboutTheAuthor function: displays the author's name, student number, and email address.
Quit function: prompts the user to confirm if they want to exit the program.
Board function: displays the game board on the console.
ResetBoard function: resets the game board to its initial state.
EnterXorO function: adds a player's symbol to the game board based on their input.
CheckWinAndDraw function: checks if there is a winner or if the game is a draw.

Enum
The program includes one enum:

MenuOption enum: defines the three menu options: NewGame, AboutAuthor, and Quit.
Variables
The program includes several variables:

player variable: stores the current player's symbol (X or O).
input variable: stores the user's input for the position on the board where they want to place their symbol.
inputIsCorrect variable: stores a boolean value indicating whether the user's input is valid.
turns variable: stores the number of turns that have been played in the current game.
playBoard variable: stores the current state of the game board. The board is represented as a 3 x 3 matrix of characters.

Flow
When the program is run, the Main function is called and displays the menu options.
If the user selects the "New game" option, the NewGame function is called.
If the user selects the "About the author" option, the AboutTheAuthor
