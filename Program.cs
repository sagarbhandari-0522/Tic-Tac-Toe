using System;
using System.Collections.Generic;
using System.Globalization;
using System.Media;

namespace Tic_Tac_Toe
{
    public class Tic_Tac_Toe
    {
        List<string> playerInput = new List<string>();
        public List<int> player1Input = new List<int>();
       public List<int> player2Input = new List<int>();
        int currentTurn;


        public Tic_Tac_Toe()
        {

            Console.WriteLine("Application Started");

            Console.WriteLine("Welcome To Tic-Tac-Toe");

            for (int i = 1; i < 10; i++)
            {
                playerInput.Add(i.ToString());
            }
            Console.WriteLine("Player 1 is X");
            Console.WriteLine("Player 2 is O");

        }
        public void TogglePlayerTurn()
        {
            currentTurn = currentTurn == 1 ? 2 : 1;

        }
        public void DisplayBoard()
        {
            Console.WriteLine($"{playerInput[0]} | {playerInput[1]} | {playerInput[2]}");
            Console.WriteLine("______________");
            Console.WriteLine($"{playerInput[3]} | {playerInput[4]} | {playerInput[5]}");
            Console.WriteLine("______________");
            Console.WriteLine($"{playerInput[6]} | {playerInput[7]} | {playerInput[8]}");
        }
        public void DisplayPlayerTurn()
        {
            Console.WriteLine("Player {0} Turn", currentTurn);
        }

        public void TakeUserInput()
        {
            bool isValidInput;
            do
            {
                int.TryParse(Console.ReadLine(), out int position);
                isValidInput = CheckInputValidity(position);
                if (isValidInput)
                {
                    playerInput[position - 1] = GetSymbol();
                    if (currentTurn == 1)
                        player1Input.Add(position);
                    else
                        player2Input.Add(position);
                }
                else
                {
                    Console.WriteLine("Invalid Input Please Enter in a Valid Box");
                }
            } while (!isValidInput);
        }

        public string GetSymbol()
        {
            return (currentTurn == 1 ? "X" : "O");

        }
        public bool CheckInputValidity(int position)
        {
            return (position >= 1 && position <= 9 && playerInput[position - 1] != "X" && playerInput[position - 1] != "O");
        }
        public bool CheckWinCondition()
        {
            return true;
        }

        public void InsertPositionToPlayer()
        {

        }


    }
    public class Program
    {
        static void Main(string[] args)
        {
            Tic_Tac_Toe t = new Tic_Tac_Toe();

            do
            {
                t.DisplayBoard();
                t.TogglePlayerTurn();
                t.DisplayPlayerTurn();
                t.TakeUserInput();
                t.InsertPositionToPlayer();
                Console.WriteLine("Player 1 Input");
                for (int i = 0; i < (t.player1Input).Count; i++)
                {
                    Console.Write("{0} ", t.player1Input[i]);
                }
                Console.WriteLine("Player 2 Input");

                for (int i = 0; i < (t.player2Input).Count; i++)
                {
                    Console.Write("{0} ", t.player2Input[i]);
                }
            } while (t.CheckWinCondition());

          
          

        }
        

    }
}

