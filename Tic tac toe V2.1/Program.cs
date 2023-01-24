
using System;
using System.Numerics;

namespace Tic_tac_toe_V21
{
    enum MenuOption
    {
        NewGame = 1,
        AboutAuthor = 2,
        Quit = 3,
    }

    class Program
    {

        static char player = 'O';
        static int input = 0;
        static bool inputIsCorrect = true;

        static int turns = 0;
        static char[,] playBoard = new char[,]
        {
            {' ', ' ', ' '},
            {' ', ' ', ' '},
            {' ', ' ', ' '}
        };

        static void Main(string[] args)
        {

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. New game");
            Console.WriteLine("2. About the author");
            Console.WriteLine("3. Quit");
            Console.WriteLine();
            Console.Write("\nEnter your choice: ");



            int choiceMenu = int.Parse(Console.ReadLine());
            MenuOption option = (MenuOption)choiceMenu;


            switch (option)
            {
                case MenuOption.NewGame:
                    // New game
                    NewGame();
                    break;
                case MenuOption.AboutAuthor:
                    // About the author
                    AboutTheAuthor();
                    break;
                case MenuOption.Quit:
                    // Quit
                    Quit();
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
            
        }


        static void NewGame()
        {
            do
            {
                if (player == 'X')
                {
                    player = 'O';
                    EnterXorO('X', input);
                }
                else if (player == 'O')
                {
                    player = 'X';
                    EnterXorO('O', input);
                }

                Board();

                CheckWinAndDraw();

                #region
                // Tests if the position on the board is taken
                do
                {
                    Console.Write($"\nPlayer {player}'s move > ");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("\nIllegal move! Try again.");
                    }

                    if ((input == 1) && (playBoard[0, 0] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 2) && (playBoard[0, 1] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 3) && (playBoard[0, 2] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 4) && (playBoard[1, 0] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 5) && (playBoard[1, 1] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 6) && (playBoard[1, 2] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 7) && (playBoard[2, 0] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 8) && (playBoard[2, 1] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 9) && (playBoard[2, 2] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("\nIllegal move! Try again.");
                        inputIsCorrect = false;

                    }


                } while (!inputIsCorrect);
                #endregion

            } while (true);
        }
        static void AboutTheAuthor()
        {
            string firstName = "Eric";
            string lastName = "Muganga";
            string studentNumber = "pzx114029";
            string email = "mugangaeric2020@gmail.com";
            Console.WriteLine($"The author of this program is {firstName} {lastName}" +
                $" \n Student Number: {studentNumber} " +
                $" \n Email: {email}");
        }

        static void Quit()
        {
            Console.Write("Are you sure you want to quit? (Y/N) > ");
            string confirm = Console.ReadLine();
            if (confirm == "Y" || confirm == "y")
            {
                return;
            }
           
        }
        // Board function which creats board
        static void Board()
        {
            Console.Clear();
            Console.WriteLine($" {playBoard[0, 0]} | {playBoard[0, 1]} | {playBoard[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {playBoard[1, 0]} | {playBoard[1, 1]} | {playBoard[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {playBoard[2, 0]} | {playBoard[2, 1]} | {playBoard[2, 2]} ");
            turns++;
        }

        static void ResetBoard()
        {
            char[,] playBoardInitial = new char[,]
            {
        {' ', ' ', ' '},
        {' ', ' ', ' '},
        {' ', ' ', ' '}
            };
            playBoard = playBoardInitial;
            Board();
            turns = 0;
        }

        static void EnterXorO(char playerSign, int input)
        {

            switch (input)
            {
                case 1:
                    playBoard[0, 0] = playerSign; break;
                case 2:
                    playBoard[0, 1] = playerSign; break;
                case 3:
                    playBoard[0, 2] = playerSign; break;
                case 4:
                    playBoard[1, 0] = playerSign; break;
                case 5:
                    playBoard[1, 1] = playerSign; break;
                case 6:
                    playBoard[1, 2] = playerSign; break;
                case 7:
                    playBoard[2, 0] = playerSign; break;
                case 8:
                    playBoard[2, 1] = playerSign; break;
                case 9:
                    playBoard[2, 2] = playerSign; break;
            }
        }
        static void CheckWinAndDraw()
        {
            #region
            //// check winning condition
            char[] playerChars = { 'X', 'O' };

            foreach (char playerChar in playerChars)
            {
                if (((playBoard[0, 0] == playerChar) && (playBoard[0, 1] == playerChar) && (playBoard[0, 2] == playerChar))
                  || ((playBoard[1, 0] == playerChar) && (playBoard[1, 1] == playerChar) && (playBoard[1, 2] == playerChar))
                  || ((playBoard[2, 0] == playerChar) && (playBoard[2, 1] == playerChar) && (playBoard[2, 2] == playerChar))
                  || ((playBoard[0, 0] == playerChar) && (playBoard[1, 0] == playerChar) && (playBoard[2, 0] == playerChar))
                  || ((playBoard[0, 1] == playerChar) && (playBoard[1, 1] == playerChar) && (playBoard[2, 1] == playerChar))
                  || ((playBoard[0, 2] == playerChar) && (playBoard[1, 2] == playerChar) && (playBoard[2, 2] == playerChar))
                  || ((playBoard[0, 0] == playerChar) && (playBoard[1, 1] == playerChar) && (playBoard[2, 2] == playerChar))
                  || ((playBoard[2, 0] == playerChar) && (playBoard[1, 1] == playerChar) && (playBoard[0, 2] == playerChar))
                  )
                {
                    if (playerChar == 'X')
                    {
                        Console.WriteLine("\nX has won ");
                    }
                    else
                    {
                        Console.WriteLine("\nO has won ");
                    }

                    Console.WriteLine("Press Enter To reset the The game");
                    Console.ReadKey();
                    
                    ResetBoard();
                    break;
                }
                else if (turns == 10)
                {
                    Console.WriteLine("\nIt's a Draw");
                    Console.WriteLine("Press Enter To reset the The game");
                    Console.ReadKey();

                    ResetBoard();
                    break;
                }
            }

            #endregion
        }
    }
}
