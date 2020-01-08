using System;

namespace ticTacToe
{
    class Program
    {
        static char[,] dispNum = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        
        static int turns = 0;
        static void Main(string[] args)
        {
            int player = 2; // player 1 starts cos of condition in do while loop
            int input = 0;
            bool correctInput = true;

            do
            {
                if (player == 2) { 
                    player = 1;
                    SignEntering('X', input);
                }
                else if (player == 1) { 
                    player = 2;
                    SignEntering('O', input);
                }

                GameField();
                //start
                //check condition for winning
                char[] playerChar = { 'O','X'};
                foreach (char playChar in playerChar)
                {
                    if ((dispNum[0, 0] == playChar) && (dispNum[0, 1] == playChar) && (dispNum[0, 2] == playChar)
                        || (dispNum[1, 0] == playChar) && (dispNum[1, 1] == playChar) && (dispNum[1, 2] == playChar)
                        || (dispNum[2, 0] == playChar) && (dispNum[2, 1] == playChar) && (dispNum[2, 2] == playChar)
                        || (dispNum[0, 0] == playChar) && (dispNum[1, 0] == playChar) && (dispNum[2, 0] == playChar)
                        || (dispNum[0, 1] == playChar) && (dispNum[1, 1] == playChar) && (dispNum[2, 1] == playChar)
                        || (dispNum[0, 2] == playChar) && (dispNum[1, 2] == playChar) && (dispNum[2, 2] == playChar)
                        || (dispNum[0, 0] == playChar) && (dispNum[1, 1] == playChar) && (dispNum[2, 2] == playChar)
                        || (dispNum[2, 0] == playChar) && (dispNum[1, 1] == playChar) && (dispNum[0, 2] == playChar)
                        )
                    {
                        switch (playChar)
                        {
                            case 'X':
                                Console.WriteLine("Player 1 Wins");
                                break;
                            case 'O':
                                Console.WriteLine("Player 2 Wins");
                                break;
                        }
                        //Reset field
                        Console.WriteLine("Press any key to reset game");
                        Console.ReadKey();
                        ResetGameField();
                        break;
                    }else if (turns == 10)
                    {
                        Console.WriteLine("Game ended in a draw");
                        Console.WriteLine("Press any key to reset game");
                        Console.ReadKey();
                        ResetGameField();
                        break;
                    }
                }
                //end

                //start
                //checking if field has been selected
                do
                {
                    Console.Write("\n Player {0}: Choose your field!: ", player);
                    try{
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("!!! Input should be a number");
                    }
                    if ((input == 1) && (dispNum[0, 0] == '1'))
                        correctInput = true;
                    else if ((input == 2) && (dispNum[0, 1] == '2'))
                        correctInput = true;
                    else if ((input == 3) && (dispNum[0, 2] == '3'))
                        correctInput = true;
                    else if ((input == 4) && (dispNum[1, 0] == '4'))
                        correctInput = true;
                    else if ((input == 5) && (dispNum[1, 1] == '5'))
                        correctInput = true;
                    else if ((input == 6) && (dispNum[1, 2] == '6'))
                        correctInput = true;
                    else if ((input == 7) && (dispNum[2, 0] == '7'))
                        correctInput = true;
                    else if ((input == 8) && (dispNum[2, 1] == '8'))
                        correctInput = true;
                    else if ((input == 9) && (dispNum[2, 2] == '9'))
                        correctInput = true;
                    else
                    {
                        Console.WriteLine("!!! Field has alraedy been chosen. Please choose another field");
                        correctInput = false;
                    }
                } while (!correctInput);
                //end
            } while (true);
        }
        public static void ResetGameField()
        {
            char[,] dispNumInit = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            dispNum = dispNumInit;           
            GameField();
            turns = 0;
        }
        public static void GameField()
        {
            Console.Clear();
            Console.WriteLine("===================================================");
            Console.WriteLine("|| \t" + "\t || \t" + "\t || \t" + "\t ||");
            Console.WriteLine("|| \t" + dispNum[0, 0] + "\t || \t" + dispNum[0, 1] + "\t || \t" + dispNum[0, 2] + "\t ||");
            Console.WriteLine("|| \t" + "\t || \t" + "\t || \t" + "\t ||");
            Console.WriteLine("===================================================");
            Console.WriteLine("|| \t" + "\t || \t" + "\t || \t" + "\t ||");
            Console.WriteLine("|| \t" + dispNum[1, 0] + "\t || \t" + dispNum[1, 1] + "\t || \t" + dispNum[1, 2] + "\t ||");
            Console.WriteLine("|| \t" + "\t || \t" + "\t || \t" + "\t ||");
            Console.WriteLine("===================================================");
            Console.WriteLine("|| \t" + "\t || \t" + "\t || \t" + "\t ||");
            Console.WriteLine("|| \t" + dispNum[2, 0] + "\t || \t" + dispNum[2, 1] + "\t || \t" + dispNum[2, 2] + "\t ||");
            Console.WriteLine("|| \t" + "\t || \t" + "\t || \t" + "\t ||");
            Console.WriteLine("===================================================");
            turns++;
        }

        public static void SignEntering(char playerSign, int input)
        {
            switch (input)
            {
                case 1:
                    dispNum[0, 0] = playerSign; 
                    break;
                case 2:
                    dispNum[0, 1] = playerSign;
                    break;
                case 3:
                    dispNum[0, 2] = playerSign;
                    break;
                case 4:
                    dispNum[1, 0] = playerSign;
                    break;
                case 5:
                    dispNum[1, 1] = playerSign;
                    break;
                case 6:
                    dispNum[1, 2] = playerSign;
                    break;
                case 7:
                    dispNum[2, 0] = playerSign;
                    break;
                case 8:
                    dispNum[2, 1] = playerSign;
                    break;
                case 9:
                    dispNum[2, 2] = playerSign;
                    break;
            }
        }
    }
}
