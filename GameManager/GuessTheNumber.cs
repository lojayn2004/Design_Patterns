using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerApp
{
    internal class GuessTheNumber: IGameStrategy
    {
        private int Number;

        private void getRandomNumber()
        {
            Random random = new Random(101);
            Number = random.Next(101);
        }
        public void Run()
        {
            getRandomNumber();
            Console.WriteLine("Enter Your guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                if(guess > Number)
                {
                    Console.WriteLine("Too High ....");
                }
                else if(guess < Number)
                {
                    Console.WriteLine("Too Low .....");
                }
                else
                {
                    Console.WriteLine("Congratsss !! \nYou guessed The Number Correctly \n");
                    break;
                }
                Console.WriteLine("Enter Your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
