using System;

namespace c_sharp_learning
{
    class Program
    {
        // Two dimensional array
        static int[,] matrix =
        {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
        };

        public static void showDiagnoOf2DMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // go through the second dimension 
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        //  matrix[i, j] = 222;
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }

        static char[,] playfield =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'},
        };

        public static void SetField()
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
        }

        public static void ResetField()
        {
            char[,] playfieldInitial =
            {
                {'1', '2', '3'},
                {'4', '5', '6'},
                {'7', '8', '9'},
            };

            playfield = playfieldInitial; 
            SetField();
        }

        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (input)
            {
                case 1:
                    playfield[0, 0] = playerSign; break;
                case 2:
                    playfield[0, 1] = playerSign; break;
                case 3:
                    playfield[0, 2] = playerSign; break;
                case 4:
                    playfield[1, 0] = playerSign; break;
                case 5:
                    playfield[1, 1] = playerSign; break;
                case 6:
                    playfield[1, 2] = playerSign; break;
                case 7:
                    playfield[2, 0] = playerSign; break;
                case 8:
                    playfield[2, 1] = playerSign; break;
                case 9:
                    playfield[2, 2] = playerSign; break;
            }
        }


        /// <summary>
        /// This is the entry point 
        /// </summary>
        public static void Main(string[] args)
        {

            int player = 2; // Player 1 starts
            int input = 0;
            bool inputFlag = true;

            // Run code as long as the program runs
            do
            {

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }

                SetField();

                #region
                // Check winner 
                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((playfield[0, 0] == playerChar) && (playfield[0, 1] == playerChar) && (playfield[0, 2] == playerChar))
                        || ((playfield[1, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[1, 2] == playerChar))
                        || ((playfield[2, 0] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 0] == playerChar) && (playfield[2, 0] == playerChar))
                        || ((playfield[0, 1] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 1] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[1, 2] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 0] == playerChar))
                        )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("Player 2(X) has won!");
                        }
                        else
                        {
                            Console.WriteLine("Player 1(O) has won!");
                        }

                        Console.WriteLine("Please press any key to reset the game.");

                        Console.ReadKey();

                        ResetField();

                        break;
                    }
                }

                #endregion

                #region
                // See if field is already taken
                do
                {
                    Console.Write("\nPlayer {0}: Choose your field --->  ", player);

                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (playfield[0, 0] == '1'))
                        inputFlag = true;
                    else if ((input == 2) && (playfield[0, 1] == '2'))
                        inputFlag = true;
                    else if ((input == 3) && (playfield[0, 2] == '3'))
                        inputFlag = true;
                    else if ((input == 4) && (playfield[1, 0] == '4'))
                        inputFlag = true;
                    else if ((input == 5) && (playfield[1, 1] == '5'))
                        inputFlag = true;
                    else if ((input == 6) && (playfield[1, 2] == '6'))
                        inputFlag = true;
                    else if ((input == 7) && (playfield[2, 0] == '7'))
                        inputFlag = true;
                    else if ((input == 8) && (playfield[2, 1] == '8'))
                        inputFlag = true;
                    else if ((input == 9) && (playfield[2, 2] == '9'))
                        inputFlag = true;
                    else
                    {
                        Console.WriteLine("\nOccupied! Please place on another field!");
                        inputFlag = false;
                    }
                } while (!inputFlag);
                #endregion

            } while (true);
        }
    }
}




























