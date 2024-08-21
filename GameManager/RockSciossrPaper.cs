using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerApp
{
    internal class RockSciossrPaper: IGameStrategy
    {
        private string[] moves = { "Rock", "Scissor", "Paper" };

        private bool isWinner(string first, string second)
        {
            if (first == "Rock" && second == "Scissors")
                return true;
            if (first == "Paper" && second == "Rock")
                return true;
            if (first == "Scissors" && second == "Paper")
                return true;
            return false;
        }

        private string getComputerMove()
        {
            Random random = new Random();
            int rand = random.Next(3);
            return moves[rand];
        }
        public void Run()
        {
            while(true)
            {
                Console.WriteLine("Computer Is Choosing .....\n");
                string computerMove  = getComputerMove();
                Console.WriteLine("Computer Choosed ! \nYour Turn \n");
                Console.WriteLine("[1] Rock \n[2] Scissor \n[3] Paper");
                Console.Write("Enter Your Choice: ");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                if(userChoice < 1 || userChoice > 3)
                {
                    Console.WriteLine("Invalid Choice \n");
                    continue;
                }
                string normalMove = moves[userChoice - 1];
                Console.WriteLine($"Computer Move was {computerMove}");
                if(isWinner(computerMove, normalMove))
                {
                    Console.WriteLine("Computer Won !!\n");
                    break;
                }
                else if(isWinner(normalMove, computerMove))
                {
                    Console.WriteLine("You Won !!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Draw !!\n");
                    break;
                }
            }
        }
    }
}
