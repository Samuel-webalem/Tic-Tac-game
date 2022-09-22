using System;

namespace Tic_Tac_game
{
    class Program
    {
        static char[,] playerfield =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };
        static char[,] playerfieldinitial =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };
       static  int turn;
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputcorrect = true;

            do
            {

                if (player==2)
                {
                    player = 1;
                    EnterXorO('O', input);
                }
                else if (player==1)
                {
                    player = 2;
                    EnterXorO('X', input);
                }
                setfield();

                char[] playerchars = { 'X', 'O' };
                foreach (char playerchar in playerchars)
                {
                    if (((playerfield[0,0]==playerchar)&&(playerfield[0, 1] == playerchar)&&(playerfield[0, 2] == playerchar))
                        || ((playerfield[1, 0] == playerchar) && (playerfield[1, 1] == playerchar) && (playerfield[1, 2] == playerchar))
                        || ((playerfield[2, 0] == playerchar) && (playerfield[2, 1] == playerchar) && (playerfield[2, 2] == playerchar))
                        || ((playerfield[0, 0] == playerchar) && (playerfield[1, 0] == playerchar) && (playerfield[2, 0] == playerchar))
                        || ((playerfield[0, 1] == playerchar) && (playerfield[1, 1] == playerchar) && (playerfield[2, 1] == playerchar))
                        || ((playerfield[0, 2] == playerchar) && (playerfield[1, 2] == playerchar) && (playerfield[2, 2] == playerchar))
                        || ((playerfield[0, 0] == playerchar) && (playerfield[1, 1] == playerchar) && (playerfield[2, 2] == playerchar))
                        || ((playerfield[0, 2] == playerchar) && (playerfield[1, 1] == playerchar) && (playerfield[2, 0] == playerchar))
                        )
                    {
                        if (playerchar == 'X')
                        {
                            Console.WriteLine("\n Player 2 win");
                        }
                        else if(playerchar =='O')
                        {
                            Console.WriteLine("\n Player 1 win");
                        }
                        Console.WriteLine("\n Press any key to restart the game");
                        Console.ReadKey();
                        Resetfield();
                        break;
                    }
                    else if(turn==10)
                    {
                        Console.WriteLine("\n DRAW ");
                        Console.WriteLine("\n Press any key to restart the game");
                        Console.ReadKey();
                        Resetfield();
                    }
                   
                }

                do
                {
                    Console.Write("\nPlayer {0}: Choose your field!  ",player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter number");
                    }

                    if ((input == 1) && (playerfield[0, 0] =='1')
                        || (input == 2) && (playerfield[0, 1] == '2')
                        || (input == 3) && (playerfield[0, 2] == '3')
                        || (input == 4) && (playerfield[1, 0] == '4')
                        || (input == 5) && (playerfield[1, 1] == '5')
                        || (input == 6) && (playerfield[1, 2] == '6')
                        || (input == 7) && (playerfield[2, 0] == '7')
                        || (input == 8) && (playerfield[2, 1] == '8')
                        || (input == 9) && (playerfield[2, 2] == '9'))
                    {
                        inputcorrect = true;
                    } 
                    else
                    {
                        Console.WriteLine(" Incorect input! please use another field");
                        inputcorrect = false;
                    }
                } while (!inputcorrect);

            } while (true);
        }

        public static void setfield()
        {
            Console.Clear();
            Console.WriteLine("|     |       |      |");
            Console.WriteLine("|  {0}  |   {1}   |   {2}  |", playerfield[0,0], playerfield[0, 1], playerfield[0, 2]);
            Console.WriteLine("|_____|_______|______|");
            Console.WriteLine("|     |       |      |");
            Console.WriteLine("|  {0}  |   {1}   |   {2}  |", playerfield[1, 0], playerfield[1, 1], playerfield[1, 2]);
            Console.WriteLine("|_____|_______|______|");
            Console.WriteLine("|     |       |      |");
            Console.WriteLine("|  {0}  |   {1}   |   {2}  |", playerfield[2, 0], playerfield[2, 1], playerfield[2, 2]);
            Console.WriteLine("|     |       |      |");

            turn++;
        }

        public static void Resetfield()
        {
            playerfield = playerfieldinitial;
            turn = 0;
            setfield();
        }
        public static void EnterXorO(char playersign,int input)
        {
            switch (input)
            {
                case 1: playerfield[0, 0] = playersign; break;
                case 2: playerfield[0, 1] = playersign; break;
                case 3: playerfield[0, 2] = playersign; break;
                case 4: playerfield[1, 0] = playersign; break;
                case 5: playerfield[1, 1] = playersign; break;
                case 6: playerfield[1, 2] = playersign; break;
                case 7: playerfield[2, 0] = playersign; break;
                case 8: playerfield[2, 1] = playersign; break;
                case 9: playerfield[2, 2] = playersign; break;

            }
        }

    }
}
