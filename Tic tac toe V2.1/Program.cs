
using System.Numerics;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to the Tic tac toe V2.1!");


char[] pos = new char[9];
bool playing = true;
bool X = true;
bool O = true;
int end = 0;
int flag = 0;

Console.WriteLine("\n");
Console.WriteLine("1. New Game");
Console.WriteLine("2. About the author");
Console.WriteLine("3. Exit");

Console.Write("> ");
int menu = Convert.ToInt32(Console.ReadLine());

switch (menu)
{
    case 1:
        Console.WriteLine("   |   |   ");
        Console.WriteLine("---+---+---");
        Console.WriteLine("   |   |   ");
        Console.WriteLine("---+---+---");
        Console.WriteLine("   |   |   ");

        do
        {

            try
            {

                if (X)
                {
                Again:
                    Console.WriteLine("\n");
                    Console.Write("X's move > ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (pos[choice - 1] != 'X' && pos[choice - 1] != 'O')
                    {
                        pos[choice - 1] = 'X';
                        Board();// calling the board Function
                        end += 1;
                    }
                    else
                    {
                        Console.WriteLine("Illegal move! Try again.");
                        goto Again;
                    }
                    flag = CheckWin();// calling of check win
                }
                if (O)
                {
                    Again:
                    Console.WriteLine("\n");
                    Console.Write("O's move > ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (pos[choice - 1] != 'X' && pos[choice - 1] != 'O')
                    {
                        pos[choice - 1] = 'O';
                        Board();// calling the board Function
                        end += 1;
                    }
                    else
                    {
                        Console.WriteLine("Illegal move! Try again.");

                        goto Again;
                    }
                    flag = CheckWin();// calling of check win
                }
            }
            catch
            {
                Console.WriteLine("Illegal move! Try again.");

            }
            if (end == 9)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Game Over");
                break;
            }

        }while(flag != 1 && flag != -1);
        // if flag value is 1 then someone has win or
        //means who played marked last time which has win
        if (flag == 1)
        {
            Console.WriteLine($"Player {X} has won");
        }
        else// if flag value is -1 the match will be draw and no one is winner
        {
            Console.WriteLine("Draw");
        }
        break;
        
    case 2:
        string firstName = "Eric";
        string lastName = "Muganga";
        string studentNumber = "pzx114029";
        string email = "mugangaeric2020@gmail.com";
        Console.WriteLine($"The author of this program is {firstName} {lastName}" +
            $" \n Student Number: {studentNumber} " +
            $" \n Email: {email}");
        break;
    case 3:
        Console.WriteLine("Are you sure you want to quit? [y/n]");
        Console.Write("> ");
        char quit  = Convert.ToChar(Console.ReadLine());
        if(quit == 'n') 
        {
            
        }else if (quit == 'y') { break; }
        else { Console.WriteLine("Invalid Input"); }
        break;
     default:
        Console.WriteLine("Invalid Input");
        break;
}


// Board function which creats board
void Board()
{
    Console.WriteLine($" {pos[0]} | {pos[1]} | {pos[2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {pos[3]} | {pos[4]} | {pos[5]}  ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {pos[6]} | {pos[7]} | {pos[8]}  ");

}


int CheckWin()
{
    #region Horzontal Winning Condtion
    //Winning Condition For First Row
    if (pos[0] == pos[1] && pos[1] == pos[2])
    {
        return 1;
    }
    //Winning Condition For Second Row
    else if (pos[3] == pos[4] && pos[4] == pos[5])
    {
        return 1;
    }
    //Winning Condition For Third Row
    else if (pos[6] == pos[7] && pos[7] == pos[8])
    {
        return 1;
    }
    #endregion
    #region vertical Winning Condtion
    //Winning Condition For First Column
    else if (pos[0] == pos[3] && pos[3] == pos[6])
    {
        return 1;
    }
    //Winning Condition For Second Column
    else if (pos[1] == pos[4] && pos[4] == pos[7])
    {
        return 1;
    }
    //Winning Condition For Third Column
    else if (pos[2] == pos[5] && pos[5] == pos[8])
    {
        return 1;
    }
    #endregion
    #region Diagonal Winning Condition
    else if (pos[0] == pos[4] && pos[4] == pos[8])
    {
        return 1;
    }
    else if (pos[2] == pos[4] && pos[4] == pos[6])
    {
        return 1;
    }
    #endregion
    #region Checking For Draw
    // If all the cells or values filled with X or O then any player has won the match
    else if (pos[0]-1 != '1' && pos[1]-1 != '2' && pos[3]-1 != '3' && pos[4] - 1 != '4' && pos[5] - 1 != '5' && pos[6] - 1 != '6' && pos[7] - 1 != '7' && pos[8] - 1 != '8' && pos[9] - 1 != '9')
    {
        return -1;
    }
    #endregion
    else
    {
        return 0;
    }
}