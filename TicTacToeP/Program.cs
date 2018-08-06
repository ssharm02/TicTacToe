using System;
using System.Runtime.InteropServices;

namespace TicTacToeP
{
    class Program
    {
        static void Main(string[] args)
        {
            int player = 2; //player 1 starts
            int input = 0;
            bool inputCorrect = true;

            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO('O', input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO('X', input);
                }
                CreateGrid();

                #region Winner
                //Check winning condition
                char[] playerChars = {'X', 'O'};

                foreach (char playerChar in playerChars)
                {
                    if ((playfield[0, 0] == playerChar.ToString()) && (playfield[0, 1] == playerChar.ToString()) && (playfield[0, 2] == playerChar.ToString())
                        || ((playfield[1, 0] == playerChar.ToString()) && (playfield[1, 1] == playerChar.ToString()) && (playfield[1, 2] == playerChar.ToString())
                        || ((playfield[2, 0] == playerChar.ToString()) && (playfield[2, 1] == playerChar.ToString()) && (playfield[2, 2] == playerChar.ToString())
                        || ((playfield[0, 0] == playerChar.ToString()) && (playfield[1, 0] == playerChar.ToString()) && (playfield[2, 0] == playerChar.ToString())
                        || ((playfield[0, 1] == playerChar.ToString()) && (playfield[1, 1] == playerChar.ToString()) && (playfield[2, 1] == playerChar.ToString())
                        || ((playfield[0, 2] == playerChar.ToString()) && (playfield[2, 1] == playerChar.ToString()) && (playfield[2, 2] == playerChar.ToString()))
                        || ((playfield[0, 0] == playerChar.ToString()) && (playfield[1, 1] == playerChar.ToString()) && (playfield[2, 2] == playerChar.ToString()))
                        || ((playfield[0, 2] == playerChar.ToString()) && (playfield[1, 1] == playerChar.ToString()) && (playfield[2, 0] == playerChar.ToString())))))))

                    {

                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\n Player 2 has won");
                        }
                        else
                        {
                            Console.WriteLine("\n Player 1 has won");
                        }
                        Console.WriteLine("\n Press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\n Draw");
                        Console.WriteLine("\n Press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();

                        break;
                    }
                }

                #endregion



                #region MyRegion
                //Test if field is already taken


                do
                {
                    Console.Write("\n Player {0}: Choose your field! ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a number!");
                    }

                    if ((input == 1) && (playfield[0, 0] == "1"))
                    {
                        inputCorrect = true;
                    } else if ((input == 2) && (playfield[0, 1] == "2"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playfield[0, 2] == "3"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playfield[1, 0] == "4"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playfield[1, 1] == "5"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playfield[1, 2] == "6"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (playfield[2, 0] == "7"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playfield[2, 1] == "8"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playfield[2, 2] == "9"))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("\n Incorrect Input.  Please use another field!");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
#endregion
            } while (true);
        }

        // Playfield
        public static string[,] playfield = new string[,]
        {

            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
        };


        private static int turns = 0;
        public static void ResetField()
        {
         string[,] initialField = 
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
        };
        playfield = initialField;
            CreateGrid();
            turns = 0;

        }

        private static void CreateGrid()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[0, 0], playfield[0, 1], playfield[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[1, 0], playfield[1, 1], playfield[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[2, 0], playfield[2, 1], playfield[2, 2]);
            Console.WriteLine("     |     |     ");
            turns++;
        }


        public static void EnterXorO(char playerSign, int input)
        {

            switch (input)
            {
                case 1:
                    playfield[0, 0] = playerSign.ToString();
                    break;
                case 2:
                    playfield[0, 1] = playerSign.ToString();
                    break;
                case 3:
                    playfield[0, 2] = playerSign.ToString();
                    break;
                case 4:
                    playfield[1, 0] = playerSign.ToString();
                    break;
                case 5:
                    playfield[1, 1] = playerSign.ToString();
                    break;
                case 6:
                    playfield[1, 2] = playerSign.ToString();
                    break;
                case 7:
                    playfield[2, 0] = playerSign.ToString();
                    break;
                case 8:
                    playfield[2, 1] = playerSign.ToString();
                    break;
                case 9:
                    playfield[2, 2] = playerSign.ToString();
                    break;
            }
        }
    }
}
