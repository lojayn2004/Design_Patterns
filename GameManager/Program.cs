
using GameManagerApp;
using System.Collections.Specialized;

class Program
{

    public static void Main()
    {
        GameManager manager = GameManager.GetGameManager();
        Console.WriteLine("--------------- " + "Guess The Number" + "--------------");
        manager.setGame(new GuessTheNumber());

        manager.RunGame();
        Console.WriteLine("-------------------------------------------------------\n\n");

        Console.WriteLine("--------------- " + "Rock Scissor Paper" + "--------------");

        manager.setGame(new RockSciossrPaper());
        manager.RunGame();

    }

}